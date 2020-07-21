using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Multimedia
    {
        public enum MediaType
        {
            CD,
            DVD
        };

        public string _title { get; set; }
        public string _artist { get; set; }
        public string _genre { get; set; }
        public MediaType _type { get; set; }
    }
}
