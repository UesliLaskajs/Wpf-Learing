using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Button button=new Button();//Created A button Class 

            button.Content = "B";//Added Content to Button

            Grid.SetColumn(button, 4);//Set Position
            Grid.SetRow(button, 3);

            Grid grid = (Grid)FindName("myGrid");//Found The Grid By Name On Xaml
            grid.Children.Add(button);//Added Grid

            
        }

        public void ClickEvent(object sender, RoutedEventArgs e)//Created an Event Method With the Name same as in Click On Xaml
        {
            MessageBox.Show("Button Clicked");
        }
    }
}