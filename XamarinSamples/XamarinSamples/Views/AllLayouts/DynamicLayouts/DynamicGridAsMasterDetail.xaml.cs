using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class DynamicGridAsMasterDetail : ContentPage
	{
		DynamicGridAsMasterDetail dget;
		StackLayout menuHolder, DetailHolder;
		bool childAdded;
		public DynamicGridAsMasterDetail()
		{
			InitializeComponent();

			dget = this;
			menuHolder = new StackLayout()
			{
				Children = { new Entry {
						Placeholder="this is another",
						PlaceholderColor=Color.Accent,
						BackgroundColor=Color.Blue} },
				//HeightRequest=400,
				//WidthRequest=50,
				BackgroundColor = Color.Maroon,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			DetailHolder = new StackLayout()
			{
				Children = { },
				BackgroundColor = Color.Teal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
		}


		public void OpenMenu(object sender, EventArgs args)
		{
			try
			{
				if (childAdded == false)
				{
					//dynamicGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
					dynamicGrid.Children.Add(dget.menuHolder, 0, 0);
					childAdded = true;
				}
				else
				{
					dynamicGrid.Children.Remove(dget.menuHolder);
					childAdded = false;
				}
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}

		}
		public void AddRowClicked(object sender, EventArgs args)
		{
			try
			{
				if (childAdded == false)
				{
					//dynamicGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
					dynamicGrid.Children.Add(dget.menuHolder, 0, 0);
					childAdded = true;
				}
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}

		}

		public void AddColumnClicked(object sender, EventArgs args)
		{
			try
			{
				if (childAdded == true)
				{
					dynamicGrid.Children.Remove(dget.menuHolder);
					childAdded = false;
				}
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}
		}

	}
}
