namespace FFImageLoading.Forms.Sample
{
    public class SimpleWebpPageModel : BasePageModel
    {
        public SimpleWebpPageModel()
        {
            Reload();
        }

        public override void Reload()
        {
            ImageUrl = "https://www.gstatic.com/webp/gallery/1.sm.webp";
        }

        public string ImageUrl { get; set; }
    }
}
