
namespace Homework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.Race = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DogUpDown = new System.Windows.Forms.NumericUpDown();
            this.BettingControl = new System.Windows.Forms.NumericUpDown();
            this.Dogpicture1 = new System.Windows.Forms.PictureBox();
            this.Dogpicture2 = new System.Windows.Forms.PictureBox();
            this.Dogpicture3 = new System.Windows.Forms.PictureBox();
            this.Dogpicture4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture4)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Joe";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bob";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 100);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(34, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "AI";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum bet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(373, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joe\'s bet\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(373, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dob\'s bet\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(373, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "AI\'s bet\r\n";
            // 
            // BackGround
            // 
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.InitialImage = ((System.Drawing.Image)(resources.GetObject("BackGround.InitialImage")));
            this.BackGround.Location = new System.Drawing.Point(12, 12);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(600, 200);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackGround.TabIndex = 7;
            this.BackGround.TabStop = false;
            // 
            // Race
            // 
            this.Race.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Race.Location = new System.Drawing.Point(478, 131);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(116, 31);
            this.Race.TabIndex = 8;
            this.Race.Text = "Race!";
            this.Race.UseVisualStyleBackColor = true;
            this.Race.Click += new System.EventHandler(this.asdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BetButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DogUpDown);
            this.groupBox1.Controls.Add(this.BettingControl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Race);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Palor";
            // 
            // BetButton
            // 
            this.BetButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BetButton.Location = new System.Drawing.Point(72, 139);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(53, 24);
            this.BetButton.TabIndex = 14;
            this.BetButton.Text = "Bet";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(24, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "NAME";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(231, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "buks on dog number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(370, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bets";
            // 
            // DogUpDown
            // 
            this.DogUpDown.Location = new System.Drawing.Point(373, 141);
            this.DogUpDown.Name = "DogUpDown";
            this.DogUpDown.Size = new System.Drawing.Size(65, 21);
            this.DogUpDown.TabIndex = 10;
            this.DogUpDown.ValueChanged += new System.EventHandler(this.DogUpDownButton);
            // 
            // BettingControl
            // 
            this.BettingControl.Location = new System.Drawing.Point(140, 141);
            this.BettingControl.Name = "BettingControl";
            this.BettingControl.Size = new System.Drawing.Size(65, 21);
            this.BettingControl.TabIndex = 9;
            this.BettingControl.ValueChanged += new System.EventHandler(this.BettingUpdown);
            // 
            // Dogpicture1
            // 
            this.Dogpicture1.Image = ((System.Drawing.Image)(resources.GetObject("Dogpicture1.Image")));
            this.Dogpicture1.Location = new System.Drawing.Point(21, 21);
            this.Dogpicture1.Name = "Dogpicture1";
            this.Dogpicture1.Size = new System.Drawing.Size(75, 20);
            this.Dogpicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dogpicture1.TabIndex = 9;
            this.Dogpicture1.TabStop = false;
            // 
            // Dogpicture2
            // 
            this.Dogpicture2.Image = ((System.Drawing.Image)(resources.GetObject("Dogpicture2.Image")));
            this.Dogpicture2.Location = new System.Drawing.Point(21, 68);
            this.Dogpicture2.Name = "Dogpicture2";
            this.Dogpicture2.Size = new System.Drawing.Size(75, 20);
            this.Dogpicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dogpicture2.TabIndex = 10;
            this.Dogpicture2.TabStop = false;
            // 
            // Dogpicture3
            // 
            this.Dogpicture3.Image = ((System.Drawing.Image)(resources.GetObject("Dogpicture3.Image")));
            this.Dogpicture3.Location = new System.Drawing.Point(21, 126);
            this.Dogpicture3.Name = "Dogpicture3";
            this.Dogpicture3.Size = new System.Drawing.Size(75, 20);
            this.Dogpicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dogpicture3.TabIndex = 11;
            this.Dogpicture3.TabStop = false;
            // 
            // Dogpicture4
            // 
            this.Dogpicture4.Image = ((System.Drawing.Image)(resources.GetObject("Dogpicture4.Image")));
            this.Dogpicture4.Location = new System.Drawing.Point(21, 177);
            this.Dogpicture4.Name = "Dogpicture4";
            this.Dogpicture4.Size = new System.Drawing.Size(75, 20);
            this.Dogpicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dogpicture4.TabIndex = 12;
            this.Dogpicture4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 410);
            this.Controls.Add(this.Dogpicture4);
            this.Controls.Add(this.Dogpicture3);
            this.Controls.Add(this.Dogpicture2);
            this.Controls.Add(this.Dogpicture1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "A Day at the Race";
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dogpicture4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Dogpicture1;
        private System.Windows.Forms.PictureBox Dogpicture2;
        private System.Windows.Forms.PictureBox Dogpicture3;
        private System.Windows.Forms.PictureBox Dogpicture4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DogUpDown;
        private System.Windows.Forms.NumericUpDown BettingControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BetButton;
    }
}

