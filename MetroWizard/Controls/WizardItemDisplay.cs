using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MetroWizard.Controls
{
    public class WizardItemDisplay : Control
    {
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(WizardItemDisplay), null);
        public ImageSource Image { get { return (ImageSource)this.GetValue(ImageProperty); } set { this.SetValue(ImageProperty, value); } }
	
        public static readonly DependencyProperty ImageHeightProperty = DependencyProperty.Register("ImageHeight", typeof(double), typeof(WizardItemDisplay), null);
        public double ImageHeight { get { return (double)this.GetValue(ImageHeightProperty); } set { this.SetValue(ImageHeightProperty, value); } }
    
        public static readonly DependencyProperty ImageWidthProperty = DependencyProperty.Register("ImageWidth", typeof(double), typeof(WizardItemDisplay), null);
        public double ImageWidth { get { return (double)this.GetValue(ImageWidthProperty); } set { this.SetValue(ImageWidthProperty, value); } }
	
		public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(String), typeof(WizardItemDisplay), null);	
		public String Text { get { return (string) this.GetValue(TextProperty); } set { this.SetValue(TextProperty, value); } }

        public WizardItemDisplay()
        {
            ImageHeight = 50;
            ImageWidth = 50;
        }
    }
}
