using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Teacher> _data;

        
        public MainWindow()
        {
            InitializeComponent();
            _data = new ObservableCollection<Teacher>();

            dt_grid.ItemsSource = _data;

            var newwindows = new Window1();

            newwindows.ShowDialog();
            var new_object = newwindows.GetNewObject();

            _data.Add(new_object);
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            var s = (e.OriginalSource as Button).DataContext;
            Teacher current = (Teacher)s;
            _data.Remove(current);
            //_data.Remove((Teacher)dt_grid.SelectedItem);

        }
        public class Teacher

        {
            public string Name { get; set; }
            public string ContactNumber { get; set; }
        }
    }
}
