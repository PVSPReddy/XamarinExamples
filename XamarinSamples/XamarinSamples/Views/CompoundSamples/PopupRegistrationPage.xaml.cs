using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class PopupRegistrationPage : ContentPage
	{
		ObservableCollection<RegistrationDetails> dynamicRegdata;
		List<RegistrationDetails> staticRegData;
		public PopupRegistrationPage()
		{
			InitializeComponent();
			dynamicRegdata = new ObservableCollection<RegistrationDetails>();

			registeredData.ItemsSource = dynamicRegdata;
			registeredData.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
			{
				var data = ((ListView)sender).SelectedItem;
			};
		}

		public void AddNew(object sender, EventArgs args)
		{
			overlayRegForm.IsVisible = true;
			holder.IsEnabled = false;
		}

		public void CloseRegForm(object sender, EventArgs args)
		{
			overlayRegForm.IsVisible = false;
			holder.IsEnabled = true;
		}

		//public void AddNefw(object sender, EventArgs args)
		//{
		//	overlayRegForm.IsVisible = true;
		//}
	}

	public class RegistrationDetails
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string age { get; set; }
		public string mobile { get; set; }
		public string email { get; set; }
		public string states { get; set; }
		public string cities { get; set; }
	}

	public class placeDetails : INotifyPropertyChanged
	{
		public string stateName { get; set; }

		public bool isPlaceToggle = false;

		public List<placeDetails> cityName { get; set; }

		public bool isPlaceToggled
		{
			get
			{
				return isPlaceToggle;
			}
			set
			{
				if (isPlaceToggle != value)
				{
					isPlaceToggle = value;

					PropertyChanged(this, new PropertyChangedEventArgs("isPlaceToggled"));
				}

			}
		}
		public event PropertyChangedEventHandler PropertyChanged = delegate{ };
	}
}
