namespace hands_viewer.cs
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.Stop = new System.Windows.Forms.Button();
            this.ChallengeMode = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.practiceMode = new System.Windows.Forms.Button();
            this.onlineMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(1349, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(46, 35);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Exit";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ChallengeMode
            // 
            this.ChallengeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeMode.ForeColor = System.Drawing.Color.Maroon;
            this.ChallengeMode.Location = new System.Drawing.Point(1168, 400);
            this.ChallengeMode.Name = "ChallengeMode";
            this.ChallengeMode.Size = new System.Drawing.Size(200, 50);
            this.ChallengeMode.TabIndex = 4;
            this.ChallengeMode.Text = "Challenge Mode";
            this.ChallengeMode.UseVisualStyleBackColor = true;
            this.ChallengeMode.Click += new System.EventHandler(this.ChallengeMode_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Font = new System.Drawing.Font("Harlow Solid Italic", 90F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.Maroon;
            this.welcomeText.Location = new System.Drawing.Point(695, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(648, 259);
            this.welcomeText.TabIndex = 5;
            this.welcomeText.Text = "Sign-Along";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // practiceMode
            // 
            this.practiceMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practiceMode.ForeColor = System.Drawing.Color.Maroon;
            this.practiceMode.Location = new System.Drawing.Point(1168, 479);
            this.practiceMode.Name = "practiceMode";
            this.practiceMode.Size = new System.Drawing.Size(200, 50);
            this.practiceMode.TabIndex = 6;
            this.practiceMode.Text = "Practice Mode";
            this.practiceMode.UseVisualStyleBackColor = true;
            // 
            // onlineMode
            // 
            this.onlineMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineMode.ForeColor = System.Drawing.Color.Maroon;
            this.onlineMode.Location = new System.Drawing.Point(1168, 552);
            this.onlineMode.Name = "onlineMode";
            this.onlineMode.Size = new System.Drawing.Size(200, 50);
            this.onlineMode.TabIndex = 7;
            this.onlineMode.Text = "Online Mode";
            this.onlineMode.UseVisualStyleBackColor = true;
            // 
            // WelcomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1407, 860);
            this.Controls.Add(this.onlineMode);
            this.Controls.Add(this.practiceMode);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.ChallengeMode);
            this.Controls.Add(this.Stop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button ChallengeMode;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button practiceMode;
        private System.Windows.Forms.Button onlineMode;
    }
}