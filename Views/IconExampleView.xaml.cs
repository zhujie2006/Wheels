using System;
using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Wheels.Models;

namespace Wheels.Views
{
    /// <summary>
    /// Example of icon8
    /// </summary>
    public partial class IconExampleView : UserControl
    {
        public IconExampleView()
        {
            InitializeComponent();
        }

        private void IconExampleView_OnLoaded(object sender, RoutedEventArgs e)
        {
            var dict = new ResourceDictionary { Source = new Uri("/Wheels;component/Themes/Icons8.xaml", UriKind.RelativeOrAbsolute) };
            var icons = dict
                .OfType<DictionaryEntry>()
                .Where(de => de.Value is Geometry)
                .Select(de => new IconModel((string)de.Key, (Geometry)de.Value))
                .OrderBy(mi => mi.IconKey)
                .ToList();

            IconsControl.ItemsSource = icons;
        }
    }
}
