using MediaDAL;
using MediaServiceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServiceLib.Service
{
    public interface IMediaService
    {
        MediaListModel GetAllMedia();
        MediaModel GetMediaById(int id);
        MediaListModel GetMediaByCategory(MediaModel model);
        MediaListModel GetMediaByType(MediaModel model);
    }
}
