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

namespace RestaurantManager
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

        /// <summary>
        /// Navigates to the OrderPage when the SubmitOrder button is clicked
        /// uses Frame.Navigate for page navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrderPage));
        }

        /// <summary>
        /// Navigates to the Expedite page when Orders button is clicked
        /// uses Frame.Navigate for page navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOrdersView_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ExpeditePage));
        }
    }
}
