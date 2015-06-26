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

namespace AppEjemploWindows10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Navegar a la página por defecto y seleccionar el elemento en el pane
            ContentFrame.Navigate(typeof(Portada));
            NavigateToFrontPage.IsChecked = true;
        }

        private void HamburguerButton_Click(object sender, RoutedEventArgs e)
        {
            if (Split.IsPaneOpen)
            {
                Split.IsPaneOpen = false;
            }
            else
            {
                Split.IsPaneOpen = true;
            }

            HamburguerButton.IsChecked = false;
        }

        private void NavigateToFrontPage_Click(object sender, RoutedEventArgs e)
        {
            // Navegar a la portada y seleccionar el elemento en el pane
            ContentFrame.Navigate(typeof(Portada));
            NavigateToFrontPage.IsChecked = true;
        }

        private void NavigateToPageOne_Click(object sender, RoutedEventArgs e)
        {
            // Navegar a la página 1 y seleccionar el elemento en el pane
            ContentFrame.Navigate(typeof(pagina1));
            NavigateToPageOne.IsChecked = true;
        }

        private void NavigateToPageTwo_Click(object sender, RoutedEventArgs e)
        {
            // Navegar a la página 2 y seleccionar el elemento en el pane
            ContentFrame.Navigate(typeof(pagina2));
            NavigateToPageTwo.IsChecked = true;
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if(ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }

            GoBack.IsChecked = false;
        }
    }
}
