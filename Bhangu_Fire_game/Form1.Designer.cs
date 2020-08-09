namespace Bhangu_Fire_game
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
            this.label1 = new System.Windows.Forms.Label();
            this.bhg_srt = new System.Windows.Forms.Button();
            this.bhg_load = new System.Windows.Forms.Button();
            this.bhg_spin = new System.Windows.Forms.Button();
            this.bhg_shoot = new System.Windows.Forms.Button();
            this.bhg_shoot_away = new System.Windows.Forms.Button();
            this.bhg_reload = new System.Windows.Forms.Button();
            this.bhg_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bhg_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Carefully!";
            // 
            // bhg_srt
            // 
            this.bhg_srt.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhg_srt.ForeColor = System.Drawing.Color.Red;
            this.bhg_srt.Location = new System.Drawing.Point(12, 78);
            this.bhg_srt.Name = "bhg_srt";
            this.bhg_srt.Size = new System.Drawing.Size(105, 44);
            this.bhg_srt.TabIndex = 1;
            this.bhg_srt.Text = "Start ";
            this.bhg_srt.UseVisualStyleBackColor = true;
            this.bhg_srt.Click += new System.EventHandler(this.bhg_srt_Click);
            // 
            // bhg_load
            // 
            this.bhg_load.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhg_load.ForeColor = System.Drawing.Color.Red;
            this.bhg_load.Location = new System.Drawing.Point(123, 78);
            this.bhg_load.Name = "bhg_load";
            this.bhg_load.Size = new System.Drawing.Size(105, 44);
            this.bhg_load.TabIndex = 2;
            this.bhg_load.Text = "Load";
            this.bhg_load.UseVisualStyleBackColor = true;
            this.bhg_load.Click += new System.EventHandler(this.bhg_load_Click);
            // 
            // bhg_spin
            // 
            this.bhg_spin.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhg_spin.ForeColor = System.Drawing.Color.Red;
            this.bhg_spin.Location = new System.Drawing.Point(234, 78);
            this.bhg_spin.Name = "bhg_spin";
            this.bhg_spin.Size = new System.Drawing.Size(105, 44);
            this.bhg_spin.TabIndex = 3;
            this.bhg_spin.Text = "Spin";
            this.bhg_spin.UseVisualStyleBackColor = true;
            this.bhg_spin.Click += new System.EventHandler(this.bhg_spin_Click);
            // 
            // bhg_shoot
            // 
            this.bhg_shoot.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhg_shoot.ForeColor = System.Drawing.Color.Red;
            this.bhg_shoot.Location = new System.Drawing.Point(345, 78);
            this.bhg_shoot.Name = "bhg_shoot";
            this.bhg_shoot.Size = new System.Drawing.Size(105, 44);
            this.bhg_shoot.TabIndex = 4;
            this.bhg_shoot.Text = "shoot ";
            this.bhg_shoot.UseVisualStyleBackColor = true;
            this.bhg_shoot.Click += new System.EventHandler(this.bhg_shoot_Click);
            // 
            // bhg_shoot_away
            // 
            this.bhg_shoot_away.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhg_shoot_away.ForeColor = System.Drawing.Color.Red;
            this.bhg_shoot_away.Location = new System.Drawing.Point(456, 78);
            this.bhg_shoot_away.Name = "bhg_shoot_away";
            this.bhg_shoot_away.Size = new System.Drawing.Size(205, 44);
            this.bhg_shoot_away.TabIndex = 5;
            this.bhg_shoot_away.Text = "Shoot Away";
            this.bhg_shoot_away.UseVisualStyleBackColor = true;
            this.bhg_shoot_away.Click += new System.EventHandler(this.bhg_shoot_away_Click);
            // 
            // bhg_reload
            // 
            this.bhg_reload.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhg_reload.ForeColor = System.Drawing.Color.Red;
            this.bhg_reload.Location = new System.Drawing.Point(667, 78);
            this.bhg_reload.Name = "bhg_reload";
            this.bhg_reload.Size = new System.Drawing.Size(134, 44);
            this.bhg_reload.TabIndex = 6;
            this.bhg_reload.Text = "Reload";
            this.bhg_reload.UseVisualStyleBackColor = true;
            this.bhg_reload.Click += new System.EventHandler(this.bhg_reload_Click);
            // 
            // bhg_pb
            // 
            this.bhg_pb.Location = new System.Drawing.Point(17, 149);
            this.bhg_pb.Name = "bhg_pb";
            this.bhg_pb.Size = new System.Drawing.Size(784, 325);
            this.bhg_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bhg_pb.TabIndex = 7;
            this.bhg_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(866, 486);
            this.Controls.Add(this.bhg_pb);
            this.Controls.Add(this.bhg_reload);
            this.Controls.Add(this.bhg_shoot_away);
            this.Controls.Add(this.bhg_shoot);
            this.Controls.Add(this.bhg_spin);
            this.Controls.Add(this.bhg_load);
            this.Controls.Add(this.bhg_srt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bhg_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bhg_srt;
        private System.Windows.Forms.Button bhg_load;
        private System.Windows.Forms.Button bhg_spin;
        private System.Windows.Forms.Button bhg_shoot;
        private System.Windows.Forms.Button bhg_shoot_away;
        private System.Windows.Forms.Button bhg_reload;
        private System.Windows.Forms.PictureBox bhg_pb;
    }
}

