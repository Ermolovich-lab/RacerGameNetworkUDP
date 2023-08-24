using EngineLibrary;
using GameLibrary.Map;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Maze
{
    public class Maps
    {
        /// <summary>
        /// Фабрика создания элементов лабиринта
        /// </summary>
        public MazeElementsFactory ElementsFactory { get; private set; }

        public List<Vector2> EmptyBlocks { get; private set; } = new List<Vector2>();

        /// <summary>
        /// Коллекция линий дороги
        /// </summary>
        public List<RacePoint> roadLines { get; private set; } = new List<RacePoint>();

        private LevelScene levelScene;

        public Maps(LevelScene levelScene)
        {
            this.levelScene = levelScene;
        }

        public GameObject[] CreateMap()
        {
            List<GameObject> gameObjects = new List<GameObject>();

            Random random = new Random();

            ElementsFactory = new MazeElementsFactory();

            float worldScale = Game.instance.HeightOfApplication / 15;

            //var points = new List<Vector2>();
            //points.Add(new Vector2(100, 100));
            //points.Add(new Vector2(200, 100));
            //points.Add(new Vector2(300, 100));

            //for (int i = 0; i < points.Count; i++)
            //{
            //    var gameObject = new GameObject();
            //    gameObject.GameObjectTag = "Road";

            //    TexturesBox texture1;
            //    texture1 = new TexturesBox(ContentPipe.LoadTexture("Road.png"));

            //    var script = new RoadLine();
            //    script.Start(gameObject);

            //    gameObject.SetComponent(texture1);
            //    gameObject.SetComponent(script);
            //    gameObject.SetComponent(new TransformComponent(points.ElementAt(i), new Vector2(1, 1), new Vector2(0.3f, 0.5f), 0));
            //    gameObject.SetComponent(new ColliderComponent(gameObject, 1f, new Vector2(0, 0)));

            //    game.AddObjectOnScene(gameObject);
            //}

            Bitmap bitmap = new Bitmap(@"Resources\Mazes\Maze_4.bmp");

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(j, i);

                    GameObject gameObject = null;

                    if (color.R == 0 && color.G == 0 && color.B == 0)
                        gameObject = ElementsFactory.CreateMazeElement(new Vector2(j, i) * worldScale, "Wall");
                    else if (color.R == 255 && color.G == 0 && color.B == 0)
                        levelScene.PlayerOneFactory.StartPosition = new Vector2(j, i) * worldScale;
                    else if (color.R == 0 && color.G == 0 && color.B == 255)
                        levelScene.PlayerTwoFactory.StartPosition = new Vector2(j, i) * worldScale;
                    else if (color.R == 0 && color.G == 255 && color.B == 0)
                        gameObject = ElementsFactory.CreateFinish(new Vector2(j, i) * worldScale, "Start");
                    else if (color.R == 0 && color.G == 255 && color.B == 255)
                        gameObject = ElementsFactory.CreateFinish(new Vector2(j, i) * worldScale, "CheckPoint");
                    else
                        EmptyBlocks.Add(new Vector2(j, i));

                    if (gameObject != null)
                        gameObjects.Add(gameObject);
                }
            }

            return gameObjects.ToArray();
        }
    }
}
