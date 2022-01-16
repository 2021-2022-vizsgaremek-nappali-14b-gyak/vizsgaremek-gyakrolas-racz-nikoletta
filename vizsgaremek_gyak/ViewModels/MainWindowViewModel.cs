using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgaremek_gyak.ViewModels
{
    class MainWindowViewModel
    {
        private string selectedSource;

        public string SelectedSource
        {
            get => selectedSource;
            set
            {
                selectedSource = value;
                OnPropertyChanged("SelectedSource");
            }
        }
    }
}