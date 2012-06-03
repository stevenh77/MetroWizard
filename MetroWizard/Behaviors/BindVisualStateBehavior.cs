using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Expression.Interactivity;

namespace MetroWizard.Behaviors
{
    public class BindVisualStateBehavior : Behavior<FrameworkElement>
    {
        private bool _initialized;

        public static DependencyProperty StateNameProperty = DependencyProperty.Register("StateName", typeof(string), typeof(BindVisualStateBehavior), new PropertyMetadata(VisualStatePropertyChanged));
        public string StateName { get { return (string)GetValue(StateNameProperty); } set { SetValue(StateNameProperty, value); } }

        public void UpdateVisualState(string visualState)
        {
            if (AssociatedObject == null) return;
            
            FrameworkElement stateTarget;
            if (!VisualStateUtilities.TryFindNearestStatefulControl(AssociatedObject, out stateTarget)) return;

            bool useTransitions = _initialized;
            VisualStateUtilities.GoToState(stateTarget, visualState, useTransitions);
            _initialized = true;
        }

        private static void VisualStatePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ((BindVisualStateBehavior)obj).UpdateVisualState((string)args.NewValue);
        }
    }
}
