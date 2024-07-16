using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace calculato_app_avalonia.Views
{
    public partial class MainWindow : Window
    {
        public void LightMode()
        {
            var ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Mode.png");
            Mode.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Div.png");
            Div.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Minus.png");
            Minus.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Mult.png");
            Mult.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Percent.png");
            Percent.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Plus.png");
            Plus.Source = ImageToView;
            TopBlock.Background = new SolidColorBrush(Color.Parse("White"));
            Expression.Background = new SolidColorBrush(Color.Parse("White"));
            txtTotal.Background = new SolidColorBrush(Color.Parse("White"));
            txtTotal.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            BottomBlock.Background = new SolidColorBrush(Color.Parse("#F5F5F5"));
            Button0.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button1.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button2.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button3.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button4.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button5.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button6.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button7.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button8.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button9.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            Button0.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button1.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button2.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button3.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button4.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button5.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button6.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button7.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button8.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            Button9.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            ButtonDot.Foreground = new SolidColorBrush(Color.Parse("#1E1E1E"));
            ButtonAdd.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonMinus.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonPercent.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonMult.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonDiv.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonDot.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonClear.Background = new SolidColorBrush(Color.Parse("#eae9e9"));
            ButtonMode.Background = new SolidColorBrush(Color.Parse("#F5F5F5"));
            ButtonMode.BorderBrush = new SolidColorBrush(Color.Parse("#E9E9E9"));

        }
        private void DarkMode()
        {
            var ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/ModeDark.png");
            Mode.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/DivDark.png");
            Div.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/MinusDark.png");
            Minus.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/MultDark.png");
            Mult.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/PercentDark.png");
            Percent.Source = ImageToView;
            ImageToView = new Bitmap("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/PlusDark.png");
            Plus.Source = ImageToView;
            TopBlock.Background = new SolidColorBrush(Color.Parse("#212327"));
            Expression.Background = new SolidColorBrush(Color.Parse("#212327"));
            txtTotal.Background = new SolidColorBrush(Color.Parse("#212327"));
            txtTotal.Foreground = new SolidColorBrush(Color.Parse("#FFFFFF"));
            BottomBlock.Background = new SolidColorBrush(Color.Parse("#27292E"));
            Button0.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button1.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button2.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button3.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button4.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button5.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button6.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button7.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button8.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button9.Background = new SolidColorBrush(Color.Parse("#323439"));
            Button0.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button1.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button2.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button3.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button4.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button5.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button6.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button7.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button8.Foreground = new SolidColorBrush(Color.Parse("White"));
            Button9.Foreground = new SolidColorBrush(Color.Parse("White"));
            ButtonDot.Foreground = new SolidColorBrush(Color.Parse("White"));
            ButtonAdd.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonMinus.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonPercent.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonMult.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonDiv.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonDot.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonClear.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonMode.Background = new SolidColorBrush(Color.Parse("#323439"));
            ButtonMode.BorderBrush = new SolidColorBrush(Color.Parse("#27292E"));
        }
        private void EnableAllButtons()
        {
            ButtonAdd.IsEnabled = true;
            ButtonMinus.IsEnabled = true;
            ButtonPercent.IsEnabled = true;
            ButtonMult.IsEnabled = true;
            ButtonDiv.IsEnabled = true;
            ButtonEquals.IsEnabled = true;
            ButtonDot.IsEnabled = true;
        }
        private void DisableAllButtons()
        {
            ButtonAdd.IsEnabled = false;
            ButtonMinus.IsEnabled = false;
            ButtonPercent.IsEnabled = false;
            ButtonMult.IsEnabled = false;
            ButtonDiv.IsEnabled = false;
            ButtonEquals.IsEnabled = false;
            ButtonDot.IsEnabled = false;
        }
        private bool IsOperator(string character)
        {
            return character == "+" || character == "-" || character == "*" || character == "/";
        }
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
#if DEBUG
            this.AttachDevTools();
#endif
        }
        private UserControl originalContent;
        private string option { get; set; }
        private double num1 { get; set; }
        private double num2 { get; set; }
        private double result { get; set; }
        private  bool equals {get; set;}

        private void Button_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Content.ToString();
            if (txtTotal.Text == "Invalid Format")
            {
                txtTotal.Text = "";
                Expression.Text = "";
            }
            if (Expression.Text == "0")
            {
                if (buttonText != "0" && buttonText != "+" && buttonText != "-" && buttonText != "*" && buttonText != "/")
                {
                    txtTotal.Text = buttonText;
                    Expression.Text = buttonText;
                }
                else
                {
                    txtTotal.Text = "0";
                    Expression.Text = "0";
                }
            }
            else {
                if (equals)
                {
                    txtTotal.Text = buttonText;
                    Expression.Text += buttonText;
                }
                else
                {
                    if (buttonText == ".")
                    {
                        if (!txtTotal.Text.Contains("."))
                        {
                            txtTotal.Text += buttonText;
                            Expression.Text += buttonText;
                        }
                    }
                    else
                    {
                        txtTotal.Text += buttonText;
                        Expression.Text += buttonText;
                    }
                }
            }
        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(Expression.Text)) 
            { 
                return;
            }
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.Text = "";
            }
            option = button.Tag.ToString();
            if (!string.IsNullOrEmpty(Expression.Text) && IsOperator(Expression.Text.Last().ToString()))
            {
                Expression.Text = Expression.Text.Substring(0, Expression.Text.Length - 1) + " " + option + " ";
            }
            else if (!string.IsNullOrEmpty(Expression.Text) && IsOperator(Expression.Text.Trim().Substring(Expression.Text.Trim().LastIndexOf(' ') + 1)))
            {
                int lastIndex = Expression.Text.Trim().LastIndexOf(' ');
                Expression.Text = Expression.Text.Substring(0, lastIndex + 1) + option + " ";
            }
            else
            {
                Expression.Text += " " + option + " ";
            }
        }

        private void ButtonEquals_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Expression.Text) || Expression.Text.EndsWith("+ ") || Expression.Text.EndsWith("- ") || Expression.Text.EndsWith("* ") || Expression.Text.EndsWith("/ "))
            {
                txtTotal.Text = "Invalid Format";
                DisableAllButtons();
                return;
            }

            string[] parts = Expression.Text.Split(' ');

            List<string> intermediateParts = new List<string>();
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "*")
                {
                    double leftOperand = double.Parse(intermediateParts[intermediateParts.Count - 1], CultureInfo.InvariantCulture);
                    double rightOperand = double.Parse(parts[i + 1], CultureInfo.InvariantCulture);
                    double result = leftOperand * rightOperand;
                    intermediateParts[intermediateParts.Count - 1] = result.ToString(CultureInfo.InvariantCulture);
                    i++;
                }
                else if (parts[i] == "/")
                {
                    double leftOperand = double.Parse(intermediateParts[intermediateParts.Count - 1], CultureInfo.InvariantCulture);
                    double rightOperand = double.Parse(parts[i + 1], CultureInfo.InvariantCulture);
                    double result = leftOperand / rightOperand;
                    intermediateParts[intermediateParts.Count - 1] = result.ToString(CultureInfo.InvariantCulture);
                    i++;
                }
                else
                {
                    intermediateParts.Add(parts[i]);
                }
            }

            double finalResult = double.Parse(intermediateParts[0], CultureInfo.InvariantCulture);
            for (int i = 1; i < intermediateParts.Count; i += 2)
            {
                if (intermediateParts[i] == "+")
                {
                    finalResult += double.Parse(intermediateParts[i + 1], CultureInfo.InvariantCulture);
                }
                else if (intermediateParts[i] == "-")
                {
                    finalResult -= double.Parse(intermediateParts[i + 1], CultureInfo.InvariantCulture);
                }
            }
            txtTotal.Text = finalResult.ToString("0.##########", CultureInfo.InvariantCulture);
            Expression.Text = finalResult.ToString("0.##########", CultureInfo.InvariantCulture);
            equals = true;
        }



        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            EnableAllButtons();
            txtTotal.Text = "";
            Expression.Text = "";
            result = 0;
            num1 = 0;
            num2 = 0;
        }
        private void ButtonPercent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Expression.Text) || Expression.Text.EndsWith("+ ") || Expression.Text.EndsWith("- ") || Expression.Text.EndsWith("* ") || Expression.Text.EndsWith("/ "))
            {
                return;
            }
            string[] parts = Expression.Text.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == txtTotal.Text)
                {
                    double num1 = double.Parse(txtTotal.Text);
                    double result = num1 / 100;
                    parts[i] = result.ToString();
                    Expression.Text = string.Join(" ", parts);
                    txtTotal.Text = result.ToString();
                }
            }
        }

        private void ButtonDot_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (!txtTotal.Text.Contains("."))
            {
                txtTotal.Text += ".";

                Expression.Text += ".";
            }
            else if (txtTotal.Text.EndsWith("."))
            {
                txtTotal.Text = txtTotal.Text;
                Expression.Text = Expression.Text;
            }
        }
        private void Mode_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (mode == false)
            {
                DarkMode();
                mode = true;
            }
            else if (mode == true)
            {
                LightMode();
                mode = false;
            }
        }
    }
}
