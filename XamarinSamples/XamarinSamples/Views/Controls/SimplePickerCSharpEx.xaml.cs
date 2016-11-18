using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class SimplePickerCSharpEx : ContentPage
	{
		public SimplePickerCSharpEx()
		{
			InitializeComponent();
			BoxView boxes = new BoxView()
			{
				Color = Color.Accent,
				WidthRequest = 100,
				HeightRequest = 100,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Dictionary<string, Color> selectColor = new Dictionary<string, Color>()
			{
				{"Accent", Color.Accent},
				{"Blue", Color.Blue},
				{"Olive", Color.Olive},
				{"Green", Color.Green},
				{"Navy", Color.Navy},
				{"Teal", Color.Teal},
				{"Yellow", Color.Yellow},
				{"Maroon", Color.Maroon}
			};

			Picker colorPick = new Picker()
			{
				Title = "Choose Any One Color",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			foreach (string p in selectColor.Keys)
			{
				colorPick.Items.Add(p);
			}

			colorPick.SelectedIndexChanged += (object sender, EventArgs e) =>
			{
				var value = ((Picker)sender).SelectedIndex;

				if (value == -1)
				{
					boxes.Color = Color.Default;
				}
				else
				{
					string colorName = colorPick.Items[colorPick.SelectedIndex];
					boxes.Color = selectColor[colorName];
				}
			};

			StackLayout holder = new StackLayout()
			{
				Children = { colorPick, boxes },
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Content = holder;

		}
	}
}
