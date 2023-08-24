using GameLibrary;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Windows.Forms;
using NetworkLibrary;
using static System.Net.Mime.MediaTypeNames;
using EngineLibrary;
using GameLibrary.Maze;
using static GameLibrary.Maze.GameEvents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace WindowsForms
{
    public partial class GameForm : Form
    {
        Game game = new Game();

        public GameForm()
        {
            InitializeComponent();

            GameEvents.ChangeLaps += ChangeLaps;
            GameEvents.ChangeFuel += ChangeFuel;
            GameEvents.ChangeTires += ChangeTires;
            GameEvents.ChangeCount += ChangeCout;
            GameEvents.EndGame += EndGame;
        }

        private bool _loaded;
        private bool isRendring = false;

        private void GLControl_Load(object sender, EventArgs e)
        {
            GL.Enable(EnableCap.Blend);
            GL.Enable(EnableCap.Texture2D);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Viewport(0, 0, gLControl.Width, gLControl.Height);

            _loaded = true;

            gLControl.Invalidate();

            gLControl.Visible = false;
            panelLeft.Visible = false;
            panelRight.Visible = false;
            labelWin.Visible = false;
        }

        void GLControl_Paint(object sender, EventArgs e)
        {
            if(isRendring)
                Render();

            gLControl.Invalidate();
        }

        private void Render()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(System.Drawing.Color.CornflowerBlue);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, gLControl.Width, gLControl.Height, 0, 0, 1);
            game.Rendering();

            gLControl.SwapBuffers();
        }

        private void GLControl_Resize(object sender, EventArgs e)
        {
            if (!_loaded)
                return;
            GL.Viewport(0, 0, gLControl.Width, gLControl.Height);
            gLControl.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;

            isRendring = true;

            gLControl.Visible = true;
            Play.Visible = false;
            panelLeft.Visible = true;
            panelRight.Visible = true;
            panelMain.Visible = false;

            game.ChengeScene(new LevelScene());
        }

        private void PlayLan_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelLan.Visible = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            panelLan.Visible = false;
            gLControl.Visible = true;
            var seed = new Random().Next();
            var server = new Server();
            server.OnDataGot += (o) => OnClientServed(server, seed);
            OnClientServed(server, seed);
            //server.UpdateData("connect");
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            panelLan.Visible = false;
            gLControl.Visible = true;
            var address = IPText.Text;
            Client client = new Client(address);
            client.OnDataGot += (o) => OnServerResponsed(client, o);
            OnServerResponsed(client, address);
            //client.GetData<string>();
        }

        /// <summary>
        /// Событие результат подключения клиента
        /// </summary>
        /// <param name="handler">Интернет обработчик</param>
        /// <param name="obj">Полученные данные</param>
        private void OnServerResponsed(INetworkHandler handler, object obj)
        {
            var seed = (string)obj;
            handler.ClearListeners();
            Console.WriteLine(seed);
            game.ChengeScene(new LevelScene(handler, "PlayerTwo", "PlayerOne"));
            BackgroundImage = null;

            isRendring = true;

            gLControl.Visible = true;
            Play.Visible = false;
            panelLeft.Visible = true;
            panelRight.Visible = true;
            panelMain.Visible = false;

            PlayerOneFuel.Visible = false;
            POCountBullets.Visible = false;

            //StartGame(new MazeScene(handler, seed, "Red Player", "Blue Player"));
        }

        /// <summary>
        /// Событие обслуживания подключений сервером
        /// </summary>
        /// <param name="handler">Интернет обработчик</param>
        /// <param name="seed">Сид генерации</param>
        private void OnClientServed(INetworkHandler handler, int seed)
        {
            handler.ClearListeners();
            game.ChengeScene(new LevelScene(handler, "PlayerOne", "PlayerTwo"));
            BackgroundImage = null;

            isRendring = true;

            gLControl.Visible = true;
            Play.Visible = false;
            panelLeft.Visible = true;
            panelRight.Visible = true;
            panelMain.Visible = false;

            PlayerTwoFuel.Visible = false;
            PTCountBullets.Visible = false;

            //StartGame(new MazeScene(handler, seed, "Blue Player", "Red Player"));
        }

        private void ChangeLaps(string player, int value)
        {

            if (player == "PlayerOne")
            {
                value += Int32.Parse(PlayerOneLaps.Text);
                PlayerOneLaps.Text = value.ToString();
            }
            else
            {
                value += Int32.Parse(PlayerTwoLaps.Text);
                PlayerTwoLaps.Text = value.ToString();
            }
        }

        private void ChangeFuel(string player, float value)
        {
            if (player == "PlayerOne")
                PlayerOneFuel.Text = Math.Round(value, 2).ToString();
            else
                PlayerTwoFuel.Text = Math.Round(value, 2).ToString();
        }

        private void ChangeTires(string player, bool value)
        {
            if (player == "PlayerOne")
                PlayerOneTires.Text = value.ToString();
            else
                PlayerTwoTires.Text = value.ToString();
        }

        private void ChangeCout(string player, int count)
        {
            if (player == "PlayerOne")
                POCountBullets.Text = count.ToString();
            else
                PTCountBullets.Text = count.ToString();
        }

        private void EndGame(string winPlayer)
        {
            gLControl.Visible = false;

            if (winPlayer == "PlayerOne")
            {
                //Background = new SolidColorBrush(Color.FromRgb(9, 46, 168));
                labelWin.Text = "First player win";
            }
            else
            {
                //Background = new SolidColorBrush(Color.FromRgb(179, 22, 22));
                labelWin.Text = "Second player win";
            }

            labelWin.Visible = true;

            GameEvents.EndGame -= EndGame;
            GameEvents.ChangeLaps -= ChangeLaps;
            GameEvents.ChangeFuel -= ChangeFuel;
            GameEvents.ChangeTires -= ChangeTires;
        }
    }
}
