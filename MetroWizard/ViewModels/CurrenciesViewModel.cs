using System.Collections.Generic;
using System.Collections.ObjectModel;
using MetroWizard.Models;

namespace MetroWizard.ViewModels
{

    public class CurrenciesViewModel : ViewModelBase
    {
        public CurrenciesViewModel(object service = null)
        {
            Currencies = new ObservableCollection<ProductCurrencyModel>();

            // you would usually inject a service to retrieve the list of currencies
            //  for this example I've hard coded the values
            var currencies = new List<string>(5)
                                 {
                                     "AUD / USD",
                                     "EUR / USD",
                                     "GBP / USD",
                                     "USD / CAD",
                                     "JPY / USD"
                                 };

            foreach (var currency in currencies)
            {
                Currencies.Add(new ProductCurrencyModel() { IsIncluded = false, Name = currency});
            }
        }

        public ObservableCollection<ProductCurrencyModel> Currencies { get; set; }
    }
}