﻿namespace TopDownShooter
{
    partial class Shooter
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.pbHealthBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmmo.ForeColor = System.Drawing.Color.White;
            this.lblAmmo.Location = new System.Drawing.Point(12, 9);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(103, 25);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "Ammo: 0";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKills.ForeColor = System.Drawing.Color.White;
            this.lblKills.Location = new System.Drawing.Point(336, 9);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(84, 25);
            this.lblKills.TabIndex = 1;
            this.lblKills.Text = "Kills: 0";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(633, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(87, 25);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // pbHealthBar
            // 
            this.pbHealthBar.Location = new System.Drawing.Point(726, 9);
            this.pbHealthBar.Name = "pbHealthBar";
            this.pbHealthBar.Size = new System.Drawing.Size(186, 22);
            this.pbHealthBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TopDownShooter.Properties.Resources.zdown;
            this.pictureBox1.Location = new System.Drawing.Point(117, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "zombie";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TopDownShooter.Properties.Resources.zdown;
            this.pictureBox2.Location = new System.Drawing.Point(649, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "zombie";
            // 
            // Player
            // 
            this.Player.Image = global::TopDownShooter.Properties.Resources.up;
            this.Player.Location = new System.Drawing.Point(319, 301);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(71, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 6;
            this.Player.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TopDownShooter.Properties.Resources.zup;
            this.pictureBox4.Location = new System.Drawing.Point(341, 450);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "zombie";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 17;
            this.tmrMain.Tick += new System.EventHandler(this.Engine);
            // 
            // Shooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(914, 662);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbHealthBar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblAmmo);
            this.Name = "Shooter";
            this.Text = "Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar pbHealthBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer tmrMain;
    }
}

