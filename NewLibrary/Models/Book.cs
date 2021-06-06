using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public int Number_of_pages { get; set; }

        public Book()
        {

        }
        public Book(int id,string name, int author,int genre, string image, int pages)
        {
            Id = id;
            Name = name;
            AuthorId = author;
            GenreId = genre;
            Image = image;
            Number_of_pages = pages;
        }
    }

}
