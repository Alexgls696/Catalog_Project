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
        /// 
        private void InitializeComponent()
        {
            this.GamesButton = new System.Windows.Forms.Button();
            this.FilmsButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.characterInfoPanel1 = new myPanel();
            this.panel1 = new myLayoutPanel();
            this.text = new System.Windows.Forms.Label();
            this.ist = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchPanel = new myPanel();
            this.Results = new System.Windows.Forms.Label();
            this.panel_sign = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sign_in = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dev_panel = new System.Windows.Forms.Panel();
            this.add_button = new System.Windows.Forms.PictureBox();
            this.label_dev = new System.Windows.Forms.Label();
            this.menu_del_button = new System.Windows.Forms.PictureBox();
            this.menu_pers_button = new System.Windows.Forms.PictureBox();
            this.menu_game_button = new System.Windows.Forms.PictureBox();
            this.panel_pers = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_choise = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.check_music = new System.Windows.Forms.PictureBox();
            this.check_photo = new System.Windows.Forms.PictureBox();
            this.check_screenshot = new System.Windows.Forms.PictureBox();
            this.label_sound = new System.Windows.Forms.Label();
            this.label_photo = new System.Windows.Forms.Label();
            this.label_screenshot = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.PictureBox();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_src = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_about = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_gf = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_logo = new System.Windows.Forms.Label();
            this.search_gf = new System.Windows.Forms.PictureBox();
            this.textBox_logo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_gf = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_name_gf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_del = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.characterInfoPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.panel_sign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sign_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.dev_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_del_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pers_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_game_button)).BeginInit();
            this.panel_pers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_screenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.panel_gf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_gf)).BeginInit();
            this.panel_del.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GamesButton
            // 
            this.GamesButton.BackColor = System.Drawing.Color.Transparent;
            this.GamesButton.BackgroundImage = global::Catalog_Project.Properties.Resources.games_icon;
            this.GamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamesButton.FlatAppearance.BorderSize = 0;
            this.GamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamesButton.Location = new System.Drawing.Point(220, 103);
            this.GamesButton.Name = "GamesButton";
            this.GamesButton.Size = new System.Drawing.Size(275, 275);
            this.GamesButton.TabIndex = 0;
            this.GamesButton.UseVisualStyleBackColor = false;
            // 
            // FilmsButton
            // 
            this.FilmsButton.BackColor = System.Drawing.Color.Transparent;
            this.FilmsButton.BackgroundImage = global::Catalog_Project.Properties.Resources.films_icon;
            this.FilmsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FilmsButton.FlatAppearance.BorderSize = 0;
            this.FilmsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FilmsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FilmsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilmsButton.Location = new System.Drawing.Point(706, 374);
            this.FilmsButton.Name = "FilmsButton";
            this.FilmsButton.Size = new System.Drawing.Size(275, 275);
            this.FilmsButton.TabIndex = 1;
            this.FilmsButton.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SearchTextBox.Location = new System.Drawing.Point(88, 12);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchTextBox.Size = new System.Drawing.Size(1099, 53);
            this.SearchTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.BackgroundImage = global::Catalog_Project.Properties.Resources.search;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.SearchButton.Location = new System.Drawing.Point(1193, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(59, 53);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Catalog_Project.Properties.Resources.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(11, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 53);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            // 
            // characterInfoPanel1
            // 
            this.characterInfoPanel1.AutoScroll = true;
            this.characterInfoPanel1.BackColor = System.Drawing.Color.Transparent;
            this.characterInfoPanel1.Controls.Add(this.panel1);
            this.characterInfoPanel1.Controls.Add(this.button1);
            this.characterInfoPanel1.Controls.Add(this.label1);
            this.characterInfoPanel1.Controls.Add(this.pictureBox2);
            this.characterInfoPanel1.Controls.Add(this.pictureBox1);
            this.characterInfoPanel1.Location = new System.Drawing.Point(1258, 11);
            this.characterInfoPanel1.MaximumSize = new System.Drawing.Size(1260, 720);
            this.characterInfoPanel1.Name = "characterInfoPanel1";
            this.characterInfoPanel1.Size = new System.Drawing.Size(1260, 635);
            this.characterInfoPanel1.TabIndex = 0;
            this.characterInfoPanel1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.ist);
            this.panel1.Controls.Add(this.link);
            this.panel1.Location = new System.Drawing.Point(88, 556);
            this.panel1.MaximumSize = new System.Drawing.Size(1200, 2000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 99);
            this.panel1.TabIndex = 4;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.SystemColors.Control;
            this.text.Location = new System.Drawing.Point(3, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(79, 37);
            this.text.TabIndex = 0;
            this.text.Text = "label2";
            // 
            // ist
            // 
            this.ist.AutoSize = true;
            this.ist.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ist.ForeColor = System.Drawing.Color.White;
            this.ist.Location = new System.Drawing.Point(485, 0);
            this.ist.Margin = new System.Windows.Forms.Padding(400, 0, 3, 0);
            this.ist.Name = "ist";
            this.ist.Size = new System.Drawing.Size(123, 33);
            this.ist.TabIndex = 5;
            this.ist.Text = "Источник:";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.link.ForeColor = System.Drawing.Color.Gold;
            this.link.Location = new System.Drawing.Point(614, 0);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(96, 37);
            this.link.TabIndex = 6;
            this.link.Text = "Ссылка";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(88, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Фраза";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            this.label1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(474, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(714, 496);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(88, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 382);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Controls.Add(this.Results);
            this.SearchPanel.Location = new System.Drawing.Point(4, 71);
            this.SearchPanel.MinimumSize = new System.Drawing.Size(1260, 720);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1260, 720);
            this.SearchPanel.TabIndex = 5;
            this.SearchPanel.Visible = false;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Results.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Results.Location = new System.Drawing.Point(409, 0);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(400, 62);
            this.Results.TabIndex = 0;
            this.Results.Text = "Результаты поиска";
            // 
            // panel_sign
            // 
            this.panel_sign.BackgroundImage = global::Catalog_Project.Properties.Resources.background_signin;
            this.panel_sign.Controls.Add(this.pictureBox3);
            this.panel_sign.Controls.Add(this.sign_in);
            this.panel_sign.Controls.Add(this.password);
            this.panel_sign.Controls.Add(this.login);
            this.panel_sign.Location = new System.Drawing.Point(0, 0);
            this.panel_sign.Name = "panel_sign";
            this.panel_sign.Size = new System.Drawing.Size(1280, 720);
            this.panel_sign.TabIndex = 3;
            this.panel_sign.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.pictureBox3.BackgroundImage = global::Catalog_Project.Properties.Resources.exit;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1047, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // sign_in
            // 
            this.sign_in.BackgroundImage = global::Catalog_Project.Properties.Resources.signin;
            this.sign_in.Location = new System.Drawing.Point(514, 531);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(250, 52);
            this.sign_in.TabIndex = 2;
            this.sign_in.TabStop = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click_1);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(651, 327);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(304, 48);
            this.password.TabIndex = 1;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(651, 238);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(304, 48);
            this.login.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.pictureBox5.BackgroundImage = global::Catalog_Project.Properties.Resources.exit1;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(26, 615);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 50);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // dev_panel
            // 
            this.dev_panel.BackgroundImage = global::Catalog_Project.Properties.Resources.background_main;
            this.dev_panel.Controls.Add(this.panel_sign);
            this.dev_panel.Controls.Add(this.pictureBox5);
            this.dev_panel.Controls.Add(this.add_button);
            this.dev_panel.Controls.Add(this.label_dev);
            this.dev_panel.Controls.Add(this.menu_del_button);
            this.dev_panel.Controls.Add(this.menu_pers_button);
            this.dev_panel.Controls.Add(this.menu_game_button);
            this.dev_panel.Controls.Add(this.panel_pers);
            this.dev_panel.Controls.Add(this.panel_gf);
            this.dev_panel.Controls.Add(this.panel_del);
            this.dev_panel.Location = new System.Drawing.Point(4, 0);
            this.dev_panel.Name = "dev_panel";
            this.dev_panel.Size = new System.Drawing.Size(1280, 678);
            this.dev_panel.TabIndex = 1;
            this.dev_panel.Visible = false;
            // 
            // add_button
            // 
            this.add_button.BackgroundImage = global::Catalog_Project.Properties.Resources.add;
            this.add_button.Location = new System.Drawing.Point(1043, 34);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(173, 43);
            this.add_button.TabIndex = 5;
            this.add_button.TabStop = false;
            // 
            // label_dev
            // 
            this.label_dev.AutoSize = true;
            this.label_dev.BackColor = System.Drawing.Color.White;
            this.label_dev.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label_dev.Location = new System.Drawing.Point(295, 28);
            this.label_dev.Name = "label_dev";
            this.label_dev.Size = new System.Drawing.Size(684, 49);
            this.label_dev.TabIndex = 4;
            this.label_dev.Text = "Добавление игры или фильма";
            // 
            // menu_del_button
            // 
            this.menu_del_button.BackgroundImage = global::Catalog_Project.Properties.Resources.menu_del_button;
            this.menu_del_button.Location = new System.Drawing.Point(0, 261);
            this.menu_del_button.Name = "menu_del_button";
            this.menu_del_button.Size = new System.Drawing.Size(256, 62);
            this.menu_del_button.TabIndex = 2;
            this.menu_del_button.TabStop = false;
            // 
            // menu_pers_button
            // 
            this.menu_pers_button.BackgroundImage = global::Catalog_Project.Properties.Resources.menu_pers_button;
            this.menu_pers_button.Location = new System.Drawing.Point(0, 190);
            this.menu_pers_button.Name = "menu_pers_button";
            this.menu_pers_button.Size = new System.Drawing.Size(256, 62);
            this.menu_pers_button.TabIndex = 1;
            this.menu_pers_button.TabStop = false;
            // 
            // menu_game_button
            // 
            this.menu_game_button.BackgroundImage = global::Catalog_Project.Properties.Resources.menu_gf_button;
            this.menu_game_button.Location = new System.Drawing.Point(0, 119);
            this.menu_game_button.Name = "menu_game_button";
            this.menu_game_button.Size = new System.Drawing.Size(256, 62);
            this.menu_game_button.TabIndex = 0;
            this.menu_game_button.TabStop = false;
            // 
            // panel_pers
            // 
            this.panel_pers.AutoScroll = true;
            this.panel_pers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pers.Controls.Add(this.label11);
            this.panel_pers.Controls.Add(this.cb_choise);
            this.panel_pers.Controls.Add(this.label10);
            this.panel_pers.Controls.Add(this.label9);
            this.panel_pers.Controls.Add(this.check_music);
            this.panel_pers.Controls.Add(this.check_photo);
            this.panel_pers.Controls.Add(this.check_screenshot);
            this.panel_pers.Controls.Add(this.label_sound);
            this.panel_pers.Controls.Add(this.label_photo);
            this.panel_pers.Controls.Add(this.label_screenshot);
            this.panel_pers.Controls.Add(this.search);
            this.panel_pers.Controls.Add(this.textBox_file);
            this.panel_pers.Controls.Add(this.label5);
            this.panel_pers.Controls.Add(this.textBox_src);
            this.panel_pers.Controls.Add(this.label4);
            this.panel_pers.Controls.Add(this.textBox_about);
            this.panel_pers.Controls.Add(this.label3);
            this.panel_pers.Controls.Add(this.textBox_name);
            this.panel_pers.Controls.Add(this.label2);
            this.panel_pers.Location = new System.Drawing.Point(301, 119);
            this.panel_pers.Name = "panel_pers";
            this.panel_pers.Size = new System.Drawing.Size(925, 588);
            this.panel_pers.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(685, 790);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(7, 105);
            this.label11.TabIndex = 18;
            this.label11.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // cb_choise
            // 
            this.cb_choise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_choise.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_choise.FormattingEnabled = true;
            this.cb_choise.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_choise.Location = new System.Drawing.Point(49, 826);
            this.cb_choise.MaxDropDownItems = 100;
            this.cb_choise.Name = "cb_choise";
            this.cb_choise.Size = new System.Drawing.Size(500, 31);
            this.cb_choise.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(44, 784);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Выберите игру или фильм:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 722);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(7, 75);
            this.label9.TabIndex = 15;
            this.label9.Text = "\r\n\r\n\r\n\r\n\r\n";
            // 
            // check_music
            // 
            this.check_music.Image = global::Catalog_Project.Properties.Resources.bad3;
            this.check_music.Location = new System.Drawing.Point(376, 747);
            this.check_music.Name = "check_music";
            this.check_music.Size = new System.Drawing.Size(23, 23);
            this.check_music.TabIndex = 14;
            this.check_music.TabStop = false;
            // 
            // check_photo
            // 
            this.check_photo.Image = global::Catalog_Project.Properties.Resources.bad2;
            this.check_photo.Location = new System.Drawing.Point(376, 713);
            this.check_photo.Name = "check_photo";
            this.check_photo.Size = new System.Drawing.Size(23, 23);
            this.check_photo.TabIndex = 13;
            this.check_photo.TabStop = false;
            // 
            // check_screenshot
            // 
            this.check_screenshot.Image = global::Catalog_Project.Properties.Resources.bad1;
            this.check_screenshot.Location = new System.Drawing.Point(376, 679);
            this.check_screenshot.Name = "check_screenshot";
            this.check_screenshot.Size = new System.Drawing.Size(23, 23);
            this.check_screenshot.TabIndex = 12;
            this.check_screenshot.TabStop = false;
            // 
            // label_sound
            // 
            this.label_sound.AutoSize = true;
            this.label_sound.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_sound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label_sound.Location = new System.Drawing.Point(49, 747);
            this.label_sound.Name = "label_sound";
            this.label_sound.Size = new System.Drawing.Size(256, 23);
            this.label_sound.TabIndex = 11;
            this.label_sound.Text = "Файл для звука не найден";
            // 
            // label_photo
            // 
            this.label_photo.AutoSize = true;
            this.label_photo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_photo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label_photo.Location = new System.Drawing.Point(49, 715);
            this.label_photo.Name = "label_photo";
            this.label_photo.Size = new System.Drawing.Size(256, 23);
            this.label_photo.TabIndex = 10;
            this.label_photo.Text = "Файл для фото не найден";
            // 
            // label_screenshot
            // 
            this.label_screenshot.AutoSize = true;
            this.label_screenshot.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_screenshot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label_screenshot.Location = new System.Drawing.Point(49, 679);
            this.label_screenshot.Name = "label_screenshot";
            this.label_screenshot.Size = new System.Drawing.Size(312, 23);
            this.label_screenshot.TabIndex = 9;
            this.label_screenshot.Text = "Файл для скриншота не найден";
            // 
            // search
            // 
            this.search.Image = global::Catalog_Project.Properties.Resources.search2;
            this.search.Location = new System.Drawing.Point(580, 613);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(173, 43);
            this.search.TabIndex = 8;
            this.search.TabStop = false;
            // 
            // textBox_file
            // 
            this.textBox_file.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_file.Location = new System.Drawing.Point(49, 613);
            this.textBox_file.Multiline = true;
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.Size = new System.Drawing.Size(500, 43);
            this.textBox_file.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(44, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите название файлов:";
            // 
            // textBox_src
            // 
            this.textBox_src.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_src.Location = new System.Drawing.Point(49, 501);
            this.textBox_src.Multiline = true;
            this.textBox_src.Name = "textBox_src";
            this.textBox_src.Size = new System.Drawing.Size(500, 43);
            this.textBox_src.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(44, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите источник:";
            // 
            // textBox_about
            // 
            this.textBox_about.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_about.Location = new System.Drawing.Point(49, 184);
            this.textBox_about.Multiline = true;
            this.textBox_about.Name = "textBox_about";
            this.textBox_about.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_about.Size = new System.Drawing.Size(821, 257);
            this.textBox_about.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(44, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите описание пресонажа:";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(49, 67);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(500, 43);
            this.textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите название пресонажа:";
            // 
            // panel_gf
            // 
            this.panel_gf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gf.Controls.Add(this.pictureBox_logo);
            this.panel_gf.Controls.Add(this.label_logo);
            this.panel_gf.Controls.Add(this.search_gf);
            this.panel_gf.Controls.Add(this.textBox_logo);
            this.panel_gf.Controls.Add(this.label8);
            this.panel_gf.Controls.Add(this.cb_gf);
            this.panel_gf.Controls.Add(this.label7);
            this.panel_gf.Controls.Add(this.textBox_name_gf);
            this.panel_gf.Controls.Add(this.label6);
            this.panel_gf.Location = new System.Drawing.Point(301, 120);
            this.panel_gf.Name = "panel_gf";
            this.panel_gf.Size = new System.Drawing.Size(925, 588);
            this.panel_gf.TabIndex = 16;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Catalog_Project.Properties.Resources.bad;
            this.pictureBox_logo.Location = new System.Drawing.Point(376, 353);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(23, 23);
            this.pictureBox_logo.TabIndex = 9;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label_logo.Location = new System.Drawing.Point(45, 352);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(290, 23);
            this.label_logo.TabIndex = 8;
            this.label_logo.Text = "Файл для логотипа не найден";
            // 
            // search_gf
            // 
            this.search_gf.Image = global::Catalog_Project.Properties.Resources.search1;
            this.search_gf.Location = new System.Drawing.Point(580, 287);
            this.search_gf.Name = "search_gf";
            this.search_gf.Size = new System.Drawing.Size(173, 43);
            this.search_gf.TabIndex = 7;
            this.search_gf.TabStop = false;
            // 
            // textBox_logo
            // 
            this.textBox_logo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_logo.Location = new System.Drawing.Point(49, 287);
            this.textBox_logo.Multiline = true;
            this.textBox_logo.Name = "textBox_logo";
            this.textBox_logo.Size = new System.Drawing.Size(500, 43);
            this.textBox_logo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(44, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Введите название файла:";
            // 
            // cb_gf
            // 
            this.cb_gf.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_gf.FormattingEnabled = true;
            this.cb_gf.Items.AddRange(new object[] {
            "Игры",
            "Фильмы"});
            this.cb_gf.Location = new System.Drawing.Point(49, 187);
            this.cb_gf.Name = "cb_gf";
            this.cb_gf.Size = new System.Drawing.Size(500, 31);
            this.cb_gf.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(44, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Выберите категорию:";
            // 
            // textBox_name_gf
            // 
            this.textBox_name_gf.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_name_gf.Location = new System.Drawing.Point(49, 70);
            this.textBox_name_gf.Multiline = true;
            this.textBox_name_gf.Name = "textBox_name_gf";
            this.textBox_name_gf.Size = new System.Drawing.Size(500, 43);
            this.textBox_name_gf.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(44, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Введите название игры или фильма:";
            // 
            // panel_del
            // 
            this.panel_del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_del.Controls.Add(this.comboBox1);
            this.panel_del.Controls.Add(this.label15);
            this.panel_del.Controls.Add(this.pictureBox4);
            this.panel_del.Controls.Add(this.textBox1);
            this.panel_del.Controls.Add(this.label13);
            this.panel_del.Location = new System.Drawing.Point(297, 116);
            this.panel_del.Name = "panel_del";
            this.panel_del.Size = new System.Drawing.Size(925, 588);
            this.panel_del.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Персонаж",
            "Каталог"});
            this.comboBox1.Location = new System.Drawing.Point(49, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(381, 31);
            this.comboBox1.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label15.Location = new System.Drawing.Point(44, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 28);
            this.label15.TabIndex = 18;
            this.label15.Text = "Выберите объект:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Catalog_Project.Properties.Resources.search1;
            this.pictureBox4.Location = new System.Drawing.Point(580, 176);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(173, 43);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.WaitOnLoad = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(49, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 43);
            this.textBox1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(44, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(348, 28);
            this.label13.TabIndex = 13;
            this.label13.Text = "Введите название объекта:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Catalog_Project.Properties.Resources.dev;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(4, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 61);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Catalog_Project.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.characterInfoPanel1);
            this.Controls.Add(this.dev_panel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FilmsButton);
            this.Controls.Add(this.GamesButton);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "window";
            this.characterInfoPanel1.ResumeLayout(false);
            this.characterInfoPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.panel_sign.ResumeLayout(false);
            this.panel_sign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sign_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.dev_panel.ResumeLayout(false);
            this.dev_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_del_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pers_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_game_button)).EndInit();
            this.panel_pers.ResumeLayout(false);
            this.panel_pers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_screenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.panel_gf.ResumeLayout(false);
            this.panel_gf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_gf)).EndInit();
            this.panel_del.ResumeLayout(false);
            this.panel_del.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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