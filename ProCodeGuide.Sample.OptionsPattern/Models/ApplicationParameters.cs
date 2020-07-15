using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.OptionsPattern.Models
{
    public class ApplicationParameters
    {
        public string SQLServerConnection { get; set; }
        public string EmailServer { get; set; }
        public string ServiceURL { get; set; }
        public long MaxLimitUsers { get; set; }
    }
}
