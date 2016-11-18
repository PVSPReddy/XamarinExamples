using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class ImplicitCSharpEx : ContentPage
	{
		public ImplicitCSharpEx()
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
			//var Type2Label = new Style(typeof(Label))
			//{
			//	Setters = {
			//		new Setter{ Property = Label.TextProperty, Value = "This is Style Two-1" },
			//		new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
			//		new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
			//		new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
			//	}
			//};
			//var Type3Label = new Style(typeof(Label))
			//{
			//	Setters = {
			//		new Setter{ Property = Label.TextProperty, Value = "This is Style Three-1" },
			//		new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
			//		new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
			//		new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
			//	}
			//};
			//var Type4Label = new Style(typeof(Label))
			//{
			//	Setters = {
			//		new Setter{ Property = Label.TextProperty, Value = "This is Style Four-1" },
			//		new Setter{ Property = Label.TextColorProperty, Value = Color.Red },
			//		new Setter{ Property = Label.BackgroundColorProperty, Value = Color.Blue },
			//		new Setter{ Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
			//	}
			//};

			Resources = new ResourceDictionary();
			Resources.Add(Type1Label);
			//Resources.Add("Type2Label", Type2Label);
			//Resources.Add("Type3Label", Type3Label);
			//Resources.Add("Type4Label", Type4Label);

			Label type11 = new Label()
			{
			};
			Label type12 = new Label()
			{
				Text = "This is Style One-2",
				TextColor = Color.Aqua,
				BackgroundColor = Color.Red,
			};
			StackLayout holder1 = new StackLayout()
			{
				Children = { type11, type12 }
			};
			Content = holder1;
		}
	}
}
