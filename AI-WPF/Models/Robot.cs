using System;
using System.IO;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AI_WPF.Models
{
    public partial class Robot : ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _description;

        [ObservableProperty]
        private decimal _price;

        /// <summary>
        /// Relative path (under app base directory) to the preview image, e.g. "Images/robot1.png".
        /// </summary>
        [ObservableProperty]
        private string _imagePath;

        /// <summary>
        /// NOTE (profiler demo): This getter intentionally re-decodes the image from disk
        /// on every access. WPF may query it repeatedly during layout / virtualization,
        /// causing noticeable jank in the Catalogue. Fix during workshop: cache the
        /// BitmapImage in a backing field and Freeze() it, or bind to a pack URI in XAML.
        /// </summary>
        public BitmapImage PreviewImage
        {
            get
            {
                if (string.IsNullOrEmpty(ImagePath))
                {
                    return null;
                }

                var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ImagePath);
                if (!File.Exists(fullPath))
                {
                    return null;
                }

                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                image.UriSource = new Uri(fullPath, UriKind.Absolute);
                image.EndInit();
                return image;
            }
        }
    }
}
