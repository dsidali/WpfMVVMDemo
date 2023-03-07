using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace WpfTest.Model
{
    public class PackageTable
    {

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }


    }
}
