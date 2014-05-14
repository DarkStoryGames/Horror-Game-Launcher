namespace Horror_Game_Launcher
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
            this.play = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gameVersion = new System.Windows.Forms.Label();
            this.dlbar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(12, 12);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(178, 42);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 60);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(178, 42);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 108);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(178, 42);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Version:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameVersion
            // 
            this.gameVersion.AutoSize = true;
            this.gameVersion.Location = new System.Drawing.Point(174, 174);
            this.gameVersion.Name = "gameVersion";
            this.gameVersion.Size = new System.Drawing.Size(16, 13);
            this.gameVersion.TabIndex = 4;
            this.gameVersion.Text = "-1";
            this.gameVersion.Click += new System.EventHandler(this.gameVersion_Click);
            // 
            // dlbar
            // 
            this.dlbar.Location = new System.Drawing.Point(12, 190);
            this.dlbar.Name = "dlbar";
            this.dlbar.Size = new System.Drawing.Size(178, 23);
            this.dlbar.TabIndex = 5;
            this.dlbar.Click += new System.EventHandler(this.dlbar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 223);
            this.Controls.Add(this.dlbar);
            this.Controls.Add(this.gameVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.play);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Horror Game Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameVersion;
        private System.Windows.Forms.ProgressBar dlbar;
    }
}

