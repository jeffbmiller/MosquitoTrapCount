using System;
using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public class MenuItem
    {
        public MenuItem(string title, Color backgroundColor, string image)
        {
            this.Title = title;
            this.BackgroundColor = backgroundColor;
            this.Image = image;
        }

        public string Image { get; set;}
        public string Title { get; set; }
        public Color BackgroundColor { get; set; }
    }
}

