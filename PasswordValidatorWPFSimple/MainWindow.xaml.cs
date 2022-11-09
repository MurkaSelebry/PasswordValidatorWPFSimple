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
            integerUpDown.TextInput += new TextCompositionEventHandler(text_changed);
           
            

        }

        private void text_changed(object sender, TextCompositionEventArgs e)
        {
            System.Windows.MessageBox.Show("123");
        }

        private void integerUpDown_ValueChanged(object sender, EventArgs e)
        {
            var integerUpDown = Stack1.Children[5] as IntegerUpDown;
            
            if(integerUpDown.Value != null)
            {
                System.Windows.MessageBox.Show("123");
            }
            else
            {
                
            }
        }
    }
}
