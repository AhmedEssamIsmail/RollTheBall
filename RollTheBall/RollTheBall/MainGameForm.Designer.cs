namespace RollTheBall
{
    partial class MainGameForm
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
        ///
        private void InitializeComponent()
        {
            this.Playground = new System.Windows.Forms.Panel();
            this.Undo = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Moves_txt_label = new System.Windows.Forms.Label();
            this.Target_txt_label = new System.Windows.Forms.Label();
            this.Moves_counter_label = new System.Windows.Forms.Label();
            this.Target_counter_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playground
            // 
            this.Playground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(51)))), ((int)(((byte)(23)))));
            this.Playground.Cursor = System.Windows.Forms.Cursors.No;
            this.Playground.Location = new System.Drawing.Point(0, 0);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(300, 300);
            this.Playground.TabIndex = 0;
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Undo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Undo.Location = new System.Drawing.Point(201, 304);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(70, 25);
            this.Undo.TabIndex = 1;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(201, 331);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(70, 25);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Moves_txt_label
            // 
            this.Moves_txt_label.AutoSize = true;
            this.Moves_txt_label.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moves_txt_label.ForeColor = System.Drawing.Color.White;
            this.Moves_txt_label.Location = new System.Drawing.Point(12, 304);
            this.Moves_txt_label.Name = "Moves_txt_label";
            this.Moves_txt_label.Size = new System.Drawing.Size(66, 18);
            this.Moves_txt_label.TabIndex = 3;
            this.Moves_txt_label.Text = "Moves : ";
            // 
            // Target_txt_label
            // 
            this.Target_txt_label.AutoSize = true;
            this.Target_txt_label.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target_txt_label.ForeColor = System.Drawing.Color.White;
            this.Target_txt_label.Location = new System.Drawing.Point(12, 332);
            this.Target_txt_label.Name = "Target_txt_label";
            this.Target_txt_label.Size = new System.Drawing.Size(67, 18);
            this.Target_txt_label.TabIndex = 4;
            this.Target_txt_label.Text = "Target : ";
            // 
            // Moves_counter_label
            // 
            this.Moves_counter_label.AutoSize = true;
            this.Moves_counter_label.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moves_counter_label.ForeColor = System.Drawing.Color.Black;
            this.Moves_counter_label.Location = new System.Drawing.Point(92, 305);
            this.Moves_counter_label.Name = "Moves_counter_label";
            this.Moves_counter_label.Size = new System.Drawing.Size(17, 18);
            this.Moves_counter_label.TabIndex = 5;
            this.Moves_counter_label.Text = "0";
            this.Moves_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Target_counter_label
            // 
            this.Target_counter_label.AutoSize = true;
            this.Target_counter_label.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target_counter_label.ForeColor = System.Drawing.Color.Black;
            this.Target_counter_label.Location = new System.Drawing.Point(92, 332);
            this.Target_counter_label.Name = "Target_counter_label";
            this.Target_counter_label.Size = new System.Drawing.Size(17, 18);
            this.Target_counter_label.TabIndex = 6;
            this.Target_counter_label.Text = "0";
            this.Target_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(300, 359);
            this.Controls.Add(this.Target_counter_label);
            this.Controls.Add(this.Moves_counter_label);
            this.Controls.Add(this.Target_txt_label);
            this.Controls.Add(this.Moves_txt_label);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Playground);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainGameForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll The Ball";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGameForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Moves_txt_label;
        private System.Windows.Forms.Label Target_txt_label;
        private System.Windows.Forms.Label Moves_counter_label;
        private System.Windows.Forms.Label Target_counter_label;
    }
}

