using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using vizsgaremek_gyak.Pages;

namespace vizsgaremek_gyak.Navigation
{
    public static class Navigation
    {
        public static MainWindow mainWindow;

        public static void Navigate(UserControl userControl)
        {
            mainWindow.PageContent.Children.Clear();
            mainWindow.PageContent.Children.Add(userControl);
        }
    }
}
