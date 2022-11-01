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

namespace Material_stock
{
    /// <summary>
    /// Логика взаимодействия для MaterialViewer.xaml
    /// </summary>
    public partial class MaterialView : UserControl
    {
        public MaterialView()
        {
            InitializeComponent();
            //var path = "C:\\Users\\student\\source\\repos\\Material stock\\Material stock\\Images\\niggers.jpg";
            for (int i = 0; i < 2; i++)
            {
                var path = new Material(i).Image;
                var uri = new Uri(path);
                var bitmap = new BitmapImage(uri);
                image.Source = bitmap;
                label.Content = new Material(i).Name;
                priceLabel.Content = new Material(i).Price + " шакелей";
            }
        }
    }
}
