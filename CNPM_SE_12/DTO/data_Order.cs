using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SE_12.DTO
{
    public class data_Order
    {
        private string items_ID;
        private string items_Name;
        private int price;
        private int values;


        public data_Order()
        {

        }

        public string Items_ID { get => items_ID; set => items_ID = value; }
        public string Items_Name { get => items_Name; set => items_Name = value; }
        public int Price { get => price; set => price = value; }
        public int Values { get => values; set => values = value; }
    }
}
