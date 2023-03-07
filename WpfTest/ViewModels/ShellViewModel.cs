using Caliburn.Micro;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
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
        SQLiteConnection connection;
        public ShellViewModel() { 
        
        
            connection = new SQLiteConnection(App.databasePath);
        connection.CreateTable<PackageTable>();
            LoadData();
    //  Packages = new BindableCollection<PackageTable>(People);

        }


        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; 
                NotifyOfPropertyChange(() => Id);
            
            }

        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; 
                NotifyOfPropertyChange(() => Name); 
            
            }
        }


        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; 
                NotifyOfPropertyChange(() => Description);
            
            }
        }

        private string _weight;

        public string Weight
        {
            get { return _weight; }
            set { _weight = value; 
                NotifyOfPropertyChange(() => Weight);
            
            }
        }

        public PackageTable SelectedItem { get; set; }

        private BindableCollection<PackageTable> _packageList;

        public BindableCollection<PackageTable> PackageList
        {
            get { return _packageList; }
            set { _packageList = value; 
                NotifyOfPropertyChange(() => PackageList);
            }
        }














        public ObservableCollection<PackageTable> People { get; set; }

        public void LoadData()
        {
            _packageList = new BindableCollection<PackageTable>(connection.Table<PackageTable>());
        }

        public void AddPerson(PackageTable person)
        {
            connection.Insert(person);
            People.Add(person);
        }

        public void UpdatePerson(PackageTable person)
        {
            connection.Update(person);
        }

        public void DeletePerson(PackageTable person)
        {
            connection.Delete(person);
            People.Remove(person);
        }
    }
}
