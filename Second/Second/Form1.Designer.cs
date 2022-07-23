
namespace Second
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MapIcon_Player = new System.Windows.Forms.PictureBox();
            this.MapIcon_Sword = new System.Windows.Forms.PictureBox();
            this.MapIcon_Bat = new System.Windows.Forms.PictureBox();
            this.MapIcon_Ghos = new System.Windows.Forms.PictureBox();
            this.MapIcon_Ghost = new System.Windows.Forms.PictureBox();
            this.MapIcon_BluePotion = new System.Windows.Forms.PictureBox();
            this.MapIcon_RedPotion = new System.Windows.Forms.PictureBox();
            this.MapIcon_Mase = new System.Windows.Forms.PictureBox();
            this.MapIcon_Bow = new System.Windows.Forms.PictureBox();
            this.Inventory_Sword = new System.Windows.Forms.PictureBox();
            this.Inventory_BluePostion = new System.Windows.Forms.PictureBox();
            this.Inventory_Bow = new System.Windows.Forms.PictureBox();
            this.Inventory_RedPotion = new System.Windows.Forms.PictureBox();
            this.Inventory_Maze = new System.Windows.Forms.PictureBox();
            this.PointPannel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHitPoint = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Label();
            this.Bat = new System.Windows.Forms.Label();
            this.BatHitPoint = new System.Windows.Forms.Label();
            this.Ghost = new System.Windows.Forms.Label();
            this.GhostHitPoint = new System.Windows.Forms.Label();
            this.Ghoul = new System.Windows.Forms.Label();
            this.GhoulHitPoint = new System.Windows.Forms.Label();
            this.MoveGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AttackGroupBox = new System.Windows.Forms.GroupBox();
            this.Attack_Up = new System.Windows.Forms.Button();
            this.Attack_Left = new System.Windows.Forms.Button();
            this.Attack_Right = new System.Windows.Forms.Button();
            this.Attack_Down = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Ghos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Mase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_BluePostion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Maze)).BeginInit();
            this.PointPannel.SuspendLayout();
            this.MoveGroupBox.SuspendLayout();
            this.AttackGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapIcon_Player
            // 
            this.MapIcon_Player.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Player.Image = global::Second.Properties.Resources.player;
            this.MapIcon_Player.Location = new System.Drawing.Point(79, 60);
            this.MapIcon_Player.Name = "MapIcon_Player";
            this.MapIcon_Player.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Player.TabIndex = 0;
            this.MapIcon_Player.TabStop = false;
            this.MapIcon_Player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MapIcon_Sword
            // 
            this.MapIcon_Sword.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Sword.Image = global::Second.Properties.Resources.sword;
            this.MapIcon_Sword.Location = new System.Drawing.Point(115, 60);
            this.MapIcon_Sword.Name = "MapIcon_Sword";
            this.MapIcon_Sword.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Sword.TabIndex = 1;
            this.MapIcon_Sword.TabStop = false;
            this.MapIcon_Sword.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MapIcon_Bat
            // 
            this.MapIcon_Bat.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Bat.Image = global::Second.Properties.Resources.bat;
            this.MapIcon_Bat.Location = new System.Drawing.Point(151, 60);
            this.MapIcon_Bat.Name = "MapIcon_Bat";
            this.MapIcon_Bat.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Bat.TabIndex = 2;
            this.MapIcon_Bat.TabStop = false;
            // 
            // MapIcon_Ghos
            // 
            this.MapIcon_Ghos.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Ghos.Image = global::Second.Properties.Resources.ghoul;
            this.MapIcon_Ghos.Location = new System.Drawing.Point(187, 60);
            this.MapIcon_Ghos.Name = "MapIcon_Ghos";
            this.MapIcon_Ghos.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Ghos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Ghos.TabIndex = 3;
            this.MapIcon_Ghos.TabStop = false;
            // 
            // MapIcon_Ghost
            // 
            this.MapIcon_Ghost.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Ghost.Image = global::Second.Properties.Resources.ghost;
            this.MapIcon_Ghost.Location = new System.Drawing.Point(223, 60);
            this.MapIcon_Ghost.Name = "MapIcon_Ghost";
            this.MapIcon_Ghost.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Ghost.TabIndex = 4;
            this.MapIcon_Ghost.TabStop = false;
            // 
            // MapIcon_BluePotion
            // 
            this.MapIcon_BluePotion.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_BluePotion.Image = global::Second.Properties.Resources.potion_blue;
            this.MapIcon_BluePotion.Location = new System.Drawing.Point(295, 60);
            this.MapIcon_BluePotion.Name = "MapIcon_BluePotion";
            this.MapIcon_BluePotion.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_BluePotion.TabIndex = 5;
            this.MapIcon_BluePotion.TabStop = false;
            // 
            // MapIcon_RedPotion
            // 
            this.MapIcon_RedPotion.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_RedPotion.Image = global::Second.Properties.Resources.potion_red1;
            this.MapIcon_RedPotion.Location = new System.Drawing.Point(331, 60);
            this.MapIcon_RedPotion.Name = "MapIcon_RedPotion";
            this.MapIcon_RedPotion.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_RedPotion.TabIndex = 6;
            this.MapIcon_RedPotion.TabStop = false;
            // 
            // MapIcon_Mase
            // 
            this.MapIcon_Mase.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Mase.Image = global::Second.Properties.Resources.mace;
            this.MapIcon_Mase.Location = new System.Drawing.Point(367, 60);
            this.MapIcon_Mase.Name = "MapIcon_Mase";
            this.MapIcon_Mase.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Mase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Mase.TabIndex = 7;
            this.MapIcon_Mase.TabStop = false;
            // 
            // MapIcon_Bow
            // 
            this.MapIcon_Bow.BackColor = System.Drawing.Color.Transparent;
            this.MapIcon_Bow.Image = global::Second.Properties.Resources.bow;
            this.MapIcon_Bow.Location = new System.Drawing.Point(259, 60);
            this.MapIcon_Bow.Name = "MapIcon_Bow";
            this.MapIcon_Bow.Size = new System.Drawing.Size(30, 30);
            this.MapIcon_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapIcon_Bow.TabIndex = 9;
            this.MapIcon_Bow.TabStop = false;
            this.MapIcon_Bow.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // Inventory_Sword
            // 
            this.Inventory_Sword.BackColor = System.Drawing.Color.Transparent;
            this.Inventory_Sword.Image = global::Second.Properties.Resources.sword1;
            this.Inventory_Sword.Location = new System.Drawing.Point(79, 319);
            this.Inventory_Sword.Name = "Inventory_Sword";
            this.Inventory_Sword.Size = new System.Drawing.Size(50, 50);
            this.Inventory_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_Sword.TabIndex = 10;
            this.Inventory_Sword.TabStop = false;
            // 
            // Inventory_BluePostion
            // 
            this.Inventory_BluePostion.BackColor = System.Drawing.Color.Transparent;
            this.Inventory_BluePostion.Image = global::Second.Properties.Resources.potion_blue1;
            this.Inventory_BluePostion.Location = new System.Drawing.Point(135, 319);
            this.Inventory_BluePostion.Name = "Inventory_BluePostion";
            this.Inventory_BluePostion.Size = new System.Drawing.Size(50, 50);
            this.Inventory_BluePostion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_BluePostion.TabIndex = 11;
            this.Inventory_BluePostion.TabStop = false;
            // 
            // Inventory_Bow
            // 
            this.Inventory_Bow.BackColor = System.Drawing.Color.Transparent;
            this.Inventory_Bow.Image = global::Second.Properties.Resources.bow1;
            this.Inventory_Bow.Location = new System.Drawing.Point(191, 319);
            this.Inventory_Bow.Name = "Inventory_Bow";
            this.Inventory_Bow.Size = new System.Drawing.Size(50, 50);
            this.Inventory_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_Bow.TabIndex = 12;
            this.Inventory_Bow.TabStop = false;
            // 
            // Inventory_RedPotion
            // 
            this.Inventory_RedPotion.BackColor = System.Drawing.Color.Transparent;
            this.Inventory_RedPotion.Image = global::Second.Properties.Resources.potion_red2;
            this.Inventory_RedPotion.Location = new System.Drawing.Point(247, 319);
            this.Inventory_RedPotion.Name = "Inventory_RedPotion";
            this.Inventory_RedPotion.Size = new System.Drawing.Size(50, 50);
            this.Inventory_RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_RedPotion.TabIndex = 13;
            this.Inventory_RedPotion.TabStop = false;
            // 
            // Inventory_Maze
            // 
            this.Inventory_Maze.BackColor = System.Drawing.Color.Transparent;
            this.Inventory_Maze.Image = global::Second.Properties.Resources.mace1;
            this.Inventory_Maze.Location = new System.Drawing.Point(303, 319);
            this.Inventory_Maze.Name = "Inventory_Maze";
            this.Inventory_Maze.Size = new System.Drawing.Size(50, 50);
            this.Inventory_Maze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_Maze.TabIndex = 14;
            this.Inventory_Maze.TabStop = false;
            // 
            // PointPannel
            // 
            this.PointPannel.AutoScroll = true;
            this.PointPannel.ColumnCount = 2;
            this.PointPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PointPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PointPannel.Controls.Add(this.GhoulHitPoint, 1, 3);
            this.PointPannel.Controls.Add(this.Ghoul, 0, 3);
            this.PointPannel.Controls.Add(this.GhostHitPoint, 1, 2);
            this.PointPannel.Controls.Add(this.Ghost, 0, 2);
            this.PointPannel.Controls.Add(this.BatHitPoint, 1, 1);
            this.PointPannel.Controls.Add(this.Bat, 0, 1);
            this.PointPannel.Controls.Add(this.Player, 0, 0);
            this.PointPannel.Controls.Add(this.PlayerHitPoint, 1, 0);
            this.PointPannel.Location = new System.Drawing.Point(605, 274);
            this.PointPannel.Name = "PointPannel";
            this.PointPannel.RowCount = 4;
            this.PointPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PointPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PointPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PointPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PointPannel.Size = new System.Drawing.Size(163, 122);
            this.PointPannel.TabIndex = 15;
            this.PointPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.PointPannel_Paint);
            // 
            // PlayerHitPoint
            // 
            this.PlayerHitPoint.AutoSize = true;
            this.PlayerHitPoint.Location = new System.Drawing.Point(51, 0);
            this.PlayerHitPoint.Name = "PlayerHitPoint";
            this.PlayerHitPoint.Size = new System.Drawing.Size(83, 12);
            this.PlayerHitPoint.TabIndex = 16;
            this.PlayerHitPoint.Text = "PlayerHitPoint";
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(3, 0);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(41, 12);
            this.Player.TabIndex = 17;
            this.Player.Text = "Player";
            // 
            // Bat
            // 
            this.Bat.AutoSize = true;
            this.Bat.Location = new System.Drawing.Point(3, 30);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(23, 12);
            this.Bat.TabIndex = 18;
            this.Bat.Text = "Bat";
            // 
            // BatHitPoint
            // 
            this.BatHitPoint.AutoSize = true;
            this.BatHitPoint.Location = new System.Drawing.Point(51, 30);
            this.BatHitPoint.Name = "BatHitPoint";
            this.BatHitPoint.Size = new System.Drawing.Size(65, 12);
            this.BatHitPoint.TabIndex = 19;
            this.BatHitPoint.Text = "BatHitPoint";
            this.BatHitPoint.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ghost
            // 
            this.Ghost.AutoSize = true;
            this.Ghost.Location = new System.Drawing.Point(3, 60);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(38, 12);
            this.Ghost.TabIndex = 20;
            this.Ghost.Text = "Ghost";
            // 
            // GhostHitPoint
            // 
            this.GhostHitPoint.AutoSize = true;
            this.GhostHitPoint.Location = new System.Drawing.Point(51, 60);
            this.GhostHitPoint.Name = "GhostHitPoint";
            this.GhostHitPoint.Size = new System.Drawing.Size(80, 12);
            this.GhostHitPoint.TabIndex = 21;
            this.GhostHitPoint.Text = "GhostHitPoint";
            // 
            // Ghoul
            // 
            this.Ghoul.AutoSize = true;
            this.Ghoul.Location = new System.Drawing.Point(3, 90);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(38, 12);
            this.Ghoul.TabIndex = 22;
            this.Ghoul.Text = "Ghoul";
            // 
            // GhoulHitPoint
            // 
            this.GhoulHitPoint.AutoSize = true;
            this.GhoulHitPoint.Location = new System.Drawing.Point(51, 90);
            this.GhoulHitPoint.Name = "GhoulHitPoint";
            this.GhoulHitPoint.Size = new System.Drawing.Size(80, 12);
            this.GhoulHitPoint.TabIndex = 23;
            this.GhoulHitPoint.Text = "GhoulHitPoint";
            // 
            // MoveGroupBox
            // 
            this.MoveGroupBox.Controls.Add(this.MoveDown);
            this.MoveGroupBox.Controls.Add(this.MoveRight);
            this.MoveGroupBox.Controls.Add(this.MoveLeft);
            this.MoveGroupBox.Controls.Add(this.MoveUp);
            this.MoveGroupBox.Controls.Add(this.groupBox2);
            this.MoveGroupBox.Location = new System.Drawing.Point(605, 1);
            this.MoveGroupBox.Name = "MoveGroupBox";
            this.MoveGroupBox.Size = new System.Drawing.Size(163, 127);
            this.MoveGroupBox.TabIndex = 16;
            this.MoveGroupBox.TabStop = false;
            this.MoveGroupBox.Text = "Move";
            this.MoveGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 127);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(43, 28);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(75, 23);
            this.MoveUp.TabIndex = 19;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(5, 56);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft.TabIndex = 20;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(81, 56);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(75, 23);
            this.MoveRight.TabIndex = 21;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(43, 83);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(75, 23);
            this.MoveDown.TabIndex = 22;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 127);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // AttackGroupBox
            // 
            this.AttackGroupBox.Controls.Add(this.Attack_Down);
            this.AttackGroupBox.Controls.Add(this.Attack_Right);
            this.AttackGroupBox.Controls.Add(this.Attack_Left);
            this.AttackGroupBox.Controls.Add(this.Attack_Up);
            this.AttackGroupBox.Controls.Add(this.groupBox4);
            this.AttackGroupBox.Location = new System.Drawing.Point(605, 134);
            this.AttackGroupBox.Name = "AttackGroupBox";
            this.AttackGroupBox.Size = new System.Drawing.Size(163, 127);
            this.AttackGroupBox.TabIndex = 18;
            this.AttackGroupBox.TabStop = false;
            this.AttackGroupBox.Text = "Attack";
            // 
            // Attack_Up
            // 
            this.Attack_Up.Location = new System.Drawing.Point(43, 28);
            this.Attack_Up.Name = "Attack_Up";
            this.Attack_Up.Size = new System.Drawing.Size(75, 23);
            this.Attack_Up.TabIndex = 23;
            this.Attack_Up.Text = "Up";
            this.Attack_Up.UseVisualStyleBackColor = true;
            this.Attack_Up.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Attack_Left
            // 
            this.Attack_Left.Location = new System.Drawing.Point(5, 57);
            this.Attack_Left.Name = "Attack_Left";
            this.Attack_Left.Size = new System.Drawing.Size(75, 23);
            this.Attack_Left.TabIndex = 23;
            this.Attack_Left.Text = "Left";
            this.Attack_Left.UseVisualStyleBackColor = true;
            // 
            // Attack_Right
            // 
            this.Attack_Right.Location = new System.Drawing.Point(81, 57);
            this.Attack_Right.Name = "Attack_Right";
            this.Attack_Right.Size = new System.Drawing.Size(75, 23);
            this.Attack_Right.TabIndex = 24;
            this.Attack_Right.Text = "Right";
            this.Attack_Right.UseVisualStyleBackColor = true;
            // 
            // Attack_Down
            // 
            this.Attack_Down.Location = new System.Drawing.Point(43, 86);
            this.Attack_Down.Name = "Attack_Down";
            this.Attack_Down.Size = new System.Drawing.Size(75, 23);
            this.Attack_Down.TabIndex = 25;
            this.Attack_Down.Text = "Down";
            this.Attack_Down.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Second.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(773, 401);
            this.Controls.Add(this.AttackGroupBox);
            this.Controls.Add(this.MoveGroupBox);
            this.Controls.Add(this.PointPannel);
            this.Controls.Add(this.Inventory_Maze);
            this.Controls.Add(this.Inventory_RedPotion);
            this.Controls.Add(this.Inventory_Bow);
            this.Controls.Add(this.Inventory_BluePostion);
            this.Controls.Add(this.Inventory_Sword);
            this.Controls.Add(this.MapIcon_Bow);
            this.Controls.Add(this.MapIcon_Mase);
            this.Controls.Add(this.MapIcon_RedPotion);
            this.Controls.Add(this.MapIcon_BluePotion);
            this.Controls.Add(this.MapIcon_Ghost);
            this.Controls.Add(this.MapIcon_Ghos);
            this.Controls.Add(this.MapIcon_Bat);
            this.Controls.Add(this.MapIcon_Sword);
            this.Controls.Add(this.MapIcon_Player);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Ghos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Mase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapIcon_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_BluePostion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Maze)).EndInit();
            this.PointPannel.ResumeLayout(false);
            this.PointPannel.PerformLayout();
            this.MoveGroupBox.ResumeLayout(false);
            this.AttackGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MapIcon_Player;
        private System.Windows.Forms.PictureBox MapIcon_Sword;
        private System.Windows.Forms.PictureBox MapIcon_Bat;
        private System.Windows.Forms.PictureBox MapIcon_Ghos;
        private System.Windows.Forms.PictureBox MapIcon_Ghost;
        private System.Windows.Forms.PictureBox MapIcon_BluePotion;
        private System.Windows.Forms.PictureBox MapIcon_RedPotion;
        private System.Windows.Forms.PictureBox MapIcon_Mase;
        private System.Windows.Forms.PictureBox MapIcon_Bow;
        private System.Windows.Forms.PictureBox Inventory_Sword;
        private System.Windows.Forms.PictureBox Inventory_BluePostion;
        private System.Windows.Forms.PictureBox Inventory_Bow;
        private System.Windows.Forms.PictureBox Inventory_RedPotion;
        private System.Windows.Forms.PictureBox Inventory_Maze;
        private System.Windows.Forms.TableLayoutPanel PointPannel;
        private System.Windows.Forms.Label BatHitPoint;
        private System.Windows.Forms.Label Bat;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label PlayerHitPoint;
        private System.Windows.Forms.Label GhoulHitPoint;
        private System.Windows.Forms.Label Ghoul;
        private System.Windows.Forms.Label GhostHitPoint;
        private System.Windows.Forms.Label Ghost;
        private System.Windows.Forms.GroupBox MoveGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox AttackGroupBox;
        private System.Windows.Forms.Button Attack_Down;
        private System.Windows.Forms.Button Attack_Right;
        private System.Windows.Forms.Button Attack_Left;
        private System.Windows.Forms.Button Attack_Up;
    }
}

