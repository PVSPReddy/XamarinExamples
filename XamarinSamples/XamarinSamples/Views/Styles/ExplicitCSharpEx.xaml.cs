using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class ExplicitCSharpEx : ContentPage
	{
		public ExplicitCSharpEx()
		{
			InitializeComponent();

			var Type1Label = new Style(typeof(Label))
			{
				Setters = {
					new Setter{ Property = Label.TextProperty, Value = "This is Style One-1" },
					new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
					new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
					new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
				}
			};
			var Type2Label = new Style(typeof(Label))
			{
				Setters = {
					new Setter{ Property = Label.TextProperty, Value = "This is Style Two-1" },
					new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
					new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
					new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
				}
			};
			var Type3Label = new Style(typeof(Label))
			{
				Setters = {
					new Setter{ Property = Label.TextProperty, Value = "This is Style Three-1" },
					new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
					new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
					new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
				}
			};
			var Type4Label = new Style(typeof(Label))
			{
				Setters = {
					new Setter{ Property = Label.TextProperty, Value = "This is Style Four-1" },
					new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
					new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
					new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
				}
			};


			Resources = new ResourceDictionary();
			Resources.Add("Type1Label", Type1Label);
			Resources.Add("Type2Label", Type2Label);
			Resources.Add("Type3Label", Type3Label);
			Resources.Add("Type4Label", Type4Label);


			Label type11 = new Label()
			{
				Style = (Style)Resources["Type1Label"]
			};
			Label type12 = new Label()
			{
				Text = "This is Style One-2",
				TextColor = Color.Aqua,
				BackgroundColor = Color.Red,
				Style = (Style)Resources["Type1Label"]
			};
			Label type21 = new Label()
			{
				Style = (Style)Resources["Type2Label"]
			};
			Label type22 = new Label()
			{
				Text = "This is Style Two-2",
				TextColor = Color.White,
				BackgroundColor = Color.Teal,
				Style = (Style)Resources["Type2Label"]
			};


			StackLayout holder1 = new StackLayout()
			{
				Children = { type11, type12, type21, type22 }
			};


			Label type31 = new Label()
			{
				Style = Type3Label
			};
			Label type32 = new Label()
			{
				Text = "This is Style Three-2",
				TextColor = Color.Aqua,
				BackgroundColor = Color.Red,
				Style = Type3Label
			};
			Label type41 = new Label()
			{
				Style = Type4Label
			};
			Label type42 = new Label()
			{
				Text = "This is Style Four-2",
				TextColor = Color.White,
				BackgroundColor = Color.Teal,
				Style = Type4Label
			};

			StackLayout holder2 = new StackLayout()
			{
				Children = { type31, type32, type41, type42 }
			};

			StackLayout holder = new StackLayout()
			{
				Padding = new Thickness(0, 20, 0, 0),
				Children = { holder1, holder2 }
			};

			Content = holder;
		}
	}
}
