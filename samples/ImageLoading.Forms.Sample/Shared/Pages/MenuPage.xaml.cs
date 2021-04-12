using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public partial class MenuPage : BasePage<MenuPageModel>
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new MenuPageModel();
        }
    }
}
