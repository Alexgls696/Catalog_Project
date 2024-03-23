﻿namespace Game_Catalog_Project
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GamesButton = new Button();
            FilmsButton = new Button();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            backButton = new Button();
            characterInfoPanel = new myLayoutPanel();
            SuspendLayout();
            // 
            // GamesButton
            // 
            GamesButton.BackColor = Color.Transparent;
            GamesButton.BackgroundImage = Catalog_Project.Properties.Resources.games_icon;
            GamesButton.BackgroundImageLayout = ImageLayout.Stretch;
            GamesButton.FlatAppearance.BorderSize = 0;
            GamesButton.FlatStyle = FlatStyle.Flat;
            GamesButton.Location = new Point(220, 103);
            GamesButton.Name = "GamesButton";
            GamesButton.Size = new Size(275, 275);
            GamesButton.TabIndex = 0;
            GamesButton.UseVisualStyleBackColor = false;
            GamesButton.Click += GamesButton_Click;
            // 
            // FilmsButton
            // 
            FilmsButton.BackColor = Color.Transparent;
            FilmsButton.BackgroundImage = Catalog_Project.Properties.Resources.films_icon;
            FilmsButton.BackgroundImageLayout = ImageLayout.Stretch;
            FilmsButton.FlatAppearance.BorderSize = 0;
            FilmsButton.FlatStyle = FlatStyle.Flat;
            FilmsButton.Location = new Point(706, 374);
            FilmsButton.Name = "FilmsButton";
            FilmsButton.Size = new Size(275, 275);
            FilmsButton.TabIndex = 1;
            FilmsButton.UseVisualStyleBackColor = false;
            FilmsButton.Click += FilmsButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = SystemColors.InfoText;
            SearchTextBox.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTextBox.ForeColor = SystemColors.InactiveBorder;
            SearchTextBox.Location = new Point(88, 12);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.RightToLeft = RightToLeft.No;
            SearchTextBox.Size = new Size(1099, 53);
            SearchTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.BackgroundImage = Catalog_Project.Properties.Resources.search;
            SearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SearchButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = Color.Transparent;
            SearchButton.Location = new Point(1193, 11);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(59, 53);
            SearchButton.TabIndex = 3;
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.BackgroundImage = Catalog_Project.Properties.Resources.back;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(11, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(55, 53);
            backButton.TabIndex = 4;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // characterInfoPanel
            // 
            characterInfoPanel.Location = new Point(0, 0);
            characterInfoPanel.Name = "characterInfoPanel";
            characterInfoPanel.Size = new Size(200, 100);
            characterInfoPanel.TabIndex = 0;
            // 
            // window
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Catalog_Project.Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(backButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(FilmsButton);
            Controls.Add(GamesButton);
            DoubleBuffered = true;
            MinimumSize = new Size(1280, 720);
            Name = "window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button GamesButton;
        private Button FilmsButton;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button backButton;
    }
}