using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using FFImageLoading.Forms.Sample.Pages;
using FFImageLoading.Forms.Sample.Pages.Transformations;
using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{

    public class MenuPageModel : BasePageModel
    {
        public MenuPageModel()
        {
            ItemSelectedCommand = new Command<SelectedItemChangedEventArgs>((arg) =>
            {
                SelectedItem = null;
            });

            var menuItems = new List<MenuItem>()
            {
                new MenuItem() {
                    Section = "Basic",
                    Title = "Basic example",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new BasicPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Basic",
                    Title = "Placeholders examples",
                    Command = new Command(async(param) =>
                    {
                        await PushAsync(() => new PlaceholdersPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Lists",
                    Title = "List example",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new ListPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Lists",
                    Title = "List transformations example",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new ListTransformationsPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Lists",
                    Title = "Heavy List example",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new ListHeavyPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Lists",
                    Title = "ByteArray / custom cache key example",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new ByteArrayListPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Advanced",
                    Title = "Exif tests",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new ExifPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Advanced",
                    Title = "Custom CacheKey example",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new CustomKeyPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Advanced",
                    Title = "Stream from base64 data",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new StreamListPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Advanced",
                    Title = "Data url examples",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new DataUrlPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Advanced",
                    Title = "CachedImage sizing test",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new CachedImageSizingTestPageModel());
                    })
                },

                //new MenuItem() {
                //	Section = "Advanced",
                //	Title = "Stream with custom cache key example",
                //	Command = new Command((param) =>
                //	{
                //		//TODO
                //	})
                //},

                new MenuItem() {
                    Section = "Transformations",
                    Title = "ColorFillTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new ColorFillTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "CropTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new CropTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "RotateTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new RotateTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "CircleTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new CircleTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "RoundedTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new RoundedTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "CornersTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new CornersTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "GrayscaleTransformation",
                    Command = new Command(async (param) =>
                    {
                        await PushAsync(() => new GrayscaleTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "BlurredTransformation",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new BlurredTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "SepiaTransformation",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new SepiaTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "ColorSpaceTransformation",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new ColorSpaceTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "TintTransformation",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new TintTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "FlipTransformation",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new FlipTransformationPageModel());
                    })
                },

                new MenuItem() {
                    Section = "Transformations",
                    Title = "Multiple transformations example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new MultipleTransformationsPageModel());
                    })
                },

                new MenuItem()
                {
                    Section = "Transformations",
                    Title = "Transformations selector example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new TransformationsSelectorPageModel());
                    })

                },

                new MenuItem() {
                    Section = "File formats",
                    Title = "Simple SVG example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new SvgSamplePageModel());
                    })
                },

                new MenuItem() {
                    Section = "File formats",
                    Title = "Heavy SVG List example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new SvgListHeavyPageModel());
                    })
                },

                new MenuItem() {
                    Section = "File formats",
                    Title = "SVG replace map example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new SvgReplacePageModel());
                    })
                },

                new MenuItem()
                {
                    Section = "File formats",
                    Title = "Simple Gif example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new SimpleGifPageModel());
                    })

                },

                new MenuItem()
                {
                    Section = "File formats",
                    Title = "Simple WebP example",
                    Command = new Command(async (param) =>
                    {
                        await this.PushAsync(() => new SimpleWebpPageModel());
                    })

                },
            };

            var sorted = menuItems
                .GroupBy(item => item.Section)
                .Select(itemGroup => new Grouping<string, MenuItem>(itemGroup.Key, itemGroup));

            Items = new ObservableCollection<Grouping<string, MenuItem>>(sorted);
        }

        public ObservableCollection<Grouping<string, MenuItem>> Items { get; set; }

        public MenuItem SelectedItem { get; set; }

        public ICommand ItemSelectedCommand { get; set; }

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Items.Add(item);
            }
        }


        public class MenuItem : BaseModel
        {
            public string Section { get; set; }

            public string Title { get; set; }

            public string Details { get; set; }

            public ICommand Command { get; set; }
        }
    }
}
