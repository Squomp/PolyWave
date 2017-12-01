using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServiceLib.Models
{
    public class MediaListModel
    {
        public List<MediaModel> MediaList { get; set; }

        public MediaListModel()
        {
            MediaList = new List<MediaModel>();
        }
    }
}
