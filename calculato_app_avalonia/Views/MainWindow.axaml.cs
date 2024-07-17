using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
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
            Mode.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Mode.svg", UriKind.Relative).ToString();
            Percent.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Percent.svg", UriKind.Relative).ToString();
            Div.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Div.svg", UriKind.Relative).ToString();
            Mult.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Mult.svg", UriKind.Relative).ToString();
            Minus.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Minus.svg", UriKind.Relative).ToString();
            Add.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/Plus.svg", UriKind.Relative).ToString();
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
            Mode.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/ModeDark.svg", UriKind.Relative).ToString();
            Percent.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/PercentDark.svg", UriKind.Relative).ToString();
            Div.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/DivDark.svg", UriKind.Relative).ToString();
            Mult.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/MultDark.svg", UriKind.Relative).ToString();
            Minus.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/MinusDark.svg", UriKind.Relative).ToString();
            Add.Path = new Uri("C:/Users/begla/source/repos/calculato_app_avalonia/calculato_app_avalonia/Assets/Icons/PlusDark.svg", UriKind.Relative).ToString();
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
            this.KeyDown += MainWindow_KeyDown;
            EnableAllButtons();

            ButtonEquals.Focus();
        }
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    ButtonEquals_Click(ButtonEquals, null);
                    enterKeyPressed = true; // Set the flag
                    break;
                case Key.D0:
                case Key.NumPad0:
                    Button_Click(Button0, null);
                    break;
                case Key.D1:
                case Key.NumPad1:
                    Button_Click(Button1, null);
                    break;
                case Key.D2:
                case Key.NumPad2:
                    Button_Click(Button2, null);
                    break;
                case Key.D3:
                case Key.NumPad3:
                    Button_Click(Button3, null);
                    break;
                case Key.D4:
                case Key.NumPad4:
                    Button_Click(Button4, null);
                    break;
                case Key.D5:
                case Key.NumPad5:
                    if (e.KeyModifiers.HasFlag(KeyModifiers.Shift))
                    {
                        ButtonPercent_Click(ButtonPercent, null);
                    }
                    else
                    {
                        Button_Click(Button5, null);
                    }
                    break;
                case Key.D6:
                case Key.NumPad6:
                    Button_Click(Button6, null);
                    break;
                case Key.D7:
                case Key.NumPad7:
                    Button_Click(Button7, null);
                    break;
                case Key.D8:
                case Key.NumPad8:
                    if (e.KeyModifiers.HasFlag(KeyModifiers.Shift))
                    {
                        Operation_Click(ButtonMult, null);
                    }
                    else
                    {
                        Button_Click(Button8, null);
                    }
                    break;
                case Key.D9:
                case Key.NumPad9:
                    Button_Click(Button9, null);
                    break;
                case Key.Add:
                case Key.OemPlus:
                    if (!e.KeyModifiers.HasFlag(KeyModifiers.Shift))
                    {
                        ButtonEquals_Click(ButtonEquals, null);
                    }
                    else
                    {
                        Operation_Click(ButtonAdd, null);
                    }
                    break;
                case Key.Subtract:
                case Key.OemMinus:
                    Operation_Click(ButtonMinus, null);
                    break;
                case Key.Multiply:
                    Operation_Click(ButtonMult, null);
                    break;
                case Key.Divide:
                    Operation_Click(ButtonDiv, null);
                    break;
                case Key.Oem2:
                    Operation_Click(ButtonDiv, null);
                    break;
                case Key.OemPeriod:
                case Key.Decimal:
                    ButtonDot_Click(ButtonDot, null);
                    break;
                case Key.Delete:
                    ButtonClear_Click(ButtonClear, null);
                    break;
                case Key.Back:
                    Backspace_Click(null, null);
                    break;
                default:
                    ButtonEquals.Focus(); // Set the focus to the ButtonEquals button
                    break;

            }
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button
        }
        private UserControl originalContent;
        private string option { get; set; }
        private double result { get; set; }

        private bool mode = false;

        private bool percentClicked = false;
        private bool equals { get; set; }

        private string lastOperator;

        private double lastOperand;

        private bool enterKeyPressed = false;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EnableAllButtons();
            Button button = (Button)sender;

            string buttonText = button.Content.ToString();

            if (txtTotal.Text == "Invalid Format" || txtTotal.Text == "Can't divide by 0")
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
            else
            {
                if (percentClicked)
                {
                    string[] parts = Expression.Text.Split(' ');

                    List<string> intermediateParts = new List<string>(parts);

                    if (intermediateParts.Count > 0)
                    {
                        intermediateParts[intermediateParts.Count - 1] = buttonText;
                        Expression.Text = string.Join(" ", intermediateParts);
                        txtTotal.Text = buttonText;
                    }

                    percentClicked = false; // Reset the flag
                }
                else if (equals)
                {
                    txtTotal.Text = buttonText;
                    Expression.Text = buttonText;
                    equals = false;
                }
                else if ((Expression.Text.EndsWith(" + 0") || Expression.Text.EndsWith(" - 0") || Expression.Text.EndsWith(" * 0") || Expression.Text.EndsWith(" / 0")))
                {
                    if (Expression.Text.Length > 2)
                    {
                        Expression.Text = Expression.Text.Substring(0, Expression.Text.Length - 1) + buttonText;
                    }
                    else
                    {
                        Expression.Text = buttonText;
                    }

                    if (txtTotal.Text.Length > 1)
                    {
                        txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1) + buttonText;
                    }
                    else
                    {
                        txtTotal.Text = buttonText;
                    }
                }
                else
                {
                    txtTotal.Text += buttonText;
                    Expression.Text += buttonText;
                }


            }
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            EnableAllButtons();
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(Expression.Text))
            {
                return;
            }
            if (Expression.Text.EndsWith("."))
            {
                Expression.Text = Expression.Text.TrimEnd('.');
            }
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.Text = "";
            }
            option = button.Tag.ToString();
            equals = false;
            if (IsOperator(Expression.Text.Last().ToString()))
            {
                Expression.Text = Expression.Text.Substring(0, Expression.Text.Length - 1) + " " + option + " ";
            }
            else if (IsOperator(Expression.Text.Trim().Substring(Expression.Text.Trim().LastIndexOf(' ') + 1)))
            {
                int lastIndex = Expression.Text.Trim().LastIndexOf(' ');
                Expression.Text = Expression.Text.Substring(0, lastIndex + 1) + option + " ";
            }
            else
            {
                Expression.Text += " " + option + " ";
            }
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

            //this.Focus();
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (Expression.Text == "-0" && txtTotal.Text == "-0")
            {
                txtTotal.Text = "Invalid Format";
                DisableAllButtons();
                return;
            }
            string[] parts = Expression.Text.Split(' ');
            if (Expression.Text.EndsWith("+ ") || Expression.Text.EndsWith("- ") || Expression.Text.EndsWith("* ") || Expression.Text.EndsWith("/ "))
            {
                string lastOperator = parts[parts.Length - 2];
                string lastOperandStr = parts[parts.Length - 3];
                double lastOperand = double.Parse(lastOperandStr, CultureInfo.InvariantCulture);
                Expression.Text += lastOperand.ToString(CultureInfo.InvariantCulture);
                parts = Expression.Text.Split(' ');
            }

            List<string> intermediateParts = new List<string>();
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "*" || parts[i] == "/")
                {
                    double leftOperand = double.Parse(intermediateParts[intermediateParts.Count - 1]);
                    double rightOperand = double.Parse(parts[i + 1], CultureInfo.InvariantCulture);
                    if (parts[i] == "/" && rightOperand == 0)
                    {
                        txtTotal.Text = "Can't divide by 0";
                        DisableAllButtons();
                        return;
                    }
                    result = parts[i] == "*" ? leftOperand * rightOperand : leftOperand / rightOperand;
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

            if (!equals)
            {
                lastOperator = parts.Length > 1 ? parts[parts.Length - 2] : string.Empty;
                lastOperand = parts.Length > 1 ? double.Parse(parts[parts.Length - 1], CultureInfo.InvariantCulture) : 0;
                equals = true;
            }
            else
            {
                switch (lastOperator)
                {
                    case "+":
                        finalResult += lastOperand;
                        break;
                    case "-":
                        finalResult -= lastOperand;
                        break;
                    case "*":
                        finalResult *= lastOperand;
                        break;
                    case "/":
                        if (lastOperand != 0)
                        {
                            finalResult /= lastOperand;
                        }
                        else
                        {
                            txtTotal.Text = "Can't divide by 0";
                            DisableAllButtons();
                            return;
                        }
                        break;
                }
            }

            txtTotal.Text = finalResult.ToString();
            Expression.Text = finalResult.ToString();
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button
        }
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            EnableAllButtons();
            txtTotal.Text = "0";
            Expression.Text = "0";
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

        }
        private void ButtonPercent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Expression.Text) || Expression.Text.EndsWith(" "))
            {
                return;
            }

            string[] parts = Expression.Text.Split(' ');

            if (parts.Length >= 3)
            {
                double previousNumber = double.Parse(parts[parts.Length - 3]);
                double currentNumber = double.Parse(parts[parts.Length - 1]);

                double result = (previousNumber * currentNumber) / 100;
                parts[parts.Length - 1] = result.ToString("0.##########", CultureInfo.InvariantCulture);

                Expression.Text = string.Join(" ", parts);
                txtTotal.Text = result.ToString("0.##########", CultureInfo.InvariantCulture);
                percentClicked = true;
            }
            else if (parts.Length == 1)
            {
                double currentNumber = double.Parse(parts[0]);
                double result = currentNumber / 100;

                parts[0] = result.ToString("0.##########", CultureInfo.InvariantCulture);

                Expression.Text = string.Join(" ", parts);
                txtTotal.Text = result.ToString("0.##########", CultureInfo.InvariantCulture);

                // Mark that percent was clicked
                percentClicked = true;
            }
            if (Expression.Text == "-0" && txtTotal.Text == "-0")
            {
                txtTotal.Text = "Invalid Format";
                Expression.Text = "Invalid Format";
                DisableAllButtons();
                return;
            }
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

            //this.Focus();
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
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

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
            ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtTotal.Text == "Invalid Format")
            {
                EnableAllButtons();
                txtTotal.Text = "";
                Expression.Text = "";
                ButtonEquals.Focus(); // Set the focus to the ButtonEquals button

            }
            else if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                if (Expression.Text.Length == 1)
                {
                    txtTotal.Text = "0";
                    Expression.Text = "0";
                }
                else
                {
                    txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);

                    string[] expressionParts = Expression.Text.Split(' ');

                    if (expressionParts[expressionParts.Length - 1].Length == 1)
                    {
                        expressionParts[expressionParts.Length - 1] = "";
                    }
                    else
                    {
                        expressionParts[expressionParts.Length - 1] = expressionParts[expressionParts.Length - 1].Substring(0, expressionParts[expressionParts.Length - 1].Length - 1);
                    }

                    Expression.Text = string.Join(" ", expressionParts);
                }
            }
            ButtonEquals.Focus();
        }


    }
}