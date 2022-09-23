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

namespace Calcuator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //A VARIABLE TO STORE FIRST NUMBER
        double FirstNumber;

        //a variable to store operations
        string Operation;
      
        
        public MainWindow()
        {
          

            InitializeComponent();
        }

        private void Button01(object sender, RoutedEventArgs e)
        {
            //when the button is clicked, it should check if the textbox is null
          if( MyTextBox.Text=="")
            {
                //if it is, it would set the text on the textbox to 1 
                MyTextBox.Text = "1";
          }
            else
            {
                //if not concactinate the text with 1
                MyTextBox.Text = MyTextBox.Text + "1";
            }
        }

        private void Button02(object sender, RoutedEventArgs e)
        {
            //when the button is clicked, it should check if the textbox is null
            if ( MyTextBox.Text == "")
            {
                //if it is, it would set the text on the textbox to 2
                MyTextBox.Text = "2";
            }
            else
            {
                //if not concactinate the text with 2
                MyTextBox.Text = MyTextBox.Text + "2";
            }
        }

        private void Button03(object sender, RoutedEventArgs e)
        {
            //when the button is clicked, it should check if the textbox is null
            if ( MyTextBox.Text == "")
            {
                //if it is, it would set the text on the textbox to 3
                MyTextBox.Text = "3";
            }
            else
            {
                //if not concactinate the text with 3
                MyTextBox.Text = MyTextBox.Text + "3";
            }
        }

        private void Button04(object sender, RoutedEventArgs e)
        {
            //when the button is clicked, it should check if the textbox is null
            if ( MyTextBox.Text == "")
            {
                //if it is, it would set the text on the textbox to 4
                MyTextBox.Text = "4";
            }
            else
            {
                //if not concactinate the text with 4
                MyTextBox.Text = MyTextBox.Text + "4";
            }
        }

        private void Button05(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "5";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + "5";
            }
        }

        private void Button06(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "6";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + "6";
            }
        }

        private void Button07(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "7";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + "7";
            }
        }

        private void Button08(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "8";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + "8";
            }
        }

        private void Button09(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "9";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + "9";
            }
        }

        private void Button00(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "0";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + "0";
            }
        }

        private void ButtonClear(object sender, RoutedEventArgs e)
        {
            MyTextBox.Clear();
        }


        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if ( MyTextBox.Text == "")
            {
                MyTextBox.Text = "0.";
            }
            else
            {
                MyTextBox.Text = MyTextBox.Text + ".";
            }
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            //parse all text on the text box to a double
            FirstNumber = double.Parse(MyTextBox.Text);
            //set the text box to null
            MyTextBox.Text = "";
            Operation = "+";
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            //parse all text on the text box to a double
            FirstNumber = double.Parse(MyTextBox.Text);
            //set the text box to null
            MyTextBox.Text = "";
            Operation = "-";
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            //parse all text on the text box to a double
            FirstNumber = double.Parse(MyTextBox.Text);
            //set the text box to null
            MyTextBox.Text = "";
            Operation = "/";
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            //parse all text on the text box to a double
            FirstNumber = double.Parse(MyTextBox.Text);
            //set the text box to null
            MyTextBox.Text = "";
            Operation = "*";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            //declaring variable result
            double Result;
            //after an operation parse all other texts sfter the operation to a double
            double SecondNumber = double.Parse(MyTextBox.Text);

            /*******************************
             * Will perform calculations depending on
             * the operation. Then check if it is divisible by one
             * without no remainder and cast it into an int if it is before displaying.
             * If it is not, just convert it to string and display on
             * the textbox
             * And then set First number as result back.
             */


            if(Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
                if(Result % 1 == 0)
                {
                    int intResult = (int)Result;
                    MyTextBox.Text = intResult.ToString();
                    FirstNumber = intResult;
                }
                else
                {
                    MyTextBox.Text = Result.ToString();
                    FirstNumber = Result;
                }
            }

            if (Operation == "-")
            {
                Result = FirstNumber - SecondNumber;
                if (Result % 1 == 0)
                {
                    int intResult = (int)Result;
                    MyTextBox.Text = intResult.ToString();
                    FirstNumber = intResult;
                }
                else
                {
                    MyTextBox.Text = Result.ToString();
                    FirstNumber = Result;
                }
            }

            if (Operation == "*")
            {
                Result = FirstNumber * SecondNumber;
                if (Result % 1 == 0)
                {
                    int intResult = (int)Result;
                    MyTextBox.Text = intResult.ToString();
                    FirstNumber = intResult;
                }
                else
                {
                    MyTextBox.Text = Result.ToString();
                    FirstNumber = Result;
                }
            }

            if (Operation == "/")
            {
                Result = FirstNumber / SecondNumber;
                if (Result % 1 == 0)
                {
                    int intResult = (int)Result;
                    MyTextBox.Text = intResult.ToString();
                    FirstNumber = intResult;
                }
                else
                {
                    MyTextBox.Text = Result.ToString();
                    FirstNumber = Result;
                }
            }
        }

        private void ButtonOn_Click(object sender, RoutedEventArgs e)
        {
            /**********************
             * Setting different colors for 
             * the on and off button.
             * */


            if((string)ButtonOn.Content == "ON")
            {
                ButtonOn.Content = "OFF";
                ButtonOn.Foreground = Brushes.Blue;

            }

            else
            {
                ButtonOn.Content = "ON";
                ButtonOn.Foreground = Brushes.White;
            }

            /************************
             * Creating a list of Buttons that would store 
             * all buttons. Sinc all button apart from 
             * the On and Off button are set to false by default
             * If the button is "Off" all button should still be 
             * disabled. If the button is "ON" all button should be enabled
             * */

            List<Button> lstButtons = new List<Button>();

            lstButtons.Add(Button1);
            lstButtons.Add(Button2);
            lstButtons.Add(Button3);
            lstButtons.Add(Button4);
            lstButtons.Add(Button5);
            lstButtons.Add(Button6);
            lstButtons.Add(Button7);
            lstButtons.Add(Button8);
            lstButtons.Add(Button9);
            lstButtons.Add(Button0);
            lstButtons.Add(ButtonAdd);
            lstButtons.Add(ButtonSub);
            lstButtons.Add(ButtonMul);
            lstButtons.Add(ButtonDiv);
            lstButtons.Add(ButtonPoint);
            lstButtons.Add(Button_Clear);
            lstButtons.Add(ButtonEquals);

            if ((string)ButtonOn.Content == "ON")
            {
                foreach (Button button in lstButtons)
                {
                    button.IsEnabled = false;
                }

            }
            else
            {
                foreach (Button button in lstButtons)
                {
                    button.IsEnabled = true;
                }
            }



        }
    }
}
