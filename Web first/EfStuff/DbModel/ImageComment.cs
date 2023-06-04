namespace Web_first.EfStuff.DbModel
{
    public class ImageComment : BaseDbModel
    {
        
        public string Comment { get; set; }
        public virtual  Image Image { get; set; }
    }
}
