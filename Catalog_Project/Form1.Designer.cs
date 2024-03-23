using System.Windows.Forms;

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
            characterInfoPanel1 = new myPanel();
            panel1 = new myLayoutPanel();
            text = new Label();
            ist = new Label();
            link = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            characterInfoPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GamesButton
            // 
            GamesButton.BackColor = Color.Transparent;
            GamesButton.BackgroundImage = Catalog_Project.Properties.Resources.games_icon;
            GamesButton.BackgroundImageLayout = ImageLayout.Stretch;
            GamesButton.FlatAppearance.BorderSize = 0;
            GamesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GamesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            FilmsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            FilmsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            backButton.Visible = false;
            backButton.Click += BackButton_Click;
            // 
            // characterInfoPanel1
            // 
            characterInfoPanel1.AutoScroll = true;
            characterInfoPanel1.BackColor = Color.Transparent;
            characterInfoPanel1.Controls.Add(panel1);
            characterInfoPanel1.Controls.Add(button1);
            characterInfoPanel1.Controls.Add(label1);
            characterInfoPanel1.Controls.Add(pictureBox2);
            characterInfoPanel1.Controls.Add(pictureBox1);
            characterInfoPanel1.Location = new Point(11, 71);
            characterInfoPanel1.MaximumSize = new Size(1260, 720);
            characterInfoPanel1.Name = "characterInfoPanel1";
            characterInfoPanel1.Size = new Size(1260, 635);
            characterInfoPanel1.TabIndex = 0;
            characterInfoPanel1.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(text);
            panel1.Controls.Add(ist);
            panel1.Controls.Add(link);
            panel1.Location = new Point(88, 556);
            panel1.MaximumSize = new Size(1200, 2000);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 99);
            panel1.TabIndex = 4;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            text.ForeColor = SystemColors.Control;
            text.Location = new Point(3, 0);
            text.Name = "text";
            text.Size = new Size(79, 37);
            text.TabIndex = 0;
            text.Text = "label2";
            // 
            // ist
            // 
            ist.AutoSize = true;
            ist.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ist.ForeColor = Color.White;
            ist.Location = new Point(485, 0);
            ist.Margin = new Padding(400, 0, 3, 0);
            ist.Name = "ist";
            ist.Size = new Size(123, 33);
            ist.TabIndex = 5;
            ist.Text = "Источник:";
            // 
            // link
            // 
            link.AutoSize = true;
            link.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            link.ForeColor = Color.Gold;
            link.Location = new Point(614, 0);
            link.Name = "link";
            link.Size = new Size(96, 37);
            link.TabIndex = 6;
            link.Text = "Ссылка";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(88, 476);
            button1.Name = "button1";
            button1.Size = new Size(295, 62);
            button1.TabIndex = 3;
            button1.Text = "Фраза";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(160, 427);
            label1.Name = "label1";
            label1.Size = new Size(83, 47);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(474, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(714, 496);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(88, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 382);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // window
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Catalog_Project.Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 738);
            Controls.Add(characterInfoPanel1);
            Controls.Add(backButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(FilmsButton);
            Controls.Add(GamesButton);
            DoubleBuffered = true;
            MinimumSize = new Size(1280, 720);
            Name = "window";
            characterInfoPanel1.ResumeLayout(false);
            characterInfoPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button GamesButton;
        private Button FilmsButton;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button backButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private myLayoutPanel panel1;
        private Label text;
        private myPanel characterInfoPanel1;
        private Label link;
        private Label ist;
    }
}