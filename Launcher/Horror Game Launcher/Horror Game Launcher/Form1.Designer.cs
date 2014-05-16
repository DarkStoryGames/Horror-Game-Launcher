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
            this.updateBrowser = new System.Windows.Forms.WebBrowser();
            this.GameControlTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fullscreenCheck = new System.Windows.Forms.CheckBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GameControlTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(12, 535);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(178, 42);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(196, 535);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(178, 42);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(380, 535);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Version:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameVersion
            // 
            this.gameVersion.AutoSize = true;
            this.gameVersion.Location = new System.Drawing.Point(109, 9);
            this.gameVersion.Name = "gameVersion";
            this.gameVersion.Size = new System.Drawing.Size(16, 13);
            this.gameVersion.TabIndex = 4;
            this.gameVersion.Text = "-1";
            this.gameVersion.Click += new System.EventHandler(this.gameVersion_Click);
            // 
            // dlbar
            // 
            this.dlbar.Location = new System.Drawing.Point(564, 545);
            this.dlbar.Name = "dlbar";
            this.dlbar.Size = new System.Drawing.Size(555, 23);
            this.dlbar.TabIndex = 5;
            this.dlbar.Click += new System.EventHandler(this.dlbar_Click);
            // 
            // updateBrowser
            // 
            this.updateBrowser.AllowWebBrowserDrop = false;
            this.updateBrowser.IsWebBrowserContextMenuEnabled = false;
            this.updateBrowser.Location = new System.Drawing.Point(-4, -2);
            this.updateBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.updateBrowser.Name = "updateBrowser";
            this.updateBrowser.ScrollBarsEnabled = false;
            this.updateBrowser.Size = new System.Drawing.Size(1107, 496);
            this.updateBrowser.TabIndex = 6;
            this.updateBrowser.Url = new System.Uri("http://horrorgame.net16.net/updates.php", System.UriKind.Absolute);
            this.updateBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // GameControlTabs
            // 
            this.GameControlTabs.Controls.Add(this.tabPage1);
            this.GameControlTabs.Controls.Add(this.tabPage2);
            this.GameControlTabs.Location = new System.Drawing.Point(12, 23);
            this.GameControlTabs.Name = "GameControlTabs";
            this.GameControlTabs.SelectedIndex = 0;
            this.GameControlTabs.Size = new System.Drawing.Size(1107, 506);
            this.GameControlTabs.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1099, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Latest Updates";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fullscreenCheck);
            this.tabPage2.Controls.Add(this.heightBox);
            this.tabPage2.Controls.Add(this.widthBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1099, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fullscreenCheck
            // 
            this.fullscreenCheck.AutoSize = true;
            this.fullscreenCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullscreenCheck.Location = new System.Drawing.Point(6, 150);
            this.fullscreenCheck.MaximumSize = new System.Drawing.Size(30, 30);
            this.fullscreenCheck.MinimumSize = new System.Drawing.Size(30, 30);
            this.fullscreenCheck.Name = "fullscreenCheck";
            this.fullscreenCheck.Size = new System.Drawing.Size(30, 30);
            this.fullscreenCheck.TabIndex = 6;
            this.fullscreenCheck.UseVisualStyleBackColor = true;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(6, 91);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(128, 20);
            this.heightBox.TabIndex = 5;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(6, 32);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(128, 20);
            this.widthBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Screen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1087, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Changes!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 589);
            this.Controls.Add(this.GameControlTabs);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horror Game Launcher";
            this.GameControlTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.WebBrowser updateBrowser;
        private System.Windows.Forms.TabControl GameControlTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox fullscreenCheck;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
    }
}

