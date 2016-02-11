using System;
using System.Collections.Generic;
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

namespace Excercise_3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool check;
        int result;
        public MainPage()
        {
            this.InitializeComponent();
        }

        Lotto lotto = new Lotto();

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
           if (check = int.TryParse(drawsTextBox.Text, out result))
            {
                string game = lottoComboBox.SelectedValue.ToString();
                lotto.drawNumbers(result, game);
                numbersTextBlock.Text = lotto.PrintNumbers();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numbersTextBlock.Text = "";
        }
    }
}
