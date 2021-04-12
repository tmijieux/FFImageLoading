using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public partial class ListPageCell : ViewCell
    {
        public ListPageCell()
        {
            InitializeComponent();

            View.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command =new Command(() =>
                {
                    System.Diagnostics.Debug.WriteLine("TAPPED");
                })
            });
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = BindingContext as ListPageModel.ListItem;
            if (item == null)
                return;

            Image.Source = item.ImageUrl;
            Label.Text = item.FileName;
        }
    }
}
