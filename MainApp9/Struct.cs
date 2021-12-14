using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp9
{
    public struct Book
    {
        public string Author { get; set; }
        public string Copyright { get; set; }
        public string Title { get; set; }
        public string Lists { get; set; }

        public Book(string author, string copyright, string title, string lists) //конструктор для упрощения
        {
            {
                Author = author;
                Copyright = copyright;
                Title = title;
                Lists = lists;
            }
        }      
    }
}
