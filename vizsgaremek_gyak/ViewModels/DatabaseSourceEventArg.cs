using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgaremek_gyak.ViewModels
{
    class DatabaseSourceEventArg
    {
        private string databaseSource;

        public DatabaseSourceEventArg(string databaseSource)
        {
            this.DatabaseSource = databaseSource;
        }

        public string DatabaseSource { get => databaseSource; set => databaseSource = value; }
    }
}
