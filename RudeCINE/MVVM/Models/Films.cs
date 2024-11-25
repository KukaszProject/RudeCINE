using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudeCINE.MVVM.Models
{
    public class Films
    {
        public string? Name { get; set; }
        public string? Hour { get; set; }
        public string? Image { get; set; }

        public string? Type { get; set; }

        public int Time { get; set; }
        public int AgeRestriction { get; set; }
    }
}
