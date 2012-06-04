using System;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using MetroWizard.Models;

namespace MetroWizard.ViewModels
{
    public class IdentifiersViewModel : ViewModelBase
    {
        private readonly AbstractValidator<IdentifiersModel> _validator;
        private readonly IdentifiersModel _model;

        public IdentifiersViewModel(IdentifiersModel model, AbstractValidator<IdentifiersModel> validator)
        {
            if (model == null) throw new ArgumentNullException("model");
            if (validator == null) throw new ArgumentNullException("validator");

            _model = model;
            _validator = validator;
        }

        private const string ISINProperty = "ISIN";
        public string ISIN
        {
            get { return _model.ISIN; }
            set
            {
                if (_model.ISIN != value)
                {
                    _model.ISIN = value;
                    NotifyPropertyChanged(ISINProperty);
                }

                ClearError(ISINProperty);
                ValidationResult validationResult = _validator.Validate(_model, ISINProperty);
                if (!validationResult.IsValid)
                    validationResult.Errors.ToList().ForEach(x => SetError(ISINProperty, x.ErrorMessage));
            }
        }

        private const string MICProperty = "MIC";
        public string MIC
        {
            get { return _model.MIC; }
            set
            {
                if (_model.MIC != value)
                {
                    _model.MIC = value;
                    NotifyPropertyChanged(MICProperty);
                }

                ClearError(MICProperty);
                ValidationResult validationResult = _validator.Validate(_model, MICProperty);
                if (!validationResult.IsValid)
                    validationResult.Errors.ToList().ForEach(x => SetError(MICProperty, x.ErrorMessage));
            }
        }
    }
}