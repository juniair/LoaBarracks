using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoaBarracks.Infra.Models
{
    public class Barrack : BindableBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private ClassType _classType;
        public ClassType ClassType
        {
            get { return _classType; }
            set { SetProperty(ref _classType, value); }
        }

        private double _level;
        public double Level
        {
            get { return _level; }
            set { SetProperty(ref _level, value); }
        }

        private ObservableCollection<Content> _contents;
        public ObservableCollection<Content> Contents
        {
            get { return _contents; }
            set { SetProperty(ref _contents, value); }
        }
    }
}
