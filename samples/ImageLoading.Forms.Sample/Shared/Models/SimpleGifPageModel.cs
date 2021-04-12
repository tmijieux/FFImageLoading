namespace FFImageLoading.Forms.Sample
{

    public class SimpleGifPageModel : BasePageModel
    {
        public SimpleGifPageModel()
        {
            Reload();
        }

        public override void Reload()
        {
            ImageUrl = "resource://tenor.gif";
        }

        public string ImageUrl { get; set; }
    }
}
