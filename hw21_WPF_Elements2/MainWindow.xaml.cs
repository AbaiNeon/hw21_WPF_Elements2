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

namespace hw21_WPF_Elements2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string buffer;
        private int position;
        public MainWindow()
        {
            InitializeComponent();
            buffer = "";
        }

        private void CopyButtonClick(object sender, RoutedEventArgs e)
        {
            buffer = textBox.SelectedText;
            position = textBox.CaretIndex;
        }

        private void CutButtonClick(object sender, RoutedEventArgs e)
        {
            buffer = textBox.SelectedText;
            if (buffer.Length != 0)
            {
                textBox.Text = textBox.Text.Replace(buffer, "");    
            }
        }

        private void PasteButtonClick(object sender, RoutedEventArgs e)
        {
            position = textBox.CaretIndex;
            textBox.Text = textBox.Text.Insert(position, buffer);
        }
    }
}
