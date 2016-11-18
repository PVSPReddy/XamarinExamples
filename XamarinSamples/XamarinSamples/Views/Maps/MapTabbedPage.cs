using System;

using Xamarin.Forms;

namespace XamarinSamples
{
	public class MapTabbedPage : TabbedPage
	{
		public MapTabbedPage()
		{
			//var firstpage = new NavigationPage(new MapPCLOne_View()) { Title = "One", Icon = null };



			//Children.Add(firstpage);
			Children.Add(new MapPinsOne_View() { Title = "One", Icon = "Pin.png" });
			Children.Add(new MapPinsOne_View() { Title="Pins", Icon = "Pin.png" });
		}
	}
}

