using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApi.Models
{
    public class Japan
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Armenia
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Uruguay
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Australia
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Argentina
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Paraguay
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Kazakhstan
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Country
    {
        public Japan Japan { get; set; }
        public Armenia Armenia { get; set; }
        public Uruguay Uruguay { get; set; }
        public Australia Australia { get; set; }
        public Argentina Argentina { get; set; }
        public Paraguay Paraguay { get; set; }
        public Kazakhstan Kazakhstan { get; set; }
    }
}
