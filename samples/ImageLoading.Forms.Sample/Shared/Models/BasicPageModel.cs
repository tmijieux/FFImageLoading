namespace FFImageLoading.Forms.Sample
{
    public class BasicPageModel : BasePageModel
    {
        public BasicPageModel() { Reload(); }

        public override void Reload()
        {
            // ImageUrl = Helpers.GetRandomImageUrl();
            ImageUrl = @"https://raw.githubusercontent.com/recurser/exif-orientation-examples/master/Landscape_3.jpg";
        }

        public string ImageUrl { get; set; }
    }
}
