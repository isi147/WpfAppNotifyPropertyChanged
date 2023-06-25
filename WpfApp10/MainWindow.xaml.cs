using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public Car Car { get; set; }
        public ObservableCollection<Car> Cars { get; set; }

        //DependencyProperty
        //Inotifypropertychanged

    //    private void akif([CallerMemberName] string propertyName = "")
    //=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
  

        }

        private string someText;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            product product = new product();
            product.Show();

        }

        //public string SomeText
        //{
        //    get { return someText; }
        //    set { someText = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SomeText)));
        //    }
        //}








        //Example1 autoproperty
        //public string SomeText { get; set; } = "Hakuna";



        //public int Size
        //{
        //    get { return (int)GetValue(SizeProperty); }
        //    set { SetValue(SizeProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Size.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SizeProperty =
        //    DependencyProperty.Register("Size", typeof(int), typeof(MainWindow));



        //public string SomeText
        //{
        //    get { return (string)GetValue(SomeTextProperty); }
        //    set { SetValue(SomeTextProperty, value); }
        //}

        // Using a DependencyProperty as the backing store for SomeText.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SomeTextProperty =
        //    DependencyProperty.Register("SomeText", typeof(string), typeof(MainWindow));





        //private void btn1_Click(object sender, RoutedEventArgs e)
        //{
        //    SomeText+="a";
        //    MessageBox.Show(SomeText);
        //    //Size+=10;

        //}

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    Binding binding = new Binding();
        //    binding.Source = sld2; 
        //    binding.Path = new PropertyPath("Value"); 
        //    binding.Mode = BindingMode.TwoWay; 
        //    BindingOperations.SetBinding(sld1, Slider.ValueProperty, binding);
        //}





    }
}
