using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class HistoryViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<String> ExpressionHistory;

        public HistoryViewModel()
        {
            ExpressionHistory = new ObservableCollection<String>();
        }

        public void Add(String calculation)
        {
            ExpressionHistory.Add(calculation);
            OnPropertyChanged("historyExpressions");
            OnPropertyChanged();
        }


        public ObservableCollection<String> historyExpressions
        {
            get => ExpressionHistory;
        }
        
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
