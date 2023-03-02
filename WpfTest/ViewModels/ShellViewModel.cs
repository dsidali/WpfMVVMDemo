using Caliburn.Micro;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Model;

namespace WpfTest.ViewModels
{
    public class ShellViewModel: Screen
    {


        public BindableCollection<PackageTable> Packages { get; set; }

        public ShellViewModel() { 
        
        Packages = new BindableCollection<PackageTable>();
        
        }




        public void Save()
        {

            PackageTable package = new PackageTable();

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<PackageTable>();
                connection.Insert(package);
            }
        }


        public void Delete()
        {   
            PackageTable package = new PackageTable();
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
              //  connection.Delete<PackageTable>();
             
                connection.Delete(package);
            }
        }
    }
}
