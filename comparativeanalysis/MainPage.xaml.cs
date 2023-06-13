using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace comparativeanalysis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void HandleButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (pressed == "C")
            {
                resultLabel.Text = "";
            }
            else if (pressed == "DEL")
            {
                if (resultLabel.Text.Length > 0)
                {
                    resultLabel.Text = resultLabel.Text.Remove(resultLabel.Text.Length - 1);
                }
            }
            else if (pressed == "=")
            {
                string expression = resultLabel.Text;

                // Use a DataTable to evaluate the expression
                System.Data.DataTable table = new System.Data.DataTable();
                try
                {
                    var result = table.Compute(expression, "");
                    resultLabel.Text = result.ToString();
                }
                catch
                {
                    resultLabel.Text = "Error";
                }
            }
            else
            {
                resultLabel.Text += pressed;
            }
        }

    }
}
