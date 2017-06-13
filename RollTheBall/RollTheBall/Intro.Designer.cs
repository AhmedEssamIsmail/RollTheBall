namespace RollTheBall
{
    partial class Intro
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
            this.Play = new System.Windows.Forms.Button();
            this.LevelSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Play.Location = new System.Drawing.Point(424, 255);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(128, 52);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Start_Click);
            // 
            // LevelSelector
            // 
            this.LevelSelector.FormattingEnabled = true;
            this.LevelSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.LevelSelector.Location = new System.Drawing.Point(16, 271);
            this.LevelSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LevelSelector.Name = "LevelSelector";
            this.LevelSelector.Size = new System.Drawing.Size(160, 24);
            this.LevelSelector.TabIndex = 1;
            this.LevelSelector.Text = "Select Level";
            // 
            // Intro
            // 
            this.AcceptButton = this.Play;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RollTheBall.Properties.Resources.IntroImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 321);
            this.Controls.Add(this.LevelSelector);
            this.Controls.Add(this.Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Intro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll The Ball";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Intro_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ComboBox LevelSelector;
    }
}