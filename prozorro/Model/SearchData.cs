using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prozorro.Model
{
    public class SearchData
    {
        //field for search
        public string search;

        //constructor 
        public SearchData(string search)
        {
            this.search = search;
        }

        //property for search
        public string Search { get; set; }
    }
}
