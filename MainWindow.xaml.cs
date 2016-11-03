using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApplication5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public
                 bool flag_add;
            bool flag_sub;
            bool flag_mul;
            bool flag_div;
            bool flag_mod;
            bool flag_dot;
            bool flag_reciprocal;
            bool flag_sqrt;
            int res = 0;
            int ans=0;

        public MainWindow()
        {
           
            InitializeComponent();
           
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            Calc_Area.Text = Calc_Area.Text + "1";

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "9";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = Calc_Area.Text + "0";
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            
            res = res + Convert.ToInt32(Calc_Area.Text);
            flag_add = true;
            Calc_Area.Clear();

        }

        private void Equal_button_Click(object sender, RoutedEventArgs e)
        {
            if (flag_add == true)
            {
                ans = res + Convert.ToInt32(Calc_Area.Text);
                //MessageBox.Show(ans.ToString());

            }

            if (flag_sub == true)
            {
                ans = res - Convert.ToInt32(Calc_Area.Text);
                //MessageBox.Show(ans.ToString());

            }
            if (flag_mul == true)
            {
                ans = res * Convert.ToInt32(Calc_Area.Text);
                //MessageBox.Show(ans.ToString());

            }
            if (flag_div == true)
            {
                ans = res / Convert.ToInt32(Calc_Area.Text);
                //MessageBox.Show(ans.ToString());

            }
            if (flag_mod == true)
            {
                ans = res % Convert.ToInt32(Calc_Area.Text);
                //MessageBox.Show(ans.ToString());

            }
            
            if (flag_dot == true)
            {
                ans = Convert.ToInt32(res.ToString() + "." + Calc_Area.Text);
            }
           

            
            label.Content =  ans.ToString();

            if (flag_sqrt == true)
            {
                label.Content = ans.ToString();
            }
            if (flag_reciprocal == true)
            {
                label.Content = ans.ToString();

                //MessageBox.Show(ans.ToString());

            }
        }

        private void Sub_button_Click(object sender, RoutedEventArgs e)
        {
            res = res + Convert.ToInt32(Calc_Area.Text);
            flag_sub = true;
            Calc_Area.Clear();

        }

        private void Mul_button_Click(object sender, RoutedEventArgs e)
        {
            res = res + Convert.ToInt32(Calc_Area.Text);
            flag_mul = true;
            Calc_Area.Clear();

        }

        private void div_button_Click(object sender, RoutedEventArgs e)
        {
            res = res + Convert.ToInt32(Calc_Area.Text);
            flag_div = true;
            Calc_Area.Clear();

        }

        private void Mod_button_Click(object sender, RoutedEventArgs e)
        {
            res = res + Convert.ToInt32(Calc_Area.Text);
            flag_mod = true;
            Calc_Area.Clear();

        }

        private void Reciprocal_button_Click(object sender, RoutedEventArgs e)
        {
            ans = 1 / (Convert.ToInt32(Calc_Area.Text));
            flag_reciprocal = true;

            
        }

        private void Dot_button_Click(object sender, RoutedEventArgs e)
        {
            res = res + Convert.ToInt32(Calc_Area.Text);
            flag_dot = true;
            Calc_Area.Clear();

        }

        private void C_button_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Clear();
            label.Content = "";
            res = 0;
            ans = 0;
        }

        private void CE_button_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = "";
            label.Content = "";
            res = 0;
            ans = 0;

        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            int val=Convert.ToInt32(Calc_Area.Text) / 10;
            Calc_Area.Text = Convert.ToString(val);
        }

        private void Sqrt_button_Click(object sender, RoutedEventArgs e)
        {
            ans = Convert.ToInt32(Math.Sqrt(Convert.ToInt32(Calc_Area.Text)));
            flag_sqrt = true;

        }

        private void Sign_button_Click(object sender, RoutedEventArgs e)
        {
            Calc_Area.Text = "-" + Calc_Area.Text;
            
        }





        









    }
}
