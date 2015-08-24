using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace HeyOfertasWC.Models
{
    
    public class Deals
    {
        
        private string sdess;

        public String _id { get; set; }

        public String url { get; set; }

        public string picture { get; set; }

        public string description { get; set; }

        public int originalPrice { get; set; }

        public int discountedPrice { get; set; }

        
        public Source source { get; set; }

    
        public bool active { get; set; }

    
        public  int __v { get; set; }

    
        public string sdes {
            get { return ""; }
            set { this.sdess = value; }
        }
    }

    
    public class Source
    {

        public String name { get; set; }
        public String url { get; set; }
        
    }
}
