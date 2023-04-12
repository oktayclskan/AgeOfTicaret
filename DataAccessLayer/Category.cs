using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Descripton { get; set; }
        public byte[] Picture { get; set; }
    }
}
