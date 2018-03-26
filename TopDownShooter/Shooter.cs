using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownShooter
{
    public partial class Shooter : Form
    {
        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;
        string facing = "up";
        double playerHealth = 100;
        int playerSpeed = 10;
        int zombieSpeed = 3;
        int ammo = 10;
        int score = 0;
        bool gameOver = false;
        Random rng = new Random();

        public Shooter()
        {
            InitializeComponent();
        }

        private void Engine(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                Shoot(facing);
                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void DropAmmo()
        {

        }

        private void Shoot(string direction)
        {

        }

        private void MakeZombies()
        {

        }
    }
}
