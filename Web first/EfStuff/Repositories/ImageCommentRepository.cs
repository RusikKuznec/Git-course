using System.Collections.Generic;
using System.Linq;
using Web_first.EfStuff.DbModel;

namespace Web_first.EfStuff.Repositories
{
    public class ImageCommentRepository : BaseRepository<ImageComment>
    {

        public ImageCommentRepository(WebContext webContext) : base(webContext)
        {           
        }


    }
}
