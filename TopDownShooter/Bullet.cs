using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TopDownShooter
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;
        public int speed = 20;

        PictureBox bullet = new PictureBox();
        Timer tm = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();
            form.Controls.Add(bullet);

            tm.Interval = speed;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "left":
                    bullet.Left -= speed;
                    break;
                case "right":
                    bullet.Left += speed;
                    break;
                case "up":
                    bullet.Top -= speed;
                    break;
                case "down":
                    bullet.Top += speed;
                    break;
            }

            if ((bullet.Left < 16) || (bullet.Left > 860) || (bullet.Top < 10) || (bullet.Top > 616))
            {
                tm.Stop();
                tm.Dispose();
                bullet.Dispose();
                tm = null;
                bullet = null;
            }
        }
    }
}
