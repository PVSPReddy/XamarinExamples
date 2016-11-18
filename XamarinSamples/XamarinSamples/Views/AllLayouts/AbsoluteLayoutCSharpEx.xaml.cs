using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class AbsoluteLayoutCSharpEx : ContentPage
	{
		AbsoluteLayout holder;
		StackLayout stackHolder1, stackHolder2;
		public AbsoluteLayoutCSharpEx()
		{
			InitializeComponent();
			Label sh1Text = new Label()
			{
				Text = "This is on background stack layout",
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White,

			};

			Label sh1FirstName = new Label()
			{
				Text = "First Name",
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			Entry sh1FirstNameE = new Entry()
			{
				Placeholder = "Enter your FirstName",
				TextColor = Color.Green,
				BackgroundColor = Color.Gray,
				HorizontalOptions = LayoutOptions.EndAndExpand
			};
			StackLayout sh1FNStack = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = { sh1FirstName, sh1FirstNameE },

				IsVisible = true
			};

			Label sh1LastName = new Label()
			{
				Text = "Last Name",
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			Entry sh1LastNameE = new Entry()
			{
				Placeholder = "Enter your LastName",
				TextColor = Color.Green,
				BackgroundColor = Color.Gray,
				HorizontalOptions = LayoutOptions.EndAndExpand
			};
			StackLayout sh1LNStack = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = { sh1LastName, sh1LastNameE },

				IsVisible = true
			};

			Label sh1MobileNo = new Label()
			{
				Text = "Mobile Number",
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			Entry sh1MobileNoE = new Entry()
			{
				Placeholder = "Enter your Mobile No",
				TextColor = Color.Green,
				BackgroundColor = Color.Gray,
				HorizontalOptions = LayoutOptions.EndAndExpand
			};
			StackLayout sh1MNStack = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = { sh1MobileNo, sh1MobileNoE },

				IsVisible = true
			};

			Label sh1Age = new Label()
			{
				Text = "Age",
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			Entry sh1AgeE = new Entry()
			{
				Placeholder = "Enter your Age          ",
				TextColor = Color.Green,
				BackgroundColor = Color.Gray,
				HorizontalOptions = LayoutOptions.EndAndExpand
			};
			StackLayout sh1AgeStack = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = { sh1Age, sh1AgeE },

				IsVisible = true
			};

			Entry sh1Entry = new Entry()
			{
				Placeholder = "Testing this with absolute Layout",
				TextColor = Color.Green,
				BackgroundColor = Color.Gray,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			Button sh1Button = new Button()
			{
				Text = "OPen Hidden View",
				TextColor = Color.White,
				HeightRequest = 30,
				WidthRequest = 20,
				BackgroundColor = Color.Maroon,
				Command = new Command((obj) =>
				{
					stackHolder2.IsVisible = true;
				})
			};


			Label sh2Text = new Label()
			{
				Text = "This is on background stack layout",
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White
			};

			Button sh2Button = new Button()
			{
				Text = "This is on background stack layout",
				TextColor = Color.White,
				BackgroundColor = Color.Maroon
			};
			sh2Button.Clicked += (object sender, EventArgs e) =>
			{
				stackHolder2.IsVisible = false;
			};



			stackHolder1 = new StackLayout()
			{
				Padding = new Thickness(20, 20, 10, 0),
				Children = { sh1Text, sh1FNStack, sh1LNStack, sh1MNStack, sh1AgeStack, sh1Entry, sh1Button },
				BackgroundColor = Color.Teal,
				IsVisible = true
			};

			stackHolder2 = new StackLayout()
			{
				Children = { sh2Text, sh2Button },
				BackgroundColor = Color.Accent,
				IsVisible = false
			};

			holder = new AbsoluteLayout()
			{
				Padding = new Thickness(0, 20, 0, 0),
				BackgroundColor = Color.Olive
			};

			AbsoluteLayout.SetLayoutFlags(stackHolder1, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(stackHolder1, new Rectangle(0, 0, 1, 1));
			holder.Children.Add(stackHolder1);

			holder.Children.Add(stackHolder2, new Rectangle(0.4, 0.3, 0.9, 0.8), AbsoluteLayoutFlags.All);

			Content = holder;
		}
	}
}