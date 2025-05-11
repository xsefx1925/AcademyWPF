using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using Academy;

namespace AcademyWPF.ViewModels
{
    public class MainViewModel
    {
        private Connector _connector;

        public ObservableCollection<DataRow> Students { get; set; }
        public ObservableCollection<DataRow> Groups { get; set; }
        public ObservableCollection<DataRow> Directions { get; set; }
        public ObservableCollection<DataRow> Disciplines { get; set; }
        public ObservableCollection<DataRow> Teachers { get; set; }

        public MainViewModel()
        {
            _connector = new Connector("YourConnectionStringHere");
            LoadData();
        }

        private void LoadData()
        {
            Students = new ObservableCollection<DataRow>(_connector.Select("*", "Students").AsEnumerable());
            Groups = new ObservableCollection<DataRow>(_connector.Select("*", "Groups").AsEnumerable());
            Directions = new ObservableCollection<DataRow>(_connector.Select("*", "Directions").AsEnumerable());
            Disciplines = new ObservableCollection<DataRow>(_connector.Select("*", "Disciplines").AsEnumerable());
            Teachers = new ObservableCollection<DataRow>(_connector.Select("*", "Teachers").AsEnumerable());
        }
    }
}
