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
        // this whole project is a terrible pile of spaghetti code
        // make sure to refactor it later
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
            if (playerHealth > 1)
            {
                pbHealthBar.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                Player.Image = Properties.Resources.dead;
                tmrMain.Stop();
                gameOver = true;
            }

            lblAmmo.Text = $"Ammo: {ammo}";
            lblKills.Text = $"Kills: {score}";

            if (playerHealth < 20)
            {
                pbHealthBar.ForeColor = Color.Red;
            }

            if (goLeft && (Player.Left > 0))
            {
                Player.Left -= playerSpeed;
            }

            if (goRight && (Player.Left + Player.Width < 930))
            {
                Player.Left += playerSpeed;
            }

            if (goUp && (Player.Top > 60))
            {
                Player.Top -= playerSpeed;
            }

            if (goDown && (Player.Top + Player.Height < 700))
            {
                Player.Top += playerSpeed;
            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && (string)control.Tag == "ammo")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(Player.Bounds))
                    {
                        Controls.Remove((PictureBox)control);
                        ((PictureBox)control).Dispose();
                        ammo += 5;
                    }
                }

                if (control is PictureBox && (string)control.Tag == "bullet")
                {
                    // this is extra terrible
                    if ((((PictureBox)control).Left < 1) || (((PictureBox)control).Left > 930)
                        || (((PictureBox)control).Top < 10) || (((PictureBox)control).Top > 700))
                    {
                        Controls.Remove((PictureBox)control);
                        ((PictureBox)control).Dispose();
                    }
                }

                if (control is PictureBox && (string)control.Tag == "zombie")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(Player.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (((PictureBox)control).Left > Player.Left)
                    {
                        ((PictureBox)control).Left -= zombieSpeed;
                        ((PictureBox)control).Image = Properties.Resources.zleft;
                    }

                    if (((PictureBox)control).Left < Player.Left)
                    {
                        ((PictureBox)control).Left += zombieSpeed;
                        ((PictureBox)control).Image = Properties.Resources.zright;
                    }

                    if (((PictureBox)control).Top > Player.Top)
                    {
                        ((PictureBox)control).Top -= zombieSpeed;
                        ((PictureBox)control).Image = Properties.Resources.zup;
                    }

                    if (((PictureBox)control).Top < Player.Top)
                    {
                        ((PictureBox)control).Top += zombieSpeed;
                        ((PictureBox)control).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control secondaryControl in Controls)
                {
                    if (((secondaryControl is PictureBox) && ((string)secondaryControl.Tag == "bullet"))
                        && ((control is PictureBox) && ((string)control.Tag == "zombie")))
                    {
                        if (control.Bounds.IntersectsWith(secondaryControl.Bounds))
                        {
                            score++;
                            Controls.Remove(secondaryControl);
                            secondaryControl.Dispose();
                            Controls.Remove(control);
                            control.Dispose();
                            MakeZombies();
                        }
                    }
                }
            }
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
                Player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                Player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                Player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                Player.Image = Properties.Resources.down;
            }
        }

        private void DropAmmo()
        {
            // bad af, definitely needs refactoring
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.Tag = "ammo";
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rng.Next(10, 890);
            ammo.Top = rng.Next(50, 600);
            Controls.Add(ammo);
            ammo.BringToFront();
            Player.BringToFront();
        }

        private void Shoot(string direction)
        {
            // this code is extra retarded
            // simplify it for god's sake
            Bullet shot = new Bullet();
            shot.Direction = direction;
            shot.BulletLeft = Player.Left + (Player.Width / 2);
            shot.BulletTop = Player.Top + (Player.Height / 2);
            shot.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rng.Next(0, 900);
            zombie.Top = rng.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            Controls.Add(zombie);
            Player.BringToFront();
        }
    }
}
