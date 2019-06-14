using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrlMvc.Models
{
    public class ShortUrl
    {
        public int ID { get; set; }
        public string Prefix { get; set; }   
        public string Postfix { get; set; }
        public string LongUrlID { get; set; }
        public LongUrl LongUrl { get; set; }
    }
}
