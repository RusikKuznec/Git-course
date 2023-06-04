using System.Collections.Generic;


namespace Web_first.Models
{
    public class ImageUrlIndexViewModel 
    {
       public int Id { get; set; }
        public string Url { get; set; }
        public List<string> Comments { get; set; }
    }
}
