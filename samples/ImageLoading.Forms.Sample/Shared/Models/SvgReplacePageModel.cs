﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using FFImageLoading.Svg.Forms;
using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public class SvgReplacePageModel : BasePageModel
    {
        private Random _random = new Random();

        public SvgReplacePageModel()
        {
            ReplaceCommand =new Command(() =>
            {

                var r = _random.Next(256);
                var g = _random.Next(256);
                var b = _random.Next(256);

                ReplaceMap = new Dictionary<string, string>()
                {
                    { "#TEXT", Guid.NewGuid().ToString() },
                    { "#FILLCOLOR", $"#{r:X2}{g:X2}{b:X2}" }
                };

                ImageSource = SvgImageSource.FromResource("FFImageLoading.Forms.Sample.Resources.replace.svg",
                                                          replaceStringMap: ReplaceMap);
            });

            ReplaceCommand.Execute(null);
        }

        public Dictionary<string, string> ReplaceMap { get; set; }

        public ICommand ReplaceCommand { get; set; }

        public ImageSource ImageSource { get; set; }
    }
}
