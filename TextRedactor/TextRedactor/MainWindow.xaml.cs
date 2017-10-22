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

namespace TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string buffer;
        private int selectionStart;
        private int selectionLenght;
        private string selectedText;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            selectionStart = textTextBox.SelectionStart;
            selectionLenght = textTextBox.SelectionLength;
            selectedText = textTextBox.SelectedText;
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            buffer = selectedText;
        }

        private void CutButton_Click(object sender, RoutedEventArgs e)
        {
            buffer = selectedText;
            textTextBox.Text = textTextBox.Text.Remove(selectionStart, selectionLenght);
            
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            textTextBox.Text = textTextBox.Text.Insert(selectionStart, buffer);
        }

    }
}