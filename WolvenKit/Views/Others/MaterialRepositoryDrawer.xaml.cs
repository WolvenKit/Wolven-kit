using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Catel.IoC;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Services;

namespace WolvenKit.Views.Others
{
    /// <summary>
    /// Interaction logic for MaterialRepositoryDrawer.xaml
    /// </summary>
    public partial class MaterialRepositoryDrawer : UserControl
    {
        public static ObservableCollection<MatDepoItem> Folders { get; set; }
        public static string PreviousFolder { get; set; }

        public MaterialRepositoryDrawer()
        {
            InitializeComponent();

            // string rootPath = @"C:\Wolvenkit_Develop";
            // string rootPath = @"C:\Wolvenkit_Develop";
            Folders = new ObservableCollection<MatDepoItem>();

            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            if (!string.IsNullOrEmpty(settings.MaterialRepositoryPath))
            {
                PreviousFolder = settings.MaterialRepositoryPath;
                GetFolders(PreviousFolder);
            }

            // ImageSources = GetDirFiles(rootPath);
            DataContext = this;
        }

        private async void GetDirFiles(string dir)
        {
            x.Items.Clear();
            var allfiles = Directory.GetFiles(dir, "*.dds", SearchOption.TopDirectoryOnly);
            var alltgafiles = Directory.GetFiles(dir, "*.tga", SearchOption.TopDirectoryOnly);

            string[] combined = allfiles.Concat(alltgafiles).ToArray();

            foreach (var z in combined)
            {
                if (z.Contains(".dds"))
                {
                    ListBoxItem listBoxItem = new ListBoxItem();

                    StackPanel stackPanel = new StackPanel();
                    Image image = new Image();
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = Path.GetFileNameWithoutExtension(z);
                    textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                    var q = await ImageDecoder.RenderToBitmapSource(z);
                    image.Width = 50;
                    image.Height = 50;
                    image.Margin = new System.Windows.Thickness(5);
                    image.Source = q;
                    listBoxItem.Tag = z;
                    listBoxItem.MouseDown += Image_MouseDown;

                    stackPanel.Orientation = Orientation.Horizontal;
                    stackPanel.Children.Add(image);
                    stackPanel.Children.Add(textBlock);
                    listBoxItem.Content = stackPanel;
                    x.Items.Add(listBoxItem);

                    // MaterialRepositoryDrawer.ImageSources.Add(newitem);
                }
            }
        }

        private async void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var q = sender as ListBoxItem;
            var bmpsource = await ImageDecoder.RenderToBitmapSource(q.Tag.ToString());

            LoadImage(bmpsource);
        }

        private void GetFolders(string dir)
        {
            if (!Directory.Exists(dir))
            {
                return;
            }

            Folders.Clear();
            var dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
            MatDepoItem newitem = new MatDepoItem(PreviousFolder);
            MaterialRepositoryDrawer.Folders.Add(newitem);
            foreach (var z in dirs)
            {
                MatDepoItem newitem2 = new MatDepoItem(z);
                MaterialRepositoryDrawer.Folders.Add(newitem2);
            }

            GetDirFiles(dir);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Henry.SelectedItem != null)
            {
                var qa = Henry.SelectedItem as MatDepoItem;

                GetFolders(@"" + qa.FullName);
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private async void x_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (x.SelectedItem != null)
            {
                var qa = x.SelectedItem as ListBoxItem;
                try
                {
                    var q = await ImageDecoder.RenderToBitmapSource(qa.Tag.ToString());
                    LoadImage(q);
                }
                catch
                {
                }
            }
        }

        private Stream StreamFromBitmapSource(BitmapSource writeBmp)
        {
            Stream bmp = new MemoryStream();

            BitmapEncoder enc = new BmpBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(writeBmp));
            enc.Save(bmp);

            return bmp;
        }

        public void LoadImage(BitmapSource qa) => bold.SetCurrentValue(Syncfusion.UI.Xaml.ImageEditor.SfImageEditor.ImageProperty, (System.IO.Stream)StreamFromBitmapSource(qa));

        public class MatDepoItem
        {
            public MatDepoItem(string fullname)

            {
                FullName = fullname;
            }

            public string FullName { get; set; }

            public string SafeName
            {
                get
                {
                    return Path.GetFileName(FullName);
                }
            }

            public string Extension
            {
                get
                {
                    return Path.GetExtension(FullName);
                }
            }
        }
    }
}
