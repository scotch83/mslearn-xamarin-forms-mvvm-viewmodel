using GreatQuotes.Infrastructure;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GreatQuotes.Data;
using System.Linq;

namespace GreatQuotes.ViewModels
{
    public class MainViewModel : SimpleViewModel
    {

        private QuoteViewModel _selectedQuote;

        public QuoteViewModel SelectedQuote
        {
            get => _selectedQuote;
            set => SetPropertyValue(ref _selectedQuote, value);
        }

        public IList<QuoteViewModel> Quotes { get; private set; }

        public MainViewModel()
        {
            Quotes = new ObservableCollection<QuoteViewModel>(
                QuoteManager.Load()
                            .Select(q => new QuoteViewModel(q)));
        }
    }
}

