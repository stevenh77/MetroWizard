using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MetroWizard.Controls
{
	public class ImageButton : Button
	{
		public ImageButton()
		{
			DefaultStyleKey = typeof(ImageButton);
			MouseEnter += (o, args) => Cursor = Cursors.Hand;
			MouseLeave += (o, args) => Cursor = Cursors.None;
		}
	
		public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(ImageButton), null);
		public ImageSource Image { get { return (ImageSource)this.GetValue(ImageProperty); } set { this.SetValue(ImageProperty, value); } }
	
		public static readonly DependencyProperty PressedImageProperty = DependencyProperty.Register("PressedImage", typeof(ImageSource), typeof(ImageButton), null);	
		public ImageSource PressedImage { get { return (ImageSource)this.GetValue(PressedImageProperty); } set { this.SetValue(PressedImageProperty, value); } }
    }
}