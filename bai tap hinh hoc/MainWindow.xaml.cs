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

namespace bai_tap_hinh_hoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            HinhCN hcn = new HinhCN(4, 3);
            HinhVuong hv = new HinhVuong(3);
            HinhTron ht = new HinhTron(3);
            hcn.ChuVi();
            hcn.DienTich();
            hv.ChuVi();
            hv.DienTich();
            ht.ChuVi();
            ht.DienTich();
            MessageBox.Show("Chu vi HinhCN: " + hcn.chuvi.ToString()
                            + "\nDien Tich HinhCN: " + hcn.dientich.ToString() + "\n"

                            + "\nChu vi HinhVuong: " + hv.chuvi.ToString()
                            + "\nDien Tich HinhVuong: " + hv.dientich.ToString() + "\n"
 
                            + "\nChu vi HinhTron: " + ht.chuvi.ToString()                                                       
                            + "\nDien Tich HinhTron: " + ht.dientich.ToString());           
        }
    }
}
