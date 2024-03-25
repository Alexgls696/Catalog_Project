
namespace Game_Catalog_Project
{
    internal class Catalog
    {
        private string icon;
        private string name; //Родитель для игр
        private string type;
        public Catalog() { 

        }

        public Catalog(string icon, string name, string type)
        {
            this.icon = icon;
            this.name = name;
            this.type = type;
        }

        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return this.type;
        }

        public void setIcon(string icon)
        {
            this.icon = icon;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public string getIcon() { 
            return this.icon;
        }

    }
}
