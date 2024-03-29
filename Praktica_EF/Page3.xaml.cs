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

namespace Praktica_EF
{
    public partial class Page3 : Page
    {
        private UNLV_STOREEntities context = new UNLV_STOREEntities();
        public Page3()
        {
            InitializeComponent();
            Orders.ItemsSource = context.Orders.ToList();
        }
    }
}
