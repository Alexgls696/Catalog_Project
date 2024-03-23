using System.Text;

namespace Game_Catalog_Project
{
    
    public partial class window : Form
    {
        private bool characters_load = true;
        private myPanel gameCatalogPanel; //каталог игр
        private myPanel filmsCatalogPanel; //каталог фильмов
        private myPanel CharactersPanel; //каталог персонажей в играх или фильмах
        private myLayoutPanel characterInfoPanel; //Инфа о персонаже

        private string current_panel = "";
        private string last_catalog = "";
        private string last_catalog2 = "";

        private List<Character> characters = new List<Character>();
        private List<Catalog>catalogs = new List<Catalog>(); //каталоги игр, фильмов и тд

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
           
            character.setName(name);
            character.setLink(link);
            character.setBiography(builder.ToString());
            character.setParentName(parent);
            character.setPhoto(icon);
            character.setScreen(screen);
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
                    if ((count+1) % 4 == 0)
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
            characterInfoPanel.Controls.Clear();
            ShowInfoAboutCharacter(name); //Отображение
        }

        private void ShowInfoAboutCharacter(string name) //Отображение инфы о персонаже
        {
            characterInfoPanel.Visible = true;
            CharactersPanel.Visible = false;
            Character character = null;
            int current_index = 0;
            for(int i = 0; i < characters.Count; i++)
            {
                if (characters[i].getName().Equals(name))
                {
                    character = characters[i]; current_index = i;  break;
                }
            }
            last_catalog2 = last_catalog;
            last_catalog = current_panel;
            current_panel = "CharacterInfo";

            PictureBox icon = new PictureBox();
            icon.Location = new Point(50, 50);
            icon.Margin = new Padding(100, 50, 3, 3);
            icon.BackgroundImage = setCurrentPhoto(character.Photo(), current_index); //выбор верного формата фото, нужно без бд. Т.к в БД будет лежать верное значение сразу
            icon.BackgroundImageLayout = ImageLayout.Zoom;
            icon.Name = "pictureBox1";
            icon.Size = new Size(300, 350);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 0;
            icon.TabStop = false;

            PictureBox screen = new PictureBox();
            screen.Dock = DockStyle.Fill;
            screen.BackgroundImage = setCurrentScreen(character.Screen(), current_index);
            screen.Location = new Point(372, 50);
            screen.BackgroundImageLayout = ImageLayout.Zoom;
            screen.Margin = new Padding(100, 50, 0, 3);
            screen.Name = "pictureBox2";
            screen.Size = new Size(600, 400);
            screen.TabIndex = 1;
            screen.TabStop = false;

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(880, 483);
            label1.Margin = new Padding(650, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.Text = character.getName();
            label1.Font= new Font("Segoe Print", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.White;

            myPanel panel = new myPanel();

            Label textBox1 = new Label();
            textBox1.Text = character.getBiography();
            textBox1.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.AutoSize = true;
            textBox1.MaximumSize = new Size(1000, 2000);

            panel.Controls.Add(textBox1);
            panel.Location = new Point(50, 506);
            panel.Margin = new Padding(50, 3, 3, 3);
            panel.Name = "textBox1";
            panel.Size = new Size(1280, 600);
            panel.MaximumSize = new Size(1183, 2000);
            //panel.AutoScroll = true;
            panel.BackColor = Color.Transparent;
            panel.ForeColor = Color.White;
            
            
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new Point(450, 929);
            label2.Margin = new Padding(100, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.Text = "Источник: ";
            label2.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;

            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Location = new Point(523, 929);
            label3.Margin = new Padding(20, 5, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = character.getLink();
            label3.Font = new Font("Segoe Print", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Yellow;

            characterInfoPanel.Controls.Add(icon);
            characterInfoPanel.Controls.Add(screen);
            characterInfoPanel.Controls.Add(label1);
            characterInfoPanel.Controls.Add(panel);
            characterInfoPanel.Controls.Add(label2);
            characterInfoPanel.Controls.Add(label3);
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
        public void setCatalogLocation() //Распределяет игры и фильмы в их каталоги, добавить сюда новый каталог в будущем
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
                        panel = gameCatalogPanel; current_index = 0;  break;
                       
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
                button.Click += CharacterInGamesClick;
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
            string catalog_list = "catalog_list.txt";
            string properties = "";
            List<string> propertiesList = new List<string>(); //строки из файла со списком игр или фильмов
            StreamReader reader = new StreamReader(folder+"catalog_list.txt");
            string icon_path = "";
            string parent_name = "";
            string type = "";
            while (!reader.EndOfStream)
            {
                properties = @reader.ReadLine();

                icon_path = properties.Split()[0];
                parent_name = properties.Split()[1];
                type= properties.Split()[2];
                Catalog catalog = new Catalog();
                catalog.setIcon(icon_path);
                catalog.setName(parent_name);
                catalog.setType(type);
                catalogs.Add(catalog);
            }
        }
        private void InitPanelsInformation(string folder, string catalog_list, Panel panel)
        //Добавление фильмов или игр
        {
            string properties = "";
            List<string> propertiesList = new List<string>(); //строки из файла со списком игр или фильмов
            StreamReader reader = new StreamReader(folder + catalog_list);
            propertiesList.Clear();
            while (!reader.EndOfStream)
            {
                properties = reader.ReadLine();
                propertiesList.Add(properties);
            }
            reader.Close();
            if (propertiesList.Count == 0)
            {
                return;
            }
            int moveX = 0;
            int moveY = 0;    
            }
        private void CharacterInGamesClick(object? sender, EventArgs e)
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
            switch (current_panel)
            {
                case "GamePanel":
                    GamesButton.Visible = true;
                    FilmsButton.Visible = true;
                    gameCatalogPanel.Visible = false;
                    current_panel = "Main";
                    break;
                case "FilmsPanel":
                    GamesButton.Visible = true;
                    FilmsButton.Visible = true;
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
                    CharactersPanel.Visible = true;
                    characterInfoPanel.Visible = false;
                    current_panel = "characters";
                    last_catalog = last_catalog2;
                    break;
            }
        }

        private void PanelsInit()
        {
            gameCatalogPanel = new myPanel();
            gameCatalogPanel.Location = new Point(0, 70);
            gameCatalogPanel.Size = new Size(1280, 600);
            gameCatalogPanel.Name = "GamePanel";
            gameCatalogPanel.Visible = false;
            gameCatalogPanel.BackColor = Color.White;
            gameCatalogPanel.BackColor = Color.Transparent;
            gameCatalogPanel.AutoScroll = true;

            filmsCatalogPanel = new myPanel();
            filmsCatalogPanel.Location = new Point(0, 70);
            filmsCatalogPanel.Size = new Size(1280, 600);
            filmsCatalogPanel.Name = "FilmsPanel";
            filmsCatalogPanel.Visible = false;
            filmsCatalogPanel.BackColor = Color.White;
            filmsCatalogPanel.BackColor = Color.Transparent;
            filmsCatalogPanel.AutoScroll = true;

            CharactersPanel = new myPanel();
            CharactersPanel.Location = new Point(0, 70);
            CharactersPanel.Size = new Size(1280, 600);
            CharactersPanel.Name = "CharacterPanel";
            CharactersPanel.Visible = false;
            CharactersPanel.BackColor = Color.White;
            CharactersPanel.BackColor = Color.Transparent;
            CharactersPanel.AutoScroll = true;
            CharactersPanel.AutoSize = true;
            

            characterInfoPanel = new myLayoutPanel();
            characterInfoPanel.Location = new Point(0, 70);
            characterInfoPanel.Size = new Size(1280, 600);
            characterInfoPanel.Name = "CharacterPanel";
            characterInfoPanel.Visible = false;
            characterInfoPanel.BackColor = Color.White;
            characterInfoPanel.BackColor = Color.Transparent;
            characterInfoPanel.AutoScroll = true;

            Controls.Add(gameCatalogPanel);
            Controls.Add(filmsCatalogPanel);
            Controls.Add(CharactersPanel);
            Controls.Add(characterInfoPanel);
        }

        private void GamesButton_Click(object sender, EventArgs e)
        {
            GamesButton.Visible = false;
            FilmsButton.Visible = false;
            gameCatalogPanel.Visible = true;
            current_panel = gameCatalogPanel.Name;
        }

        private void FilmsButton_Click(object sender, EventArgs e)
        {
            GamesButton.Visible = false;
            FilmsButton.Visible = false;
            filmsCatalogPanel.Visible = true;
            current_panel = filmsCatalogPanel.Name;
        }

        // [DllImport("user32.dll", SetLastError = true)]
        // private static extern bool LockWindowUpdate(IntPtr hWnd);

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
            //cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
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
            // Change SB_THUMBTRACK to SB_THUMBPOSITION
            m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
        }
        base.WndProc(ref m);
    }
}

public partial class myLayoutPanel : FlowLayoutPanel
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
            //cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
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
            // Change SB_THUMBTRACK to SB_THUMBPOSITION
            m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
        }
        base.WndProc(ref m);
    }


}