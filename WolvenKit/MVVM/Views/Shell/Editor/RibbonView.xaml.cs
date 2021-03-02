using System.ComponentModel;
using Catel.IoC;
using Fluent;
using Orchestra;
using Orchestra.Services;
using System.Windows;
using Catel;
using Catel.Data;
using WolvenKit.Views.AssetBrowser;
using WolvenKit.Views.CodeEditor;
using WolvenKit.Views.PluginManager;
using WolvenKit.Views.VisualEditor;
using WolvenKit.Views.AudioTool;
using WolvenKit.Views.JournalEditor;
using Orchestra.Views;
using System.Windows.Media;
using ControlzEx.Theming;

namespace WolvenKit.Views
{
    public partial class RibbonView
    {
        public RibbonView()
        {
            InitializeComponent();

            ribbon.AddAboutButton();

            WKitGlobal.StaticReferences.RibbonViewInstance = this;
           
        }

        protected override void OnViewModelChanged()
        {
            base.OnViewModelChanged();
#pragma warning disable WPF0041
            //backstageTabControl.DataContext = ViewModel;
#pragma warning restore WPF0041
        }

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);

            if (!(e is AdvancedPropertyChangedEventArgs property))
                return;

            switch (property.PropertyName)
            {
                case "SelectedTheme":
                    if (property.NewValue is Color themename)
                    {
                        //wtf is this even
                
                    }




                    break;
                default:
                    break;
            }
        }

        private void ShowStartScreen_OnClick(object sender, RoutedEventArgs e) // Convert me to MVVM
        {        
            // Nope we dont do that here . And I am not removing this >:) lol
        }

       

     

        private void CBAssetBrowserItem_Selected(object sender, RoutedEventArgs e)
        {
     
        }

        private void CBCodeEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            CodeEditorView codeeditor = new CodeEditorView();
        }

        private void CBPluginManager_Selected(object sender, RoutedEventArgs e)
        {
            PluginManagerView pluginmanager = new PluginManagerView();
        }

        private void CBVisualEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            VisualEditorView visualeditor = new VisualEditorView();
        }

        private void CBAudioToolItem_Selected(object sender, RoutedEventArgs e)
        {
            AudioToolView audiotool = new AudioToolView();
        }

        private void CBJournalEditorItem_Selected(object sender, RoutedEventArgs e)
        {
          //  JournalEditorView journaleditor = new JournalEditorView();
         //   journaleditor.Show();
        }

        private void Backstage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            var serviceLocator = ServiceLocator.Default;

            var shellService = serviceLocator.ResolveType<IShellService>();



            WKitGlobal.StaticReferences.GlobalShell.DragMove();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible && IsLoaded)
            {
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Ribbon/Backstage");
            }
        }

        private void Border_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var brush = (Brush)App.Current.FindResource("MahApps.Brushes.Accent3");

            HomeHighLighter.SetCurrentValue(System.Windows.Controls.Panel.BackgroundProperty, brush);
        }

        private void Border_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var brush = (Brush)App.Current.FindResource("MahApps.Brushes.AccentBase");

            HomeHighLighter.SetCurrentValue(System.Windows.Controls.Panel.BackgroundProperty, brush);

        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {


            WKitGlobal.StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(StartScreen.ShownProperty, false);
            WKitGlobal.StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Backstage.IsOpenProperty, true);
        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            // No
        }
    }
}