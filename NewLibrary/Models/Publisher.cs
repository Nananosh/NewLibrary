using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Publisher_Name { get; set; }
        
        public Publisher()
        {

        }
        public Publisher(int id, string namepublisher)
        {
            Id = id;
            Publisher_Name = namepublisher;
        }
    
    }
}
