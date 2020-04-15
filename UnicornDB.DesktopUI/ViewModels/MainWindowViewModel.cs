using System.Collections.ObjectModel;
using UnicornDB.Core.Models;
using UnicornDB.Core.Services;

namespace UnicornDB.DesktopUI.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Unicorn> _unicorns;
        private readonly UnicornRepository _uniService;

        public ObservableCollection<Unicorn> Unicorns
        {
            get => _unicorns;
            private set
            {
                _unicorns = value;
                OnPropertyChanged(nameof(UniCount));
                OnPropertyChanged();
            }
        }

        public int UniCount
        {
            get { return Unicorns.Count; }
        }

        private bool _alwaysOntop;

        public bool AlwaysOnTop
        {
            get { return _alwaysOntop; }
            set
            {
                _alwaysOntop = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            _uniService = new UnicornRepository();
            Unicorns = new ObservableCollection<Unicorn>(_uniService.Unicorns);
        }

        public void AddRandomUnicorn()
        {
            _uniService.AddRandomUnicorn();
            Unicorns = new ObservableCollection<Unicorn>(_uniService.Unicorns);
        }
    }
}