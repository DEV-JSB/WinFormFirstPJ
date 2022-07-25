using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
enum Direction { Up, Down, Left, Right };

namespace Second
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public void UpdateIcon()
        {
            MapIcon_Player.Update();
            MapIcon_Bat.Update();
        }
        public void UpdateCharacters()
        {
            MapIcon_Player.Location = game.PlayerLocation;
            MapIcon_Player.Visible = true;
            PlayerHitPoint.Text = game.PlayerHitPoints.ToString();
            UpdateIcon();
            

            bool showBat = false;
            bool showChost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            
            foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    MapIcon_Bat.Visible = true;
                    MapIcon_Bat.Location = enemy.Location;
                    BatHitPoint.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints > 0)
                    {
                        showBat = true;
                        ++enemiesShown;
                    }
                }
            }


            MapIcon_BluePotion.Visible = false;
            MapIcon_Bow.Visible = false;
            MapIcon_RedPotion.Visible = false;
            MapIcon_Mase.Visible = false;
            MapIcon_Sword.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = MapIcon_Sword;
                    break;
            }


            if (game.CheckPlayerInventory("Sword"))
                Inventory_Sword.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                Inventory_Sword.Visible = true;
            if (game.CheckPlayerInventory("Mase"))
                Inventory_Sword.Visible = true;
            if (game.CheckPlayerInventory("BluePotion"))
                Inventory_Sword.Visible = true;
            if (game.CheckPlayerInventory("RedPotion"))
                Inventory_Sword.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            if(game.PlayerHitPoints <= 0 )
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if(enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }



        }


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
            MapIcon_Player.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PointPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PlayerHitPoint_Click(object sender, EventArgs e)
        {

        }

        private void MapIcon_Bat_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_RedPotion_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Maze_Click(object sender, EventArgs e)
        {

        }

        private void MapIcon_Ghost_Click(object sender, EventArgs e)
        {

        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();

        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();

        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }
    }
}
