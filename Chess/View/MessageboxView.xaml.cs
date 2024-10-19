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

namespace Chess.View
{
    /// <summary>
    /// Interaktionslogik für MessageboxView.xaml
    /// </summary>
    public partial class MessageboxView : UserControl
    {
        public MessageboxView()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Hier kannst du das UserControl aus dem Parent entfernen
            var parent = this.Parent as Panel; // Panel ist das übergeordnete Element, z.B. Grid
            parent?.Children.Remove(this);
        }
    }
}
