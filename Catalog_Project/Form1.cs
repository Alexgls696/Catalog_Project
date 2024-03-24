using System.Text;
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

        private List<Character>search_characters_list = new List<Character>();

        private string search_mode = "";

        int current_index = 0;

        public window()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            DoubleBuffered = true;
            InitializeComponent();
            PanelsInit();
            Controls.Add(backButton);
            LoadCatalogsFromFile(); //Заменить на загрузку из БД
            setCatalogLocation();
            LoadCharactersFromFile(); //Заменить на загрузку из БД
        }


        private void setCharacterInfo(string path) //Устанавливает инфу о каждом персонаже из файла
        {
            Character character = new Character();
            StreamReader name_reader = new StreamReader(path + "name.txt");
            string name = name_reader.ReadLine();
            name_reader.Close();

            StreamReader opis_reader = new StreamReader(path + "opis.txt");

            StringBuilder builder = new StringBuilder();
            while (!opis_reader.EndOfStream)
            {
                builder.Append(opis_reader.ReadLine());
            }
            opis_reader.Close();

            StreamReader parent_reader = new StreamReader(path + "parent_name.txt");
            string parent = parent_reader.ReadLine();
            parent_reader.Close();

            StreamReader link_reader = new StreamReader(path + "link.txt");
            string link = link_reader.ReadLine();

            string icon = path + "icon.png";
            string screen = path + "screen.jpeg";
            string sound = path + "sound.mp3";

            character.setName(name);
            character.setLink(link);
            character.setBiography(builder.ToString());
            character.setParentName(parent);
            character.setPhoto(icon);
            character.setScreen(screen);
            character.setSound(sound);
            characters.Add(character);
        }
        public void LoadCharactersFromFile() //Загрузка персов в лист
                                             //Здесь должен быть получен файл со списком персонажей из БД.
        {
            StreamReader char_reader = new StreamReader("characters/CharactersList.txt");
            while (!char_reader.EndOfStream)
            {
                string char_folder = "";
                string char_path = "characters/";
                char_folder = char_reader.ReadLine();
                char_path = char_path + char_folder + "/";
                setCharacterInfo(char_path); //передается путь до файла
            }
            characters = SortCharacters(characters);
            char_reader.Close();
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
                    button.BackgroundImage = setCurrentPhoto(characters[i].Photo(), i);
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
        private Bitmap setCurrentPhoto(string Folder, int index)
        //выбор верного формата фото, нужно без бд. Т.к в БД будет лежать верное значение сразу
        {
            Bitmap bitmap = null;
            try
            {
                bitmap = new Bitmap(characters[index].Photo());
            }
            catch (Exception e)
            {
                try
                {
                    string folder = characters[index].Photo();
                    for (int j = folder.Length - 1; j >= 0; j--)
                    {
                        if (folder[j] == '.')
                        {
                            folder = folder.Remove(j);
                            folder += ".jpg";
                            bitmap = new Bitmap(folder);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        string folder = characters[index].Photo();
                        for (int j = folder.Length - 1; j >= 0; j--)
                        {
                            if (folder[j] == '.')
                            {
                                folder = folder.Remove(j);
                                folder += ".png";
                                bitmap = new Bitmap(folder);
                                break;
                            }
                        }
                    }
                    catch (Exception ex1)
                    {
                        throw ex1;
                    }
                }
            }
            return bitmap;
        }
        private Bitmap setCurrentScreen(string Folder, int index)
        //выбор верного формата скрина, нужно без бд. Т.к в БД будет лежать верное значение сразу
        {
            Bitmap bitmap = null;
            try
            {
                bitmap = new Bitmap(characters[index].Screen());
            }
            catch (Exception e)
            {
                try
                {
                    string folder = characters[index].Screen();
                    for (int j = folder.Length - 1; j >= 0; j--)
                    {
                        if (folder[j] == '.')
                        {
                            folder = folder.Remove(j);
                            folder += ".jpg";
                            bitmap = new Bitmap(folder);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        string folder = characters[index].Screen();
                        for (int j = folder.Length - 1; j >= 0; j--)
                        {
                            if (folder[j] == '.')
                            {
                                folder = folder.Remove(j);
                                folder += ".png";
                                bitmap = new Bitmap(folder);
                                break;
                            }
                        }
                    }
                    catch (Exception ex1)
                    {
                        throw ex1;
                    }
                }
            }
            return bitmap;
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
            

            pictureBox1.BackgroundImage = setCurrentPhoto(character.Photo(), current_index);
            pictureBox2.BackgroundImage = setCurrentScreen(character.Screen(), current_index);
            label1.Text = character.getName();
            label1.ForeColor = Color.White;

            text.Text = character.getBiography();
            text.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            text.AutoSize = true;
            text.MaximumSize = new Size(1000, 2000);
            link.Text = character.getLink();
        }

        private List<Character> SortCharacters(List<Character> catalog)
        {
            
            for (int i = 0; i < catalog.Count; i++)
            {
                for (int j = 0; j < catalog.Count-i-1; j++)
                {
                    if (string.Compare(catalog[j].getName(),catalog[j + 1].getName())>0)
                    {
                        (catalog[j+1], catalog[j]) = (catalog[j], catalog[j+1]);
                    }
                }
            }
            return catalog;
        }

        private List<Catalog> SortCatalogs(List<Catalog> catalog)
        {
            for (int i = 0; i < catalog.Count-1; i++)
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
            //Здесь catalog_list должен быть получен из БД
            string folder = "catalog/";
            string properties;
            List<string> propertiesList = new List<string>(); //строки из файла со списком игр или фильмов
            StreamReader reader = new StreamReader(folder + "catalog_list.txt");
            string icon_path;
            string parent_name;
            string type;
            while (!reader.EndOfStream)
            {
                properties = @reader.ReadLine();

                icon_path = properties.Split()[0];
                parent_name = properties.Split()[1];
                type = properties.Split()[2];
                Catalog catalog = new Catalog();
                catalog.setIcon(icon_path);
                catalog.setName(parent_name);
                catalog.setType(type);
                catalogs.Add(catalog);
            }
            catalogs = SortCatalogs(catalogs);
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
                    break;
                case "FilmsPanel":
                    GamesButton.Visible = true;
                    FilmsButton.Visible = true;
                    backButton.Visible = false;
                    filmsCatalogPanel.Visible = false;
                    current_panel = "Main";
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
            current_panel = gameCatalogPanel.Name;
        }

        private void FilmsButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            GamesButton.Visible = false;
            FilmsButton.Visible = false;
            filmsCatalogPanel.Visible = true;
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
            if( search_str.Length == 0)
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
                    button.BackgroundImage = setCurrentPhoto(characters[i].Photo(), i);
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
            for(int i = 0; i < SearchPanel.Controls.Count; i++)
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
            search_mode = "search";
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