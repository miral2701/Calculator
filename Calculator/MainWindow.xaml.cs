using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder text=new  StringBuilder();
        StringBuilder final_text = new StringBuilder();
        int symbol_count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Eq_Button_Click(object sender, RoutedEventArgs e)
        {
            var res=await CSharpScript.EvaluateAsync<double>(textBlock2.Text, ScriptOptions.Default.WithImports("System.Math"));
            textBlock1.Text=res.ToString();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            text.Append("7");
            final_text.Append("7");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();


        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            text.Append("8");
            final_text.Append("8");
            textBlock2.Text = final_text.ToString();
            textBlock1.Text = text.ToString();


        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            text.Append("9");
            final_text.Append("9");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();



        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            text.Append("4");
            final_text.Append("4");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            text.Append("5");
            final_text.Append("5");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();


        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            text.Append("6");
            final_text.Append("6");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            text.Append("1");
            final_text.Append("1");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();


        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            text.Append("2");
            final_text.Append("2");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            text.Append("3");
            final_text.Append("3");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();

        }

        private void Dot_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Append(".");
            final_text.Append(".");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();

        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            text.Append("0");
            final_text.Append("0");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();

        }

        private void Div_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            final_text.Append("/");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
            symbol_count++;
        }

        private void Mult_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            final_text.Append("*");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
            symbol_count++;

        }

        private void Min_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            final_text.Append("-");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
            symbol_count++;

        }

        private void Sum_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            final_text.Append("+");
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
            symbol_count++;

        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Remove(text.Length-1,1);
            final_text.Remove(final_text.Length-1, 1);
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
        }

        private void C_Button_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            final_text.Clear();
            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
            symbol_count = 0;
        }

        
        private void CE_button_Click(object sender, RoutedEventArgs e)
        {
            final_text.Remove(Array.LastIndexOf(final_text.ToString().Split('-','+','/','*'),text.ToString())+symbol_count,text.Length);
      
            text.Clear();

            textBlock1.Text = text.ToString();
            textBlock2.Text = final_text.ToString();
        }
    }
}