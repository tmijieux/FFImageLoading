using System.Collections.Generic;
using FFImageLoading.Transformations;
using FFImageLoading.Extensions;

using FFImageLoading.Work;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Simple.Universal.Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        List<ITransformation> transformationsBin1 = new List<ITransformation>()
        {
            new GrayscaleTransformation(),
            new CircleTransformation(),
        };

        List<ITransformation> transformationsBin2 = new List<ITransformation>()
        {
            new RotateTransformation(45),
        };

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //MyImage.Transformations = transformationsBin1;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //MyImage.Transformations = transformationsBin2;
        }
    }
}
