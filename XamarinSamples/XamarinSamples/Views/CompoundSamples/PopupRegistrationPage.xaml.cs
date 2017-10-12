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
			dynamicRegdata = new ObservableCollection<RegistrationDetails>()
			{
				new RegistrationDetails{firstName="df", lastName="dfs", age="34", email="23234dfdf34r", mobile="56464145968", states="dfsds", cities="dfeff" }
			};
			totalMembers.Text = "Total Members Registered" + "\n" + "(" + dynamicRegdata.Count.ToString() + ")";
			registeredData.ItemsSource = dynamicRegdata;
			registeredData.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
			{
				var data = ((ListView)sender).SelectedItem as RegistrationDetails;
				if (data == null)
				{
					return;
				}

				//overlayChooseForm.IsVisible = true;

				//fNameDisplay.Text = data.firstName;
				//lNameDisplay.Text = data.lastName;
				//ageDisplay.Text = data.age;
				//mobile.Text = data.mobile;
				//emailDisplay.Text = data.email;
				//stateDisplay.Text = data.states;
				//cityDisplay.Text = data.cities;

				//overlayDisplayRegForm.IsVisible = true;
				holder.IsEnabled = false;
				((ListView)sender).SelectedItem = null;
			};
		}
		public void DisplayDetailsForm(object sender, EventArgs args)
		{
			//overlayChooseForm.IsVisible = true;
		}
		public void EditDetailsForm(object sender, EventArgs args)
		{
			//overlayEditForm.IsVisible = true;
		}
		public void DeleteDetailsForm(object sender, EventArgs args)
		{
			
		}

		public void AddNew(object sender, EventArgs args)
		{
			overlayRegForm.IsVisible = true;
			holder.IsEnabled = false;
		}
		public void ClearForm(object sender, EventArgs args)
		{
			ClearFormData();
		}
		public void SubmitForm(object sender, EventArgs args)
		{
			//if (true)
			//{
				dynamicRegdata.Add(new RegistrationDetails { firstName = fNameEntry.Text, lastName = lNameEntry.Text, age = ageEntry.Text, email = emailEntry.Text, mobile = mobileEntry.Text, states = stateEntry.Text, cities = cityEntry.Text });
				totalMembers.Text = "Total Members Registered" + "\n" + "(" + dynamicRegdata.Count.ToString() + ")";
				ClearFormData();
			//}
		}
		public void CloseRegForm(object sender, EventArgs args)
		{
			ClearFormData();
			overlayRegForm.IsVisible = false;
			holder.IsEnabled = true;
		}
		public void ClearFormData()
		{
			fNameEntry.Text = string.Empty;
			lNameEntry.Text = string.Empty;
			ageEntry.Text = string.Empty;
			mobileEntry.Text = string.Empty;
			emailEntry.Text = string.Empty;
			stateEntry.Text = string.Empty;
			cityEntry.Text = string.Empty;
		}
		public void CloseDisplayForm(object sender, EventArgs args)
		{
			//overlayDisplayRegForm.IsVisible = false;
			//overlayChooseForm.IsVisible = false;
			//overlayEditForm.IsVisible = false;
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
