using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace DependentBoxingBug
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _filter;

        public MainWindowViewModel()
        {
            var rows = new ObservableCollection<RowViewModel>();
            for (var i = 0; i < 50000; i++)
                rows.Add(new RowViewModel());

            ListCollectionView = new ListCollectionView(rows) {Filter = OnFilter};
        }

        public ListCollectionView ListCollectionView { get; private set; }

        public string Filter
        {
            get { return _filter; }
            set
            {
                if (_filter == value)
                    return;

                _filter = value;
                OnPropertyChanged("Filter");

                // Actually we have timeout before starting filtering
                // But for reproducing issue this is ok
                ListCollectionView.Refresh(); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool OnFilter(object item)
        {
            var rowViewModel = item as RowViewModel;
            if (rowViewModel == null)
                return false;

            var filter = Filter;
            if (string.IsNullOrWhiteSpace(filter))
                return true;

            return rowViewModel.Property1.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property2.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property3.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property4.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property5.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property6.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property7.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property8.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property9.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   rowViewModel.Property10.IndexOf(filter, 0, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}