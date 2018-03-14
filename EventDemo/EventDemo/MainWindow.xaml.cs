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

namespace EventDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person;

        public MainWindow()
        {
            InitializeComponent();
            person = new Person();
            person.ChangeNameEvent += Person_ChangeNameEvent;
        }

        private void Person_ChangeNameEvent()
        {
            button1.Content = person.Name;
            Console.WriteLine("事件触发");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "Xiaobolo";
        }
    }
}
