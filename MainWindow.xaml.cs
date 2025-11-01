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

namespace Calcquiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        int grade = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            RadioButton radio = sender as RadioButton;
            int option = int.Parse(radio.Tag.ToString());
            Random rnd = new Random();
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);


            double result=0;
            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    double num1d = (double)(num1);
                    double num2d = (double)(num2);
                    result = num1d / num2d;
                    break;
                case 5:
                    result = num1 % num2;
                    break;
                case 6:
                    double dnum1 = (double)(num1);
                    double dnum2 = (double)(num2);
                    result = (dnum1 + dnum2) / 2;

                    break;
                case 7:
                    result = num1 / num2;
                    break;
          
                default:
                    result = 0;
                    break;

            }
            trueresult.Text = result.ToString();


        }
        private void MyLocalRandom()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(0, 11);
            int num2 = rnd.Next(0, 11);
            number1.Text = num1.ToString();
            number2.Text = num2.ToString();
        }
        private void MyRandom(object sender, RoutedEventArgs e)
        {
            MyLocalRandom();
        }
        private void Answercheack(object sender, RoutedEventArgs e)
        {
            double answer = double.Parse(this.uranswer.Text);
            double result = double.Parse(this.trueresult.Text);
            if(answer==result)
            {
                grade = grade + 20;
                
            }
            score.Text = grade.ToString();
            i++;

            uranswer.Text = "";
            if (i>5)
            {
                round.Text = "you finished a round";
                score.Text = grade.ToString();
                i = 0;
                grade = 0;
            }
            MyLocalRandom();
        }
    }
}