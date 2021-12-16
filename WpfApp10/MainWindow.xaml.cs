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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButtonClick(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WindowContentRendered(object sender, EventArgs e)
        {
            this.Title = Properties.Settings.Default.WindowTitle;
            nameText.Text = Properties.Settings.Default.UserName;
            ageText.Text = Properties.Settings.Default.Age.ToString();
            Blood.SelectedIndex = Properties.Settings.Default.Blood;
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = nameText.Text;
            Properties.Settings.Default.Age = int.Parse(ageText.Text);
            Properties.Settings.Default.Blood = Blood.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }
}