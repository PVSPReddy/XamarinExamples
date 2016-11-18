using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class MainPage : ContentPage
	{
		protected override void OnAppearing()
		{
			base.OnAppearing();
			NavigationPage.SetHasNavigationBar(this, false);
		}
		public MainPage()
		{
			InitializeComponent();
			TapGestureRecognizer gst = new TapGestureRecognizer();
			gst.NumberOfTapsRequired = 1;
			gst.Tapped += GoToPage;
			allLayouts.GestureRecognizers.Add(gst);
			maps.GestureRecognizers.Add(gst);
			styles.GestureRecognizers.Add(gst);
			controls.GestureRecognizers.Add(gst);
		}

		public void GoToPage(object sender, EventArgs args)
		{
			//DisplayAlert("Alert", "You Just have Touched a Styled TapGesture", "Cancel");

			var data = sender as Label;
			switch (data.Text)
			{
					case "Different Types Of Layouts":
					Navigation.PushAsync(new AllLayoutsMainPage());
					//Navigation.PushModalAsync(new NavigationPage(new AllLayoutsMainPage()));
					break;
					
					case "Maps Page":
					Navigation.PushAsync(new MapTabbedPage());
					//Navigation.PushModalAsync(new NavigationPage(new MapTabbedPage()));
					break;
					
					case "Styles Examples Page":
					Navigation.PushAsync(new MainStylesPage());
					//Navigation.PushModalAsync(new NavigationPage(new MainStylesPage()));
					break;

					case "Controls Examples Page":
					Navigation.PushAsync(new SimplePickerCSharpEx());
					//Navigation.PushModalAsync(new NavigationPage(new MainStylesPage()));
					break;
			}

		}
	}
}
