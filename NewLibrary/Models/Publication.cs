using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public int Id_book { get; set; }
        public int Id_publisher { get; set; }
        public int Yearofpublication { get; set; }
        public string Placeofpublication { get; set; }

        public Publication()
        {

        }
        public Publication(int id,int id_book, int id_publisher, int yearofpublication, string place)
        {
            Id = id;
            Id_book = id_book;
            Id_publisher = id_publisher;
            Yearofpublication = yearofpublication;
            Placeofpublication = place;
        }
    }

}
