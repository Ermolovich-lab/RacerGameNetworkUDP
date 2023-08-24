
namespace WindowsForms
{
    partial class GameForm
    {
        private OpenTK.GLControl gLControl;

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gLControl = new OpenTK.GLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerOneTires = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerOneLaps = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerOneFuel = new System.Windows.Forms.Label();
            this.PlayerTwoFuel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerTwoLaps = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlayerTwoTires = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.POCountBullets = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.PTCountBullets = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.PlayLan = new System.Windows.Forms.Button();
            this.panelLan = new System.Windows.Forms.Panel();
            this.IPText = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLan.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gLControl
            // 
            this.gLControl.BackColor = System.Drawing.Color.Transparent;
            this.gLControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gLControl.BackgroundImage")));
            this.gLControl.Location = new System.Drawing.Point(0, 0);
            this.gLControl.Name = "gLControl";
            this.gLControl.Size = new System.Drawing.Size(1264, 681);
            this.gLControl.TabIndex = 0;
            this.gLControl.VSync = false;
            this.gLControl.Load += new System.EventHandler(this.GLControl_Load);
            this.gLControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GLControl_Paint);
            this.gLControl.Resize += new System.EventHandler(this.GLControl_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tires";
            // 
            // PlayerOneTires
            // 
            this.PlayerOneTires.AutoSize = true;
            this.PlayerOneTires.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneTires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerOneTires.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneTires.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerOneTires.Location = new System.Drawing.Point(-5, 29);
            this.PlayerOneTires.Name = "PlayerOneTires";
            this.PlayerOneTires.Size = new System.Drawing.Size(54, 29);
            this.PlayerOneTires.TabIndex = 5;
            this.PlayerOneTires.Text = "true";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(75, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Laps";
            // 
            // PlayerOneLaps
            // 
            this.PlayerOneLaps.AutoSize = true;
            this.PlayerOneLaps.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneLaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerOneLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneLaps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerOneLaps.Location = new System.Drawing.Point(75, 29);
            this.PlayerOneLaps.Name = "PlayerOneLaps";
            this.PlayerOneLaps.Size = new System.Drawing.Size(26, 29);
            this.PlayerOneLaps.TabIndex = 7;
            this.PlayerOneLaps.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(150, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fuel";
            // 
            // PlayerOneFuel
            // 
            this.PlayerOneFuel.AutoSize = true;
            this.PlayerOneFuel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerOneFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneFuel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerOneFuel.Location = new System.Drawing.Point(150, 31);
            this.PlayerOneFuel.Name = "PlayerOneFuel";
            this.PlayerOneFuel.Size = new System.Drawing.Size(26, 29);
            this.PlayerOneFuel.TabIndex = 9;
            this.PlayerOneFuel.Text = "0";
            // 
            // PlayerTwoFuel
            // 
            this.PlayerTwoFuel.AutoSize = true;
            this.PlayerTwoFuel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTwoFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerTwoFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoFuel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerTwoFuel.Location = new System.Drawing.Point(134, 29);
            this.PlayerTwoFuel.Name = "PlayerTwoFuel";
            this.PlayerTwoFuel.Size = new System.Drawing.Size(26, 29);
            this.PlayerTwoFuel.TabIndex = 15;
            this.PlayerTwoFuel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(95, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fuel";
            // 
            // PlayerTwoLaps
            // 
            this.PlayerTwoLaps.AutoSize = true;
            this.PlayerTwoLaps.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTwoLaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerTwoLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoLaps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerTwoLaps.Location = new System.Drawing.Point(179, 29);
            this.PlayerTwoLaps.Name = "PlayerTwoLaps";
            this.PlayerTwoLaps.Size = new System.Drawing.Size(26, 29);
            this.PlayerTwoLaps.TabIndex = 13;
            this.PlayerTwoLaps.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(166, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Laps";
            // 
            // PlayerTwoTires
            // 
            this.PlayerTwoTires.AutoSize = true;
            this.PlayerTwoTires.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTwoTires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerTwoTires.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoTires.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerTwoTires.Location = new System.Drawing.Point(258, 29);
            this.PlayerTwoTires.Name = "PlayerTwoTires";
            this.PlayerTwoTires.Size = new System.Drawing.Size(54, 29);
            this.PlayerTwoTires.TabIndex = 11;
            this.PlayerTwoTires.Text = "true";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(241, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tires";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.IndianRed;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Play.FlatAppearance.BorderSize = 4;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Play.Location = new System.Drawing.Point(52, 28);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(355, 56);
            this.Play.TabIndex = 17;
            this.Play.Text = "Play On One Screen";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.POCountBullets);
            this.panelLeft.Controls.Add(this.label7);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.PlayerOneTires);
            this.panelLeft.Controls.Add(this.PlayerOneLaps);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.PlayerOneFuel);
            this.panelLeft.Location = new System.Drawing.Point(0, 621);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(315, 60);
            this.panelLeft.TabIndex = 18;
            // 
            // POCountBullets
            // 
            this.POCountBullets.AutoSize = true;
            this.POCountBullets.BackColor = System.Drawing.Color.Transparent;
            this.POCountBullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POCountBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POCountBullets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.POCountBullets.Location = new System.Drawing.Point(221, 29);
            this.POCountBullets.Name = "POCountBullets";
            this.POCountBullets.Size = new System.Drawing.Size(26, 29);
            this.POCountBullets.TabIndex = 11;
            this.POCountBullets.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(221, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ammo";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.PTCountBullets);
            this.panelRight.Controls.Add(this.label11);
            this.panelRight.Controls.Add(this.label10);
            this.panelRight.Controls.Add(this.PlayerTwoTires);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.PlayerTwoLaps);
            this.panelRight.Controls.Add(this.PlayerTwoFuel);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelRight.Location = new System.Drawing.Point(940, 621);
            this.panelRight.Name = "panelRight";
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelRight.Size = new System.Drawing.Size(324, 60);
            this.panelRight.TabIndex = 19;
            // 
            // PTCountBullets
            // 
            this.PTCountBullets.AutoSize = true;
            this.PTCountBullets.BackColor = System.Drawing.Color.Transparent;
            this.PTCountBullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTCountBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTCountBullets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PTCountBullets.Location = new System.Drawing.Point(63, 29);
            this.PTCountBullets.Name = "PTCountBullets";
            this.PTCountBullets.Size = new System.Drawing.Size(26, 29);
            this.PTCountBullets.TabIndex = 17;
            this.PTCountBullets.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ammo";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWin.Location = new System.Drawing.Point(416, 284);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(132, 55);
            this.labelWin.TabIndex = 20;
            this.labelWin.Text = "none";
            // 
            // PlayLan
            // 
            this.PlayLan.BackColor = System.Drawing.Color.IndianRed;
            this.PlayLan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayLan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayLan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayLan.FlatAppearance.BorderSize = 4;
            this.PlayLan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayLan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayLan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayLan.Location = new System.Drawing.Point(52, 99);
            this.PlayLan.Name = "PlayLan";
            this.PlayLan.Size = new System.Drawing.Size(355, 56);
            this.PlayLan.TabIndex = 22;
            this.PlayLan.Text = "Play LAN";
            this.PlayLan.UseVisualStyleBackColor = false;
            this.PlayLan.Click += new System.EventHandler(this.PlayLan_Click);
            // 
            // panelLan
            // 
            this.panelLan.BackColor = System.Drawing.Color.Transparent;
            this.panelLan.Controls.Add(this.IPText);
            this.panelLan.Controls.Add(this.Create);
            this.panelLan.Controls.Add(this.Connect);
            this.panelLan.Location = new System.Drawing.Point(399, 375);
            this.panelLan.Name = "panelLan";
            this.panelLan.Size = new System.Drawing.Size(465, 240);
            this.panelLan.TabIndex = 23;
            this.panelLan.Visible = false;
            // 
            // IPText
            // 
            this.IPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPText.Location = new System.Drawing.Point(52, 16);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(355, 44);
            this.IPText.TabIndex = 25;
            this.IPText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.IndianRed;
            this.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create.FlatAppearance.BorderSize = 4;
            this.Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Create.Location = new System.Drawing.Point(52, 172);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(355, 56);
            this.Create.TabIndex = 24;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.IndianRed;
            this.Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Connect.FlatAppearance.BorderSize = 4;
            this.Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Connect.Location = new System.Drawing.Point(52, 66);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(355, 56);
            this.Connect.TabIndex = 23;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.Play);
            this.panelMain.Controls.Add(this.PlayLan);
            this.panelMain.Location = new System.Drawing.Point(402, 361);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(462, 180);
            this.panelMain.TabIndex = 24;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLan);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.gLControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameForm";
            this.Text = "Cool Racing";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLan.ResumeLayout(false);
            this.panelLan.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerOneTires;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlayerOneLaps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerOneFuel;
        private System.Windows.Forms.Label PlayerTwoFuel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PlayerTwoLaps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PlayerTwoTires;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Button PlayLan;
        private System.Windows.Forms.Panel panelLan;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Label POCountBullets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PTCountBullets;
        private System.Windows.Forms.Label label11;
    }
}

