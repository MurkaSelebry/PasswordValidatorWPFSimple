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
using Xceed.Wpf.Toolkit;

namespace PasswordValidatorWPFSimple
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IntegerUpDown integerUpDown = new IntegerUpDown();
            Stack1.Children.Insert(5,integerUpDown);
            integerUpDown.Minimum = 6;
            integerUpDown.Maximum = 255;
            integerUpDown.Watermark = "Unlimited";
            integerUpDown.ValueChanged += new RoutedPropertyChangedEventHandler<object>(integerUpDown_ValueChanged);
        }


        private void integerUpDown_ValueChanged(object sender, EventArgs e)
        {
            var integerUpDown = Stack1.Children[5] as IntegerUpDown;
            if(integerUpDown.Value != null)
            {
                pswdBox.MaxLength = integerUpDown.Value.Value;
                (Stack1.Children[7] as Label).Content = integerUpDown.Value.ToString();
            }
            else
            {
                integerUpDown.Watermark = "Unlimited";
                (Stack1.Children[7] as Label).Content = "Unlimited";
                pswdBox.MaxLength = 0;
            }

        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            scratchTB.SelectAll();
            scratchTB.Copy();

        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            pswdBox.Paste();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            pswdBox.Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pswdBox.PasswordChar = Convert.ToChar((sender as ComboBox).SelectedItem);
        }

        private void pswdBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            (Stack1.Children[1] as Label).Content = Convert.ToInt32((Stack1.Children[1] as Label).Content) + 1;
 
        }
    }
}
