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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            resSum2.Text = resEuro.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate3.Text);
            double sumGrivna = Convert.ToDouble(sum3.Text);
            double resGrivna = rateGrivna * sumGrivna;
            resSum3.Text = resGrivna.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate4.Text);
            double sumDrama= Convert.ToDouble(sum4.Text);
            double resDrama = rateDrama * sumDrama;
            resSum4.Text = resDrama.ToString();
        }

        private void Button_ClickInch(object sender, RoutedEventArgs e)
        {
            double sumInch= Convert.ToDouble(nInch.Text);
            double resDouble = sumInch* 0.0254;
            resInch.Text = resDouble.ToString();    
        }

        private void Button_ClickFoot(object sender, RoutedEventArgs e)
        {
            double sumFoot = Convert.ToDouble(nFoot.Text);
            double resDouble = sumFoot * 0.3048;
            resFoot.Text = resDouble.ToString();
        }

        private void Button_ClickMiles(object sender, RoutedEventArgs e)
        {
            double sumMiles = Convert.ToDouble(nMiles.Text);
            double resDouble = sumMiles * 1609.34;
            resMiles.Text = resDouble.ToString();
        }

        private void Button_ClickVerst(object sender, RoutedEventArgs e)
        {
            double sumVerst = Convert.ToDouble(nVerst.Text);
            double resDouble = sumVerst * 1066.8;
            resVerst.Text = resDouble.ToString();
        }
    }
}
