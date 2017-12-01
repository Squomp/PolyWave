using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServiceLib.Models
{
    public class MediaModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public MediaType Type { get; set; }
        public MediaCategory Category { get; set; }
    }
}
