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

namespace Lesson12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public EventHandler AddEvent = null;
        public EventHandler SubEvent = null;
        public EventHandler MulEvent = null;
        public EventHandler DivEvent = null;

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            AddEvent.Invoke(sender, e);
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            SubEvent.Invoke(sender, e);
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            MulEvent.Invoke(sender, e);
        }

        private void DevButton_Click(object sender, RoutedEventArgs e)
        {
            DivEvent.Invoke(sender, e);
        }
    }
}
