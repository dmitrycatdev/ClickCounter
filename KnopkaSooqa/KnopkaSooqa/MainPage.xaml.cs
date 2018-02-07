using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KnopkaSooqa
{
	public partial class MainPage : ContentPage
	{
        private int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonСlicked(object sender, System.EventArgs e)
        {
            ++counter;
            Button button = (Button)sender;
            button.Text = counter.ToString();

            if (counter % 1000 == 0) button.TextColor = Color.Gold;
            else if (counter % 100 == 0) button.TextColor = Color.Green;
            else if (counter % 10 == 0) button.TextColor = Color.Red;
            else button.TextColor = Color.Black;
           // counter++;
        }
    }
}
