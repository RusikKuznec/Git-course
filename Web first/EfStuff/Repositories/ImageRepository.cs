
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Web_first.EfStuff.DbModel;

namespace Web_first.EfStuff.Repositories
{
    public class ImageRepository : BaseRepository<Image>
    {
        

        public ImageRepository(WebContext webContext) : base(webContext)
        {
           
        }


    }
}
