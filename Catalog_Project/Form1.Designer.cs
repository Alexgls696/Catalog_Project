namespace Game_Catalog_Project
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
            GamesButton.Location = new Point(245, 101);
            GamesButton.Margin = new Padding(3, 2, 3, 2);
            GamesButton.Name = "GamesButton";
            GamesButton.Size = new Size(300, 250);
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
            FilmsButton.Location = new Point(720, 377);
            FilmsButton.Margin = new Padding(3, 2, 3, 2);
            FilmsButton.Name = "FilmsButton";
            FilmsButton.Size = new Size(300, 250);
            FilmsButton.TabIndex = 1;
            FilmsButton.UseVisualStyleBackColor = false;
            FilmsButton.Click += FilmsButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = SystemColors.InfoText;
            SearchTextBox.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold);
            SearchTextBox.ForeColor = SystemColors.InactiveBorder;
            SearchTextBox.Location = new Point(140, 9);
            SearchTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.RightToLeft = RightToLeft.No;
            SearchTextBox.Size = new Size(840, 41);
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
            SearchButton.Location = new Point(985, 9);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(52, 40);
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
            backButton.Location = new Point(10, 9);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(48, 40);
            backButton.TabIndex = 4;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // characterInfoPanel
            // 
            characterInfoPanel.AutoScroll = true;
            characterInfoPanel.BackColor = Color.Transparent;
            characterInfoPanel.Location = new Point(0, 70);
            characterInfoPanel.Name = "characterInfoPanel";
            characterInfoPanel.Size = new Size(1280, 600);
            characterInfoPanel.TabIndex = 0;
            characterInfoPanel.Visible = false;
            // 
            // window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Catalog_Project.Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(backButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(FilmsButton);
            Controls.Add(GamesButton);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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