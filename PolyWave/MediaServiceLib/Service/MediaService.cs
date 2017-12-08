using MediaDAL;
using MediaServiceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServiceLib.Service
{
    public class MediaService
    {
        public MediaListModel GetAllMedia()
        {
            MediaListModel model = new MediaListModel();
            using (var db = new MediaEntities())
            {
                var query = db.Media.Select(x => x);
                var bikeList = query.ToList();

                bikeList.ForEach(x =>
                    model.MediaList.Add(
                            new MediaModel()
                            {
                                Id = x.Id,
                                Author = x.Author,
                                Caption = x.Caption,
                                Description = x.Description,
                                Path = x.Path,
                                Type = (MediaType)Enum.Parse(typeof(MediaType), x.Type),
                                Category = (MediaCategory)Enum.Parse(typeof(MediaCategory), x.Category)
                            }
                        )
                );
            }
            return model;
        }

        public MediaModel GetMediaById(int id)
        {
            return GetAllMedia().MediaList.Where(x => x.Id == id).First();
        }

        public MediaListModel GetMediaByCategory(string category)
        {
            MediaListModel newModel = new MediaListModel();
            using (var db = new MediaEntities())
            {
                var query = db.Media.Where(x => x.Category == category);

                var mediaSearch = query.ToList();

                mediaSearch.ForEach(media =>
                {
                    newModel.MediaList.Add(
                        new MediaModel()
                        {
                            Id = media.Id,
                            Author = media.Author,
                            Path = media.Path,
                            Caption = media.Caption,
                            Description = media.Description
                        });
                });
            }

            return newModel;
        }

        public MediaListModel GetMediaByType(string type)
        {
            MediaListModel newModel = new MediaListModel();
            using (var db = new MediaEntities())
            {
                var query = db.Media.Where(x => x.Type == type);

                var mediaSearch = query.ToList();

                mediaSearch.ForEach(media =>
                {
                    newModel.MediaList.Add(
                        new MediaModel()
                        {
                            Id = media.Id,
                            Author = media.Author,
                            Path = media.Path,
                            Caption = media.Caption,
                            Description = media.Description
                        });
                });
            }

            return newModel;
        }
    }
}
