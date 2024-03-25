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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
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
            SearchPanel = new myPanel();
            Results = new Label();
            dev_panel = new Panel();
            panel_sign = new Panel();
            pictureBox3 = new PictureBox();
            sign_in = new PictureBox();
            password = new TextBox();
            login = new TextBox();
            pictureBox5 = new PictureBox();
            add_button = new PictureBox();
            label_dev = new Label();
            menu_del_button = new PictureBox();
            menu_pers_button = new PictureBox();
            menu_game_button = new PictureBox();
            panel_del = new Panel();
            comboBox1 = new ComboBox();
            label15 = new Label();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            label13 = new Label();
            panel_pers = new Panel();
            label11 = new Label();
            cb_choise = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            check_music = new PictureBox();
            check_photo = new PictureBox();
            check_screenshot = new PictureBox();
            label_sound = new Label();
            label_photo = new Label();
            label_screenshot = new Label();
            search = new PictureBox();
            textBox_file = new TextBox();
            label5 = new Label();
            textBox_src = new TextBox();
            label4 = new Label();
            textBox_about = new TextBox();
            label3 = new Label();
            textBox_name = new TextBox();
            label2 = new Label();
            panel_gf = new Panel();
            pictureBox_logo = new PictureBox();
            label_logo = new Label();
            search_gf = new PictureBox();
            textBox_logo = new TextBox();
            label8 = new Label();
            cb_gf = new ComboBox();
            label7 = new Label();
            textBox_name_gf = new TextBox();
            label6 = new Label();
            button2 = new Button();
            characterInfoPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SearchPanel.SuspendLayout();
            dev_panel.SuspendLayout();
            panel_sign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sign_in).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)add_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_del_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_pers_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_game_button).BeginInit();
            panel_del.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_pers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)check_music).BeginInit();
            ((System.ComponentModel.ISupportInitialize)check_photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)check_screenshot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search).BeginInit();
            panel_gf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_gf).BeginInit();
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
            SearchButton.Click += SearchButton_Click;
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
            characterInfoPanel1.Location = new Point(1154, 626);
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
            label1.Visible = false;
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
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.Transparent;
            SearchPanel.Controls.Add(Results);
            SearchPanel.Location = new Point(11, 71);
            SearchPanel.MinimumSize = new Size(1260, 720);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(1260, 720);
            SearchPanel.TabIndex = 5;
            SearchPanel.Visible = false;
            // 
            // Results
            // 
            Results.AutoSize = true;
            Results.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Results.ForeColor = SystemColors.ControlLightLight;
            Results.Location = new Point(409, 0);
            Results.Name = "Results";
            Results.Size = new Size(400, 62);
            Results.TabIndex = 0;
            Results.Text = "Результаты поиска";
            // 
            // dev_panel
            // 
            dev_panel.BackgroundImage = (Image)resources.GetObject("dev_panel.BackgroundImage");
            dev_panel.Controls.Add(panel_sign);
            dev_panel.Controls.Add(pictureBox5);
            dev_panel.Controls.Add(add_button);
            dev_panel.Controls.Add(label_dev);
            dev_panel.Controls.Add(menu_del_button);
            dev_panel.Controls.Add(menu_pers_button);
            dev_panel.Controls.Add(menu_game_button);
            dev_panel.Controls.Add(panel_del);
            dev_panel.Controls.Add(panel_pers);
            dev_panel.Controls.Add(panel_gf);
            dev_panel.Location = new Point(-1, 1);
            dev_panel.Name = "dev_panel";
            dev_panel.Size = new Size(1280, 777);
            dev_panel.TabIndex = 1;
            dev_panel.Visible = false;
            // 
            // panel_sign
            // 
            panel_sign.BackgroundImage = (Image)resources.GetObject("panel_sign.BackgroundImage");
            panel_sign.Controls.Add(pictureBox3);
            panel_sign.Controls.Add(sign_in);
            panel_sign.Controls.Add(password);
            panel_sign.Controls.Add(login);
            panel_sign.Location = new Point(3, 0);
            panel_sign.Name = "panel_sign";
            panel_sign.Size = new Size(1280, 777);
            panel_sign.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(47, 46, 51);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1047, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(179, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // sign_in
            // 
            sign_in.Image = (Image)resources.GetObject("sign_in.Image");
            sign_in.Location = new Point(514, 531);
            sign_in.Name = "sign_in";
            sign_in.Size = new Size(250, 52);
            sign_in.TabIndex = 2;
            sign_in.TabStop = false;
            sign_in.Click += sign_in_Click;
            sign_in.MouseEnter += sign_in_MouseEnter;
            sign_in.MouseLeave += sign_in_MouseLeave;
            // 
            // password
            // 
            password.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(651, 327);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(304, 48);
            password.TabIndex = 1;
            // 
            // login
            // 
            login.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(651, 238);
            login.Multiline = true;
            login.Name = "login";
            login.Size = new Size(304, 48);
            login.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(47, 46, 51);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(40, 638);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(173, 50);
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // add_button
            // 
            add_button.Image = (Image)resources.GetObject("add_button.Image");
            add_button.Location = new Point(1043, 34);
            add_button.Name = "add_button";
            add_button.Size = new Size(173, 43);
            add_button.TabIndex = 5;
            add_button.TabStop = false;
            add_button.Click += add_button_Click;
            add_button.MouseEnter += add_button_MouseEnter;
            add_button.MouseLeave += add_button_MouseLeave;
            // 
            // label_dev
            // 
            label_dev.AutoSize = true;
            label_dev.BackColor = Color.White;
            label_dev.Font = new Font("Century Gothic", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_dev.ForeColor = Color.FromArgb(47, 46, 51);
            label_dev.Location = new Point(295, 28);
            label_dev.Name = "label_dev";
            label_dev.Size = new Size(684, 49);
            label_dev.TabIndex = 4;
            label_dev.Text = "Добавление игры или фильма";
            // 
            // menu_del_button
            // 
            menu_del_button.Image = (Image)resources.GetObject("menu_del_button.Image");
            menu_del_button.Location = new Point(0, 261);
            menu_del_button.Name = "menu_del_button";
            menu_del_button.Size = new Size(256, 62);
            menu_del_button.TabIndex = 2;
            menu_del_button.TabStop = false;
            menu_del_button.Click += menu_del_button_Click;
            menu_del_button.MouseEnter += menu_del_button_MouseEnter;
            menu_del_button.MouseLeave += menu_del_button_MouseLeave;
            // 
            // menu_pers_button
            // 
            menu_pers_button.Image = (Image)resources.GetObject("menu_pers_button.Image");
            menu_pers_button.Location = new Point(0, 190);
            menu_pers_button.Name = "menu_pers_button";
            menu_pers_button.Size = new Size(256, 62);
            menu_pers_button.TabIndex = 1;
            menu_pers_button.TabStop = false;
            menu_pers_button.Click += menu_pers_button_Click;
            menu_pers_button.MouseEnter += pictureBox2_MouseEnter;
            menu_pers_button.MouseLeave += pictureBox2_MouseLeave;
            // 
            // menu_game_button
            // 
            menu_game_button.Image = (Image)resources.GetObject("menu_game_button.Image");
            menu_game_button.Location = new Point(0, 119);
            menu_game_button.Name = "menu_game_button";
            menu_game_button.Size = new Size(256, 62);
            menu_game_button.TabIndex = 0;
            menu_game_button.TabStop = false;
            menu_game_button.Click += menu_game_button_Click;
            menu_game_button.MouseEnter += menu_game_button_MouseEnter;
            menu_game_button.MouseLeave += menu_game_button_MouseLeave;
            // 
            // panel_del
            // 
            panel_del.BorderStyle = BorderStyle.FixedSingle;
            panel_del.Controls.Add(comboBox1);
            panel_del.Controls.Add(label15);
            panel_del.Controls.Add(pictureBox4);
            panel_del.Controls.Add(textBox1);
            panel_del.Controls.Add(label13);
            panel_del.Location = new Point(301, 120);
            panel_del.Name = "panel_del";
            panel_del.Size = new Size(925, 588);
            panel_del.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Персонаж", "Каталог" });
            comboBox1.Location = new Point(49, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 31);
            comboBox1.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(47, 46, 51);
            label15.Location = new Point(44, 22);
            label15.Name = "label15";
            label15.Size = new Size(233, 28);
            label15.TabIndex = 18;
            label15.Text = "Выберите объект:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(580, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 43);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(49, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 43);
            textBox1.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(47, 46, 51);
            label13.Location = new Point(44, 137);
            label13.Name = "label13";
            label13.Size = new Size(348, 28);
            label13.TabIndex = 13;
            label13.Text = "Введите название объекта:";
            // 
            // panel_pers
            // 
            panel_pers.AutoScroll = true;
            panel_pers.BorderStyle = BorderStyle.FixedSingle;
            panel_pers.Controls.Add(label11);
            panel_pers.Controls.Add(cb_choise);
            panel_pers.Controls.Add(label10);
            panel_pers.Controls.Add(label9);
            panel_pers.Controls.Add(check_music);
            panel_pers.Controls.Add(check_photo);
            panel_pers.Controls.Add(check_screenshot);
            panel_pers.Controls.Add(label_sound);
            panel_pers.Controls.Add(label_photo);
            panel_pers.Controls.Add(label_screenshot);
            panel_pers.Controls.Add(search);
            panel_pers.Controls.Add(textBox_file);
            panel_pers.Controls.Add(label5);
            panel_pers.Controls.Add(textBox_src);
            panel_pers.Controls.Add(label4);
            panel_pers.Controls.Add(textBox_about);
            panel_pers.Controls.Add(label3);
            panel_pers.Controls.Add(textBox_name);
            panel_pers.Controls.Add(label2);
            panel_pers.Location = new Point(301, 120);
            panel_pers.Name = "panel_pers";
            panel_pers.Size = new Size(925, 588);
            panel_pers.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(685, 790);
            label11.Name = "label11";
            label11.Size = new Size(7, 105);
            label11.TabIndex = 18;
            label11.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // cb_choise
            // 
            cb_choise.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_choise.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cb_choise.FormattingEnabled = true;
            cb_choise.ImeMode = ImeMode.NoControl;
            cb_choise.Location = new Point(49, 826);
            cb_choise.MaxDropDownItems = 100;
            cb_choise.Name = "cb_choise";
            cb_choise.Size = new Size(500, 31);
            cb_choise.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(47, 46, 51);
            label10.Location = new Point(44, 784);
            label10.Name = "label10";
            label10.Size = new Size(338, 28);
            label10.TabIndex = 17;
            label10.Text = "Выберите игру или фильм:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(552, 722);
            label9.Name = "label9";
            label9.Size = new Size(7, 75);
            label9.TabIndex = 15;
            label9.Text = "\r\n\r\n\r\n\r\n\r\n";
            // 
            // check_music
            // 
            check_music.Image = (Image)resources.GetObject("check_music.Image");
            check_music.Location = new Point(376, 747);
            check_music.Name = "check_music";
            check_music.Size = new Size(23, 23);
            check_music.TabIndex = 14;
            check_music.TabStop = false;
            // 
            // check_photo
            // 
            check_photo.Image = (Image)resources.GetObject("check_photo.Image");
            check_photo.Location = new Point(376, 713);
            check_photo.Name = "check_photo";
            check_photo.Size = new Size(23, 23);
            check_photo.TabIndex = 13;
            check_photo.TabStop = false;
            // 
            // check_screenshot
            // 
            check_screenshot.Image = (Image)resources.GetObject("check_screenshot.Image");
            check_screenshot.Location = new Point(376, 679);
            check_screenshot.Name = "check_screenshot";
            check_screenshot.Size = new Size(23, 23);
            check_screenshot.TabIndex = 12;
            check_screenshot.TabStop = false;
            // 
            // label_sound
            // 
            label_sound.AutoSize = true;
            label_sound.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_sound.ForeColor = Color.FromArgb(47, 46, 51);
            label_sound.Location = new Point(49, 747);
            label_sound.Name = "label_sound";
            label_sound.Size = new Size(256, 23);
            label_sound.TabIndex = 11;
            label_sound.Text = "Файл для звука не найден";
            // 
            // label_photo
            // 
            label_photo.AutoSize = true;
            label_photo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_photo.ForeColor = Color.FromArgb(47, 46, 51);
            label_photo.Location = new Point(49, 715);
            label_photo.Name = "label_photo";
            label_photo.Size = new Size(256, 23);
            label_photo.TabIndex = 10;
            label_photo.Text = "Файл для фото не найден";
            // 
            // label_screenshot
            // 
            label_screenshot.AutoSize = true;
            label_screenshot.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_screenshot.ForeColor = Color.FromArgb(47, 46, 51);
            label_screenshot.Location = new Point(49, 679);
            label_screenshot.Name = "label_screenshot";
            label_screenshot.Size = new Size(312, 23);
            label_screenshot.TabIndex = 9;
            label_screenshot.Text = "Файл для скриншота не найден";
            // 
            // search
            // 
            search.Image = (Image)resources.GetObject("search.Image");
            search.Location = new Point(580, 613);
            search.Name = "search";
            search.Size = new Size(173, 43);
            search.TabIndex = 8;
            search.TabStop = false;
            search.Click += search_Click;
            search.MouseEnter += search_MouseEnter_1;
            search.MouseLeave += search_MouseLeave_1;
            // 
            // textBox_file
            // 
            textBox_file.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_file.Location = new Point(49, 613);
            textBox_file.Multiline = true;
            textBox_file.Name = "textBox_file";
            textBox_file.Size = new Size(500, 43);
            textBox_file.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(47, 46, 51);
            label5.Location = new Point(44, 575);
            label5.Name = "label5";
            label5.Size = new Size(341, 28);
            label5.TabIndex = 6;
            label5.Text = "Введите название файлов:";
            // 
            // textBox_src
            // 
            textBox_src.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_src.Location = new Point(49, 501);
            textBox_src.Multiline = true;
            textBox_src.Name = "textBox_src";
            textBox_src.Size = new Size(500, 43);
            textBox_src.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(47, 46, 51);
            label4.Location = new Point(44, 463);
            label4.Name = "label4";
            label4.Size = new Size(237, 28);
            label4.TabIndex = 4;
            label4.Text = "Введите источник:";
            // 
            // textBox_about
            // 
            textBox_about.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_about.Location = new Point(49, 184);
            textBox_about.Multiline = true;
            textBox_about.Name = "textBox_about";
            textBox_about.Size = new Size(821, 257);
            textBox_about.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(47, 46, 51);
            label3.Location = new Point(44, 138);
            label3.Name = "label3";
            label3.Size = new Size(390, 28);
            label3.TabIndex = 2;
            label3.Text = "Введите описание пресонажа:";
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_name.Location = new Point(49, 67);
            textBox_name.Multiline = true;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(500, 43);
            textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(47, 46, 51);
            label2.Location = new Point(44, 19);
            label2.Name = "label2";
            label2.Size = new Size(386, 28);
            label2.TabIndex = 0;
            label2.Text = "Введите название пресонажа:";
            // 
            // panel_gf
            // 
            panel_gf.BorderStyle = BorderStyle.FixedSingle;
            panel_gf.Controls.Add(pictureBox_logo);
            panel_gf.Controls.Add(label_logo);
            panel_gf.Controls.Add(search_gf);
            panel_gf.Controls.Add(textBox_logo);
            panel_gf.Controls.Add(label8);
            panel_gf.Controls.Add(cb_gf);
            panel_gf.Controls.Add(label7);
            panel_gf.Controls.Add(textBox_name_gf);
            panel_gf.Controls.Add(label6);
            panel_gf.Location = new Point(301, 120);
            panel_gf.Name = "panel_gf";
            panel_gf.Size = new Size(925, 588);
            panel_gf.TabIndex = 16;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Image = (Image)resources.GetObject("pictureBox_logo.Image");
            pictureBox_logo.Location = new Point(376, 353);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(23, 23);
            pictureBox_logo.TabIndex = 9;
            pictureBox_logo.TabStop = false;
            // 
            // label_logo
            // 
            label_logo.AutoSize = true;
            label_logo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_logo.ForeColor = Color.FromArgb(47, 46, 51);
            label_logo.Location = new Point(45, 352);
            label_logo.Name = "label_logo";
            label_logo.Size = new Size(290, 23);
            label_logo.TabIndex = 8;
            label_logo.Text = "Файл для логотипа не найден";
            // 
            // search_gf
            // 
            search_gf.Image = (Image)resources.GetObject("search_gf.Image");
            search_gf.Location = new Point(580, 287);
            search_gf.Name = "search_gf";
            search_gf.Size = new Size(173, 43);
            search_gf.TabIndex = 7;
            search_gf.TabStop = false;
            search_gf.Click += search_gf_Click;
            search_gf.MouseEnter += search_gf_MouseEnter;
            search_gf.MouseLeave += search_gf_MouseLeave;
            // 
            // textBox_logo
            // 
            textBox_logo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_logo.Location = new Point(49, 287);
            textBox_logo.Multiline = true;
            textBox_logo.Name = "textBox_logo";
            textBox_logo.Size = new Size(500, 43);
            textBox_logo.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(47, 46, 51);
            label8.Location = new Point(44, 239);
            label8.Name = "label8";
            label8.Size = new Size(329, 28);
            label8.TabIndex = 5;
            label8.Text = "Введите название файла:";
            // 
            // cb_gf
            // 
            cb_gf.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cb_gf.FormattingEnabled = true;
            cb_gf.Items.AddRange(new object[] { "Игры", "Фильмы" });
            cb_gf.Location = new Point(49, 187);
            cb_gf.Name = "cb_gf";
            cb_gf.Size = new Size(500, 31);
            cb_gf.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(47, 46, 51);
            label7.Location = new Point(44, 137);
            label7.Name = "label7";
            label7.Size = new Size(280, 28);
            label7.TabIndex = 3;
            label7.Text = "Выберите категорию:";
            // 
            // textBox_name_gf
            // 
            textBox_name_gf.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_name_gf.Location = new Point(49, 70);
            textBox_name_gf.Multiline = true;
            textBox_name_gf.Name = "textBox_name_gf";
            textBox_name_gf.Size = new Size(500, 43);
            textBox_name_gf.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(47, 46, 51);
            label6.Location = new Point(44, 22);
            label6.Name = "label6";
            label6.Size = new Size(457, 28);
            label6.TabIndex = 1;
            label6.Text = "Введите название игры или фильма:";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Catalog_Project.Properties.Resources.dev;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-1, 668);
            button2.Name = "button2";
            button2.Size = new Size(78, 61);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // window
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Catalog_Project.Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 738);
            Controls.Add(button2);
            Controls.Add(dev_panel);
            Controls.Add(SearchPanel);
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
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            dev_panel.ResumeLayout(false);
            dev_panel.PerformLayout();
            panel_sign.ResumeLayout(false);
            panel_sign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)sign_in).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)add_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_del_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_pers_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_game_button).EndInit();
            panel_del.ResumeLayout(false);
            panel_del.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_pers.ResumeLayout(false);
            panel_pers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)check_music).EndInit();
            ((System.ComponentModel.ISupportInitialize)check_photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)check_screenshot).EndInit();
            ((System.ComponentModel.ISupportInitialize)search).EndInit();
            panel_gf.ResumeLayout(false);
            panel_gf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_gf).EndInit();
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
        private myPanel SearchPanel;
        private Label Results;
        private Panel dev_panel;
        private PictureBox menu_del_button;
        private PictureBox menu_pers_button;
        private PictureBox menu_game_button;
        private PictureBox add_button;
        private Label label_dev;
        private Panel panel_pers;
        private Label label2;
        private Label label9;
        private PictureBox check_music;
        private PictureBox check_photo;
        private PictureBox check_screenshot;
        private Label label_sound;
        private Label label_photo;
        private Label label_screenshot;
        private PictureBox search;
        private TextBox textBox_file;
        private Label label5;
        private TextBox textBox_src;
        private Label label4;
        private TextBox textBox_about;
        private Label label3;
        private TextBox textBox_name;
        private Panel panel_gf;
        private PictureBox pictureBox_logo;
        private Label label_logo;
        private PictureBox search_gf;
        private TextBox textBox_logo;
        private Label label8;
        private ComboBox cb_gf;
        private Label label7;
        private TextBox textBox_name_gf;
        private Label label6;
        private Panel panel_del;
        private Label label11;
        private ComboBox cb_choise;
        private Label label10;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private Label label13;
        private Button button2;
        private Panel panel_sign;
        private PictureBox sign_in;
        private TextBox password;
        private TextBox login;
        private PictureBox pictureBox5;
        private ComboBox comboBox1;
        private Label label15;
        private PictureBox pictureBox3;
    }
}