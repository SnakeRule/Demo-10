using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Excercise_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            listTextBox.Text = "";

            if ((bool)lemonadeCheckBox.IsChecked)
                listTextBox.Text = listTextBox.Text + "Lemonade, ";

            if ((bool)butterCheckBox.IsChecked)
                listTextBox.Text = listTextBox.Text + "Butter, ";

            if ((bool)milkCheckBox.IsChecked)
                listTextBox.Text = listTextBox.Text + "Milk, ";

            if ((bool)beerCheckBox.IsChecked)
                listTextBox.Text = listTextBox.Text + "Beer, ";

            if ((bool)chickenCheckBox.IsChecked)
                listTextBox.Text = listTextBox.Text + "Chicken, ";
        }
    }
}
