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

namespace Lab14_WPF_Labovkin
{
   
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Апельсины",
                ProductPrice = 120,
                ProductImage = "Data/Апельсины.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "Томаты",
                ProductPrice = 90,
                ProductImage = "Data/Томаты.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "Яблоки",
                ProductPrice = 70,
                ProductImage = "Data/Яблоки.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "СВЧ печь",
                ProductPrice = 6000,
                ProductImage = "Data/СВЧ_печь.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Холодильник",
                ProductPrice = 30000,
                ProductImage = "Data/Холодильник.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Пылесос",
                ProductPrice = 10000,
                ProductImage = "Data/Пылесос.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
