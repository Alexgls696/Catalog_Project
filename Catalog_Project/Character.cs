using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Catalog_Project
{
    internal class Character
    {
        private string photo;
        private string name;
        private string screen;
        private string biography;
        private string link;
        private string parent_name; //Название игры или фильма, где находится данный персонаж.

        public Character(string name, string biography, string link, string parent_name, string photo, string screen)
        {
            this.photo = photo;
            this.name = name;
            this.screen = screen;
            this.biography = biography;
            this.link = link;
            this.parent_name = parent_name;
        }

        public Character()
        {
            
        }

        public string Photo()
        {
            return photo;
        }

        public string Screen()
        {
            return screen;
        }

        public void setPhoto(string photo)
        {
            this.photo = photo;
        }

        public void setScreen(string screen)
        {
            this.screen = screen;
        }

        public string getName()
        {
            return name;
        }

        public string getBiography()
        {
            return biography;
        }

        public string getLink()
        {
            return link;
        }

        public string getParentName() { 
            return parent_name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setLink(string link)
        {
            this.link = link;
        }

        public void setBiography(string biography)
        {
            this.biography = biography;
        }

        public void setParentName(string parent_name)
        {
            this.parent_name = parent_name;
        }

        
    }
}
