using System.Collections.Generic;
using System.Linq;
using Web_first.EfStuff.DbModel;

namespace Web_first.EfStuff.Repositories
{
    public class ImageRepository
    {
        private WebContext _webContext;

        public ImageRepository(WebContext webContext)
        {
            _webContext = webContext;
        }

        public List<Image> GetAll()
        {
            return _webContext.Images.ToList();
        }

        public Image Get(int id)
        {
            return _webContext.Images.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Image dbImage)
        {
            _webContext.Add(dbImage);
            _webContext.SaveChanges();
        }








    }
}
