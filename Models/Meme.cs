using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemeViewer.Models
{
    public class Meme
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int box_count { get; set; }
    }
}
