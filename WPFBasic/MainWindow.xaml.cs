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

namespace WPFBasic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] inputTextSplit;
        string[] inputReverse;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SplitButtonClick(object sender, RoutedEventArgs e)
        {
            inputTextSplit = inputSplitText.Text.Split(' ');
            foreach (string word in inputTextSplit)
            {
                splitResultBox.Items.Add(word);
            }            
        }

        private void ReverseButtonClick(object sender, RoutedEventArgs e)
        {
            inputReverse = inputReverseText.Text.Split(' ');

            StringBuilder sb = new StringBuilder();
            foreach (var word in inputReverse.Reverse())
            {
                sb.Append($"{word} ");
            }

            reverseTextBlock.Text = sb.ToString();
        }
    }
}
