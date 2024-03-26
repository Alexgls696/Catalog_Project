using Microsoft.VisualBasic.Logging;
using Microsoft.Data.Sqlite;
using System.Text;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Game_Catalog_Project
{

    public partial class window : Form
    {
        private myPanel gameCatalogPanel; //каталог игр
        private myPanel filmsCatalogPanel; //каталог фильмов
        private myPanel CharactersPanel; //каталог персонажей в играх или фильмах

        private string current_panel = "Main";
        private string last_catalog = "";
        private string last_catalog2 = "";

        private List<Character> characters = new List<Character>();
        private List<Catalog> catalogs = new List<Catalog>(); //каталоги игр, фильмов и тд

        private List<Character> search_characters_list = new List<Character>();

        private string search_mode = "";

        int current_index = 0;

        public window()
        {
            
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
           // FormBorderStyle = FormBorderStyle.FixedSingle;
            DoubleBuffered = true;
            InitializeComponent();
            PanelsInit();
            Controls.Add(backButton);
            LoadCatalogsFromFile(); 
            setCatalogLocation();
            LoadCharactersFromFile(); 

            GamesButton.Click += GamesButton_Click; FilmsButton.Click += FilmsButton_Click;
            SearchButton.Click += SearchButton_Click; backButton.Click += BackButton_Click;
            button1.Click += button1_Click; pictureBox3.Click += pictureBox3_Click;
            sign_in.Click += sign_in_Click;
            sign_in.MouseEnter += sign_in_MouseEnter;
            sign_in.MouseLeave += sign_in_MouseLeave;
            pictureBox5.Click += pictureBox5_Click;
            add_button.Click += add_button_Click;
            add_button.MouseEnter += add_button_MouseEnter;
            add_button.MouseLeave += add_button_MouseLeave;
            menu_del_button.Click += menu_del_button_Click;
            menu_del_button.MouseEnter += menu_del_button_MouseEnter;
            menu_del_button.MouseLeave += menu_del_button_MouseLeave;
            menu_pers_button.Click += menu_pers_button_Click;
            menu_pers_button.MouseEnter += pictureBox2_MouseEnter;
            menu_pers_button.MouseLeave += pictureBox2_MouseLeave;
            menu_game_button.Click += menu_game_button_Click;
            menu_game_button.MouseEnter += menu_game_button_MouseEnter;
            menu_game_button.MouseLeave += menu_game_button_MouseLeave;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            search_gf.Click += search_gf_Click;
            search_gf.MouseEnter += search_gf_MouseEnter;
            search_gf.MouseLeave += search_gf_MouseLeave;
            button2.Click += button2_Click;
            search.Click += search_Click;
            search.MouseEnter += search_MouseEnter_1;
            search.MouseLeave += search_MouseLeave_1;
            pictureBox_logo.Location = new Point(label_logo.Location.X + label_logo.Size.Width + 10, pictureBox_logo.Location.Y);
            check_music.Location=new Point(label_screenshot.Location.X + label_screenshot.Size.Width + 10, check_music.Location.Y);
            check_screenshot.Location = new Point(label_screenshot.Location.X + label_screenshot.Size.Width + 10, check_screenshot.Location.Y);
            check_photo.Location = new Point(label_screenshot.Location.X + label_screenshot.Size.Width + 10, check_photo.Location.Y);
        }
        public void LoadCharactersFromFile() //Загрузка персов в лист
                                             //Здесь должен быть получен файл со списком персонажей из БД.
        {
            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT Characters.Name, Characters.Link, Characters.Biography, Characters.Photo_path, Characters.Screen, GamesFilms.Name, Characters.Sound FROM Characters JOIN GamesFilms ON GamesFilms.id = Characters.GamesFilms_id;";
                SqliteCommand command = new SqliteCommand(sql, connection);
                SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string link = reader.GetString(1);
                    string biography = reader.GetString(2);
                    string photo_path = reader.GetString(3);
                    string screen = reader.GetString(4);
                    string parent_name = reader.GetString(5);
                    string sound = reader.GetString(6);
                    Character character = new Character(name, biography, link, parent_name, photo_path, screen, sound);
                    characters.Add(character);
                }
                characters=SortCharacters(characters);
                connection.Close();
            }
        }

        void addCharactersToThePanel(string parent) //Добавляет персонажей на панель
        {
            Panel panel = null;
            int moveX = 0;
            int moveY = 0;
            int count = 0;
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].getParentName() == parent)
                {
                    Button button = new Button();
                    button.Size = new Size(250, 250);
                    button.Location = new Point(moveX + 50, moveY + 50);
                    //------------------------------------------------------------------------------------
                    button.BackgroundImage = new Bitmap(characters[i].Photo());
                    //выбор верного формата фото, нужно без бд. Т.к в БД будет лежать верное значение сразу

                    button.BackColor = Color.Transparent;
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Transparent;
                    button.FlatAppearance.BorderSize = 0;
                    button.UseVisualStyleBackColor = false;
                    button.Name = characters[i].getName();
                    button.Click += current_character_panel_click;
                    gameCatalogPanel.Controls.Add(button);
                    moveX += 300;
                    if ((count + 1) % 4 == 0)
                    {
                        moveX = 0;
                        moveY += 300;
                    }
                    count++;
                    Label label = new Label();
                    CharactersPanel.Controls.Add(button);
                }
            }
        }
        private void current_character_panel_click(object? sender, EventArgs e) //Клик на персонажа
        {
            Button button = (Button)sender;
            string name = "";
            for (int i = 0; i < CharactersPanel.Controls.Count; i++)
            {
                if (CharactersPanel.Controls[i].Equals(button))
                {
                    name = button.Name;
                }
            }
            SearchTextBox.Visible = false;
            SearchButton.Visible = false;
            last_catalog2 = last_catalog;
            last_catalog = current_panel;
            current_panel = "CharacterInfo";
            ShowInfoAboutCharacter(name); //Отображение
        }

        private void ShowInfoAboutCharacter(string name) //Отображение инфы о персонаже
        {
            characterInfoPanel1.Location = new Point(0, 70);
            characterInfoPanel1.Visible = true;
            CharactersPanel.Visible = false;
            Character character = null;

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].getName().Equals(name))
                {
                    character = characters[i]; current_index = i; break;
                }
            }
            pictureBox1.BackgroundImage = new Bitmap(character.Photo());
            pictureBox2.BackgroundImage = new Bitmap(character.Screen());
            label1.Text = character.getName();
            label1.ForeColor = Color.White;

            text.Text = character.getBiography();
            text.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            text.AutoSize = true;
            text.MaximumSize = new Size(1000, 5000);
            link.Text = character.getLink();
            panel1.Location=new Point(panel1.Location.X,panel2.Location.Y+panel2.Height+10);
        }

        private List<Character> SortCharacters(List<Character> catalog)
        {

            for (int i = 0; i < catalog.Count; i++)
            {
                for (int j = 0; j < catalog.Count - i - 1; j++)
                {
                    if (string.Compare(catalog[j].getName(), catalog[j + 1].getName()) > 0)
                    {
                        (catalog[j + 1], catalog[j]) = (catalog[j], catalog[j + 1]);
                    }
                }
            }
            return catalog;
        }

        private List<Catalog> SortCatalogs(List<Catalog> catalog)
        {
            for (int i = 0; i < catalog.Count - 1; i++)
            {
                for (int j = 0; j < catalog.Count - i - 1; j++)
                {
                    if (string.Compare(catalog[j].getName(), catalog[j + 1].getName()) > 0)
                    {
                        (catalog[j + 1], catalog[j]) = (catalog[j], catalog[j + 1]);
                    }
                }
            }
            return catalog;
        }
        private struct location //Структура для правильного отображения внутри каталогов
        {
            public int moveX;
            public int moveY;
            public int count;
            public location()
            {
                moveX = 0; moveY = 0; count = 0;
            }
        }

        private void setCatalogLocation() //Распределяет игры и фильмы в их каталоги, добавить сюда новый каталог в будущем
        {
            int moveX = 0;
            int moveY = 0;
            myPanel panel = null;
            location[] locations = new location[2]; //Добавить больше, если будет больше каталогов
            int current_index = 0;
            //игры - 0 индекс, фильмы - 1 индекс
            for (int i = 0; i < catalogs.Count; i++)
            {
                switch (catalogs[i].getType())
                {
                    case "game":
                        panel = gameCatalogPanel; current_index = 0; break;

                    case "film":
                        panel = filmsCatalogPanel; current_index = 1; break;
                }
                Button button = new Button();
                button.Size = new Size(250, 250);
                button.Location = new Point(locations[current_index].moveX + 50, locations[current_index].moveY + 50);
                button.BackgroundImage = new Bitmap(catalogs[i].getIcon());
                button.BackColor = Color.Transparent;
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.Transparent;
                button.FlatAppearance.BorderSize = 0;
                button.UseVisualStyleBackColor = false;
                button.Name = catalogs[i].getName();
                button.Click += CharactersClick;
                panel.Controls.Add(button);
                locations[current_index].moveX += 300;
                if ((locations[current_index].count + 1) % 4 == 0)
                {
                    locations[current_index].moveX = 0;
                    locations[current_index].moveY += 300;
                }
            }
        }

        private void LoadCatalogsFromFile() //Чтение данных из файлов
        {
            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT GamesFilms.Name, GamesFilms.Icon_path, Types.Name FROM GamesFilms JOIN Types ON Types._id = GamesFilms.Type_id;";
                SqliteCommand command = new SqliteCommand(sql, connection);
                SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string icon_path = reader.GetString(1);
                    string type = reader.GetString(2);

                    Catalog game = new Catalog(icon_path, name, type);
                    catalogs.Add(game);
                }
                catalogs=SortCatalogs(catalogs);
                connection.Close();
            }
        }
        private void CharactersClick(object? sender, EventArgs e)
        {
            CharactersPanel.Controls.Clear();
            Button button = sender as Button;
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].getParentName().Equals(button.Name))
                {
                    if (gameCatalogPanel.Visible)
                    {
                        last_catalog = "GamePanel";
                    }
                    if (filmsCatalogPanel.Visible)
                    {
                        last_catalog = "FilmsPanel";
                    }
                    gameCatalogPanel.Visible = false;
                    filmsCatalogPanel.Visible = false;
                    CharactersPanel.Visible = true;
                    addCharactersToThePanel(characters[i].getParentName());
                    current_panel = "characters"; break;
                }
            }
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            switch (search_mode)
            {
                case "search":
                    SearchButton.Visible = true;
                    SearchTextBox.Visible = true;
                    switch (current_panel)
                    {
                        case "Main":
                            button2.Visible = true;
                            GamesButton.Visible = true;
                            FilmsButton.Visible = true;
                            backButton.Visible = false; characterInfoPanel1.Visible = false; break;
                        case "GamePanel":
                            gameCatalogPanel.Visible = true; characterInfoPanel1.Visible = false; break;
                        case "FilmsPanel":
                            filmsCatalogPanel.Visible = true; characterInfoPanel1.Visible = false; break;
                        case "characters":
                            CharactersPanel.Visible = true; characterInfoPanel1.Visible = false; break;
                        case "CharacterInfo":
                            characterInfoPanel1.Visible = true; break;
                    }
                    search_mode = "";
                    SearchPanel.Visible = false;
                    return;
                case "Info":
                    SearchPanel.Visible = true;
                    characterInfoPanel1.Visible = false;
                    search_mode = "search";
                    return;
            }
            switch (current_panel)
            {
                case "GamePanel":
                    GamesButton.Visible = true;
                    FilmsButton.Visible = true;
                    gameCatalogPanel.Visible = false;
                    backButton.Visible = false;
                    current_panel = "Main";
                    button2.Visible = true;
                    break;
                case "FilmsPanel":
                    GamesButton.Visible = true;
                    FilmsButton.Visible = true;
                    backButton.Visible = false;
                    filmsCatalogPanel.Visible = false;
                    current_panel = "Main";
                    button2.Visible = true;
                    break;
                case "characters":
                    if (last_catalog.Equals("GamePanel"))
                    {
                        gameCatalogPanel.Visible = true;
                        CharactersPanel.Visible = false;
                        current_panel = "GamePanel";
                    }
                    if (last_catalog.Equals("FilmsPanel"))
                    {
                        filmsCatalogPanel.Visible = true;
                        CharactersPanel.Visible = false;
                        current_panel = "FilmsPanel";
                    }
                    break;
                case "CharacterInfo":
                    SearchTextBox.Visible = true;
                    CharactersPanel.Visible = true;
                    SearchButton.Visible = true;
                    characterInfoPanel1.Visible = false;
                    current_panel = "characters";
                    last_catalog = last_catalog2;
                    break;
            }
        }

        private void PanelsInit()
        {
            gameCatalogPanel = new myPanel();
            gameCatalogPanel.Location = new Point(0, 70);
            gameCatalogPanel.Size = new Size(1260, 600);
            gameCatalogPanel.Name = "GamePanel";
            gameCatalogPanel.Visible = false;
            gameCatalogPanel.BackColor = Color.White;
            gameCatalogPanel.BackColor = Color.Transparent;
            gameCatalogPanel.AutoScroll = true;

            filmsCatalogPanel = new myPanel();
            filmsCatalogPanel.Location = new Point(0, 70);
            filmsCatalogPanel.Size = new Size(1260, 600);
            filmsCatalogPanel.Name = "FilmsPanel";
            filmsCatalogPanel.Visible = false;
            filmsCatalogPanel.BackColor = Color.White;
            filmsCatalogPanel.BackColor = Color.Transparent;
            filmsCatalogPanel.AutoScroll = true;

            CharactersPanel = new myPanel();
            CharactersPanel.Location = new Point(0, 70);
            CharactersPanel.Size = new Size(1260, 600);
            CharactersPanel.Name = "CharacterPanel";
            CharactersPanel.Visible = false;
            CharactersPanel.BackColor = Color.White;
            CharactersPanel.BackColor = Color.Transparent;
            CharactersPanel.AutoScroll = true;
            //CharactersPanel.AutoSize = true;

            Controls.Add(gameCatalogPanel);
            Controls.Add(filmsCatalogPanel);
            Controls.Add(CharactersPanel);
        }

        private void GamesButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            GamesButton.Visible = false;
            FilmsButton.Visible = false;
            gameCatalogPanel.Visible = true;
            button2.Visible = false;
            current_panel = gameCatalogPanel.Name;
        }

        private void FilmsButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            GamesButton.Visible = false;
            FilmsButton.Visible = false;
            filmsCatalogPanel.Visible = true;
            button2.Visible = false;
            current_panel = filmsCatalogPanel.Name;
        }

        private void button1_Click(object sender, EventArgs e)//Клик на кнопку воспроизведения звука
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = characters[current_index].getSound();
            wplayer.controls.play();
        }

        private void Search()
        {
            string search_str = SearchTextBox.Text;
            search_characters_list.Clear();
            SearchPanel.Controls.Clear();
            SearchPanel.Controls.Add(Results);
            if (search_str.Length == 0)
            {
                return;
            }
            int moveX = 0;
            int moveY = 50;
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].getName().ToLower().Contains(search_str.ToLower()))
                {
                    Button button = new Button();
                    button.Size = new Size(250, 250);
                    button.Location = new Point(moveX + 50, moveY + 50);
                    //------------------------------------------------------------------------------------
                    button.BackgroundImage = new Bitmap(characters[i].Photo());
                    //выбор верного формата фото, нужно без бд. Т.к в БД будет лежать верное значение сразу
                    button.BackColor = Color.Transparent;
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Transparent;
                    button.FlatAppearance.BorderSize = 0;
                    button.UseVisualStyleBackColor = false;
                    button.Name = characters[i].getName();
                    button.Click += current_character_in_search_click;
                    gameCatalogPanel.Controls.Add(button);
                    moveX += 300;
                    if ((i + 1) % 4 == 0)
                    {
                        moveX = 0;
                        moveY += 300;
                    }
                    Label label = new Label();
                    SearchPanel.Controls.Add(button);
                }
            }
        }

        private void current_character_in_search_click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            string name = "";
            for (int i = 0; i < SearchPanel.Controls.Count; i++)
            {
                if (SearchPanel.Controls[i].Equals(button))
                {
                    name = button.Name;
                }
            }
            SearchTextBox.Visible = false;
            SearchButton.Visible = false;
            SearchPanel.Visible = false;
            search_mode = "Info";
            ShowInfoAboutCharacter(name); //Отображение
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchPanel.Location = new Point(0, 70);
            SearchPanel.Visible = true;
            search_mode = "search";
            button2.Visible = false;
            switch (current_panel)
            {
                case "Main":
                    SearchPanel.Visible = true;
                    GamesButton.Visible = true;
                    FilmsButton.Visible = true;
                    backButton.Visible = true;
                    characterInfoPanel1.Visible = false; break;
                case "GamePanel":
                    gameCatalogPanel.Visible = false;
                    break;
                case "FilmsPanel":
                    filmsCatalogPanel.Visible = false;
                    break;
                case "characters":
                    CharactersPanel.Visible = false;
                    break;
                case "CharacterInfo":
                    characterInfoPanel1.Visible = false;
                    break;
            }
            SearchPanel.Visible = true;
            Search();
        }

        //
        //
        // Административаня панель
        //
        //

        private int selected_button = 1;
        private int count_found;
        private bool is_found_logo = false;
        private string directoryPathPhoto = " ";
        private string directoryPathScreenshot = " ";
        private string directoryPathMusic = " ";
        private string directoryPathLogo = " ";
        private bool is_authorized = false;

        private void menu_game_button_MouseEnter(object sender, EventArgs e)
        {
            menu_game_button.ImageLocation = "dev_panel/menu_gf_button_on.png";
        }

        private void menu_game_button_MouseLeave(object sender, EventArgs e)
        {
            if (selected_button != 1)
                menu_game_button.ImageLocation = "dev_panel/menu_gf_button.png";
        }

        private void menu_game_button_Click(object sender, EventArgs e)
        {
            restart_panel();
            add_button.Visible = true;
            panel_gf.Visible = true;
            selected_button = 1;
            restart_button();
            menu_game_button.ImageLocation = "dev_panel/menu_gf_button_on.png";
            label_dev.Text = "Добавление игры или фильма";
        }
        private void restart_button()
        {
            menu_game_button.ImageLocation = "dev_panel/menu_gf_button.png";
            menu_pers_button.ImageLocation = "dev_panel/menu_pers_button.png";
            menu_del_button.ImageLocation = "dev_panel/menu_del_button.png";
        }

        private void fiil_combobox_choise()
        {
            cb_choise.Items.Clear();
            List<Catalog> characters = new List<Catalog>();
            get_db_gf(characters);
            foreach (Catalog c in characters)
            {
                cb_choise.Items.Add(c.getName());
            }
        }

        private void menu_pers_button_Click(object sender, EventArgs e)
        {
            restart_panel();
            add_button.Visible = true;
            fiil_combobox_choise();
            panel_pers.Visible = true;
            selected_button = 2;
            restart_button();
            menu_pers_button.ImageLocation = "dev_panel/menu_pers_button_on.png";
            label_dev.Text = "Добавление персонажа";
        }

        private void menu_del_button_MouseEnter(object sender, EventArgs e)
        {
            menu_del_button.ImageLocation = "dev_panel/menu_del_button_on.png";
        }

        private void menu_del_button_MouseLeave(object sender, EventArgs e)
        {
            if (selected_button != 3)
                menu_del_button.ImageLocation = "dev_panel/menu_del_button.png";
        }

        private void menu_del_button_Click(object sender, EventArgs e)
        {
            restart_panel();
            panel_del.Visible = true;
            selected_button = 3;
            restart_button();
            add_button.Visible = false;
            menu_del_button.ImageLocation = "dev_panel/menu_del_button_on.png";
            label_dev.Text = "Удаление из базы данных";
        }

        private void search_Click(object sender, EventArgs e)
        {
            count_found = 0;
            string fileName = "icon/" + textBox_file.Text;
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            bool is_photo = false; ;
            foreach (string extension in imageExtensions)
            {
                if (File.Exists(fileName + extension))
                {
                    count_found++;
                    label_photo.Text = "Файл для фото найден";
                    check_photo.ImageLocation = "dev_panel/okey.png";
                    is_photo = true;
                    directoryPathPhoto = fileName + extension;
                    break;
                }
            }
            if (!is_photo)
            {
                label_photo.Text = "Файл для фото не найден";
                check_photo.ImageLocation = "dev_panel/bad.png";
            }

            string fileName2 = "screenshot/" + textBox_file.Text;
            string[] imageExtensions2 = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            bool is_photo2 = false;
            foreach (string extension2 in imageExtensions2)
            {
                if (File.Exists(fileName2 + extension2))
                {
                    count_found++;
                    label_screenshot.Text = "Файл для скриншота найден";
                    check_screenshot.ImageLocation = "dev_panel/okey.png";
                    is_photo2 = true;
                    directoryPathScreenshot = fileName2 + extension2;
                    break;
                }
            }
            if (!is_photo2)
            {
                label_screenshot.Text = "Файл для скриншота не найден";
                check_screenshot.ImageLocation = "dev_panel/bad.png";
            }

            string fileName3 = "music/" + textBox_file.Text;
            string[] musicExtensions = { ".mp3", ".wav", ".ogg", ".flac" };
            bool fileExists = false;
            foreach (string extension in musicExtensions)
            {
                if (File.Exists(fileName3 + extension))
                {
                    count_found++;
                    fileExists = true;
                    label_sound.Text = "Файл для звука найден";
                    check_music.ImageLocation = "dev_panel/okey.png";
                    directoryPathMusic = fileName3 + extension;
                    break;
                }
            }
            if (!fileExists)
            {
                label_sound.Text = "Файл для звука не найден";
                check_music.ImageLocation = "dev_panel/bad.png";
            }

        }

        private void search_MouseEnter_1(object sender, EventArgs e)
        {
            search.ImageLocation = "dev_panel/search_on.png";
        }

        private void search_MouseLeave_1(object sender, EventArgs e)
        {
            search.ImageLocation = "dev_panel/search.png";
        }

        private void add_button_MouseEnter(object sender, EventArgs e)
        {
            add_button.ImageLocation = "dev_panel/add_on.png";
        }

        private void add_button_MouseLeave(object sender, EventArgs e)
        {
            add_button.ImageLocation = "dev_panel/add.png";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (selected_button == 2)
            {
                if ((textBox_name.Text != String.Empty) && ((textBox_about.Text != String.Empty)) && (textBox_src.Text != String.Empty) && (textBox_file.Text != String.Empty) && (count_found == 3))
                {
                    Character C = new Character(textBox_name.Text, textBox_about.Text, textBox_src.Text, cb_choise.Text, directoryPathPhoto, directoryPathScreenshot, directoryPathMusic);
                    send_db_pers(C);
                    clear_add_pers_panel();
                }
            }
            else if (selected_button == 1)
            {
                if ((textBox_name_gf.Text != String.Empty) && ((cb_gf.Text == "Игры") || (cb_gf.Text == "Фильмы")) && (is_found_logo))
                {
                    Catalog catalog = new Catalog(directoryPathLogo, textBox_name_gf.Text, cb_gf.Text);
                    send_db_gf(catalog);
                    clear_add_gf_panel();
                }
            }

        }
        private void clear_add_pers_panel()
        {
            textBox_name.Text = String.Empty;
            textBox_about.Text = String.Empty;
            textBox_file.Text = String.Empty;
            textBox_src.Text = String.Empty;
            check_music.ImageLocation = "dev_panel/bad.png";
            check_photo.ImageLocation = "dev_panel/bad.png";
            check_screenshot.ImageLocation = "dev_panel/bad.png";
            label_photo.Text = "Файл для фото не найден";
            label_sound.Text = "Файл для звука не найден";
            label_screenshot.Text = "Файл для скриншота не найден";
            count_found = 0;
        }

        private void clear_add_gf_panel()
        {
            textBox_name_gf.Text = String.Empty;
            cb_gf.Text = String.Empty;
            textBox_logo.Text = String.Empty;
            pictureBox_logo.ImageLocation = "dev_panel/bad.png";
            label_logo.Text = "Файл для логотипа не найден";
            is_found_logo = false;

        }

        void send_db_gf(Catalog C)
        {
            string name = C.getName();
            int index_type = (cb_gf.Text == "Игры") ? 1 : 2;
            string icon = C.getIcon();
            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql1 = $"INSERT INTO GamesFilms (Name, Icon_path, Type_id) VALUES ('{name}', '{icon}', {index_type})";
                SqliteCommand command = new SqliteCommand(sql1, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine(result.ToString());
                connection.Close();
            }
        }

        private void send_db_pers(Character C)
        {
            string name = C.getName();
            string link = C.getLink();
            string bio = C.getBiography();
            int index_df = GetIdByName(C.getParentName());
            string photo = C.Photo();
            string screen = C.Screen();
            string sound = C.getSound();
            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql1 = $"INSERT INTO Characters (Name, Link, Biography, GamesFilms_id, Photo_path, Screen, Sound) VALUES ('{name}', '{link}', '{bio}', {index_df}, '{photo}', '{screen}', '{sound}')";
                SqliteCommand command = new SqliteCommand(sql1, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine(result.ToString());
                connection.Close();
            }
        }

        private void get_db_gf(List<Catalog> catalogs)
        {
            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT GamesFilms.Name, GamesFilms.Icon_path, Types.Name FROM GamesFilms JOIN Types ON Types._id = GamesFilms.Type_id;";
                SqliteCommand command = new SqliteCommand(sql, connection);
                SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string icon_path = reader.GetString(1);
                    string type = reader.GetString(2);
                    Catalog game = new Catalog(icon_path, name, type);
                    catalogs.Add(game);
                }
                connection.Close();
            }
        }

        private void restart_panel()
        {
            panel_pers.Visible = false;
            panel_gf.Visible = false;
            panel_del.Visible = false;
        }

        private void search_gf_MouseEnter(object sender, EventArgs e)
        {
            search_gf.ImageLocation = "dev_panel/search_on.png";
        }

        private void search_gf_MouseLeave(object sender, EventArgs e)
        {
            search_gf.ImageLocation = "dev_panel/search.png";
        }

        private void search_gf_Click(object sender, EventArgs e)
        {
            string fileName = "logo/" + textBox_logo.Text;
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            foreach (string extension in imageExtensions)
            {
                if (File.Exists(fileName + extension))
                {
                    directoryPathLogo = fileName + extension;
                    is_found_logo = true;
                    label_logo.Text = "Файл для логотипа найден";
                    pictureBox_logo.ImageLocation = "dev_panel/okey.png";
                    return;
                }
            }
            is_found_logo = false;
            label_logo.Text = "Файл для логотипа не найден";
            pictureBox_logo.ImageLocation = "dev_panel/bad.png";
        }

        private void menu_pers_button_MouseEnter(object sender, EventArgs e)
        {
            restart_panel();
            if (is_authorized)
            {
                panel_sign.Visible = false;
            }
            else
            {
                panel_sign.Visible = true;
            }
            panel_gf.Visible = true;
        }

        public int GetIdByName(string name)
        {
            string connectionString = "Data Source=usersdata.db;";
            int id = -1;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id FROM GamesFilms WHERE Name = @Name";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                    }
                }
            }

            return id;
        }

        private void sign_in_MouseEnter(object sender, EventArgs e)
        {
            sign_in.ImageLocation = "dev_panel/signin_on.png";
        }

        private void sign_in_MouseLeave(object sender, EventArgs e)
        {
            sign_in.ImageLocation = "dev_panel/signin.png";
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("login.txt");
            if ((lines[0] == login.Text) && (lines[1] == password.Text))
            {
                is_authorized = true;
                panel_sign.Visible = false;
                restart_panel();
                add_button.Visible = true;
                panel_gf.Visible = true;
                selected_button = 1;
                restart_button();
                menu_game_button.ImageLocation = "dev_panel/menu_gf_button_on.png";
                label_dev.Text = "Добавление игры или фильма";
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            menu_pers_button.ImageLocation = "dev_panel/menu_pers_button_on.png";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (selected_button != 2)
                menu_pers_button.ImageLocation = "dev_panel/menu_pers_button.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            restart_panel();
            panel_sign.Location = new Point(0, 0);
            dev_panel.Location=new Point(0, 0);
            dev_panel.Visible = true;
            panel_sign.Visible = true;
            button2.Visible = false;
            if (is_authorized)
            {
                panel_sign.Visible = false;
                restart_panel();
                add_button.Visible = true;
                panel_gf.Visible = true;
                selected_button = 1;
                restart_button();
                menu_game_button.ImageLocation = "dev_panel/menu_gf_button_on.png";
                label_dev.Text = "Добавление игры или фильма";
            }
            else
            {
                panel_sign.Visible = true;
            }
            panel_gf.Visible = true;
        }

        private void DeleteFromCharacters(string name)
        {

            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql1 = $"DELETE FROM Characters WHERE Name = '{name}'";
                SqliteCommand command = new SqliteCommand(sql1, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine(result.ToString());
                connection.Close();
            }
        }

        private void DeleteFromCatalog(string name)
        {
            string connectionString = @"Data Source=usersdata.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql1 = $"DELETE FROM GamesFilms WHERE Name = '{name}'";
                SqliteCommand command = new SqliteCommand(sql1, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine(result.ToString());
                connection.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dev_panel.Visible = false;
            button2.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (comboBox1.Text == "Каталог")
                {
                    DeleteFromCatalog(textBox1.Text);
                }
                else
                {
                    DeleteFromCharacters(textBox1.Text);
                }
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "dev_panel/search_on.png";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "dev_panel/search.png";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            dev_panel.Visible = false;
            panel_sign.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void sign_in_Click_1(object sender, EventArgs e)
        {

        }
    }
}


//Фикс панелей от мерцания при прокрутке
public partial class myPanel : Panel
{
    public myPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        UpdateStyles();
    }
    protected override void OnScroll(ScrollEventArgs se)
    {
        Invalidate();
        base.OnScroll(se);
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x2000000 | 0x02000000;
            return cp;
        }
    }
    private const int WM_HSCROLL = 0x114;
    private const int WM_VSCROLL = 0x115;

    protected override void WndProc(ref Message m)
    {
        if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
        && (((int)m.WParam & 0xFFFF) == 5))
        {
            m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
        }
        base.WndProc(ref m);
    }
}

public partial class myLayoutPanel : FlowLayoutPanel //Кастомные панели для фикса прокрутки
{
    public myLayoutPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        UpdateStyles();
    }
    protected override void OnScroll(ScrollEventArgs se)
    {
        Invalidate();
        base.OnScroll(se);
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x2000000 | 0x02000000;
            return cp;
        }
    }
    private const int WM_HSCROLL = 0x114;
    private const int WM_VSCROLL = 0x115;

    protected override void WndProc(ref Message m)
    {
        if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
        && (((int)m.WParam & 0xFFFF) == 5))
        {
            m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
        }
        base.WndProc(ref m);
    }
}