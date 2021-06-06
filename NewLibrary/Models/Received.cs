using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    public class Received
    {
        public int Profile_Id { get; set; }
        public int Publication_Id { get; set; }
        public int BookRental { get; set; }
        public string DateReturn { get; set; }
        public Received()
        {

        }
        public Received(int ProfileId, int PublicationId,int bookrental,string datereturt)
        {
            Profile_Id = ProfileId;
            Publication_Id = PublicationId;
            BookRental = bookrental;
            DateReturn = datereturt;
        }
    }
}
