﻿namespace Sudoku
{
    partial class WelcomeWindow
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
            this.easyButton = new System.Windows.Forms.Button();
            this.generatePuzzleButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dificultad";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(21, 54);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(242, 58);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Facil";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // generatePuzzleButton
            // 
            this.generatePuzzleButton.Location = new System.Drawing.Point(21, 360);
            this.generatePuzzleButton.Name = "generatePuzzleButton";
            this.generatePuzzleButton.Size = new System.Drawing.Size(242, 58);
            this.generatePuzzleButton.TabIndex = 2;
            this.generatePuzzleButton.Text = "Generar Sudoku :)";
            this.generatePuzzleButton.UseVisualStyleBackColor = true;
            this.generatePuzzleButton.Click += new System.EventHandler(this.generatePuzzleButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 424);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(242, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(18, 450);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Estado:";
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(21, 118);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(242, 58);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.Text = "Normal";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(21, 182);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(242, 58);
            this.hardButton.TabIndex = 6;
            this.hardButton.Text = "Dificil";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.Location = new System.Drawing.Point(21, 271);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(242, 58);
            this.leaderboardButton.TabIndex = 7;
            this.leaderboardButton.Text = "Tablero";
            this.leaderboardButton.UseVisualStyleBackColor = true;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 471);
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.generatePuzzleButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 510);
            this.MinimumSize = new System.Drawing.Size(300, 510);
            this.Name = "WelcomeWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button generatePuzzleButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button leaderboardButton;
    }
}