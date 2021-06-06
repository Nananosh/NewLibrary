using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public Author()
        {

        }
        public Author(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }
    }
}
