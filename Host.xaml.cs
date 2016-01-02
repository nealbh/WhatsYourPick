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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Doodle
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Host : Page
    {
        public Boolean isSendSet;
        public Host()
        {
            isSendSet = false;
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            select_title.Text = "Selections";
            selections.Visibility = Visibility.Collapsed;

            int text = 0;
            int.TryParse(selections.Text, out text);

            TextBox txt;
            for (int i = 0; i < text; ++i)
            {
                txt = new TextBox();
                txt.Text = "Option #" +(i + 1).ToString();
                txt.Margin = new Thickness(20.0, 20.0, 0.0, 0.0);
                txt.Width = 300;
                txt.TextAlignment = TextAlignment.Left;
                txt.HorizontalAlignment = HorizontalAlignment.Left;
                // need to add a margin
                stack.Children.Add(txt);
            }
            contact.Visibility = Visibility.Visible;
                
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
          //  Frame.Navigate(typeof(Contact));
        }

        
    }
}
