using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfThemesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> styles = new() { "light", "dark" };
            listStyles.ItemsSource = styles;
            listStyles.SelectedItem = "light";
        }

        private void listStyles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string style = listStyles.SelectedItem as string;
            var path = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resource = Application.LoadComponent(path) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }
    }
}
