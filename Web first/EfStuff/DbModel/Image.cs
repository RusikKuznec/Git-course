using System.Collections.Generic;

namespace Web_first.EfStuff.DbModel
{
    public class Image: BaseDbModel
    {
        
        public string Name { get; set; }
        public string Url { get; set; }
        public int Rate { get; set; }
        public virtual List<ImageComment> Comments { get; set; }
    }
}
