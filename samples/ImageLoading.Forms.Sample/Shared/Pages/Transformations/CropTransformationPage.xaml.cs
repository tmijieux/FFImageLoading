using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public partial class CropTransformationPage : BasePage<CropTransformationPageModel>
    {
        public CropTransformationPage()
        {
            InitializeComponent();
        }

        public void ReloadImage()
        {
            image.ReloadImage();
            image.LoadingPlaceholder = null;
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs args)
        {
            (BindingContext as CropTransformationPageModel)?.OnPanUpdated(args);
        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs args)
        {
            //this.GetPageModel().OnPinchUpdated(args);
            (BindingContext as CropTransformationPageModel)?.OnPinchUpdated(args);
        }
    }
}
