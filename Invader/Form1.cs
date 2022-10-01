using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*public enum Keys
{
    left,
    right,
    up,
    down,
    spcae
}*/

namespace Invader
{
    public partial class Form1 : Form
    {
        List<Keys> keysPressed = new List<Keys>();
        private bool gameOver;
        private Game game;
        Random random = new Random();

        public Rectangle FormSize { get { return this.ClientRectangle; } }
        
        public Form1()
        {
            InitializeComponent();
            game = new Game(random, FormSize);
            gameOver = false;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();
            if(gameOver)
                if(e.KeyCode == Keys.S)
                {
                    // 코드 쳐야함
                    return;
                }
            if (e.KeyCode == Keys.Space)
                game.FireShot();
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);
        }


        private void From1_KeyUp(object sender,KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();
            foreach(Keys key in keysPressed)
            {
                if(key == Keys.Left)
                {
                    game.MovePlayer();
                }
            }
        }

    }
}
