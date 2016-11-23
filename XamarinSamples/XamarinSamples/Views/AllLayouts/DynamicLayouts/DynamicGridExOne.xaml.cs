using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class DynamicGridExOne : ContentPage
	{
		public DynamicGridExOne()
		{
			InitializeComponent();
		}

		public void AddRowClicked(object sender, EventArgs args)
		{
			int rows;
			try
			{
				rows = dynamicGrid.RowDefinitions.Count;
				var columns = dynamicGrid.ColumnDefinitions.Count;
				dynamicGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

				if (columns != 0)
				{
					for (int i = 0; i < columns; i++)
					{
						dynamicGrid.Children.Add(new StackLayout()
						{
							Children =
							{
								new Label()
								{
									Text = "Hello World....!",
									BackgroundColor= Color.Olive,
									TextColor = Color.White,
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand
								},
							},
							BackgroundColor = Color.Olive,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							VerticalOptions = LayoutOptions.CenterAndExpand
						}, i, rows);
					}
				}
				else
				{
					dynamicGrid.Children.Add(new StackLayout()
					{
						Children =
							{
								new Label()
								{
									Text = "Hello World....!",
									BackgroundColor= Color.Olive,
									TextColor = Color.White,
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand
								},
							},
						BackgroundColor = Color.Olive,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}, columns, rows);
				}

				var totalSlots = rows * columns;
				var children = dynamicGrid.Children.Count;
				var kids = dynamicGrid.Children.GetEnumerator();
				//var sss = dynamicGrid.Children.IndexOf();
				if (totalSlots != children)
				{
					foreach (var i in dynamicGrid.Children)
					{
						var kidRow = Grid.GetRow(i);
						var kidColumn = Grid.GetColumn(i);
					}
				}

				//dynamicGrid.Children.Add(new Label()
				//{
				//	Text = "Hello World....!",
				//	TextColor = Color.White,
				//	HorizontalOptions = LayoutOptions.CenterAndExpand,
				//	VerticalOptions = LayoutOptions.CenterAndExpand
				//}, columns, rows);
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}

		}
		Label dynamicData;
		public void AddColumnClicked(object sender, EventArgs args)
		{
			try
			{
				var rows = dynamicGrid.RowDefinitions.Count;
				var columns = dynamicGrid.ColumnDefinitions.Count;
				dynamicGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

				if (rows != 0)
				{
					for (int i = 0; i < rows; i++)
					{
						dynamicGrid.Children.Add(new StackLayout()
						{
							Children =
							{
								new Label()
								{
									Text = "Hello World....!",
									BackgroundColor= Color.Olive,
									TextColor = Color.White,
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand
								},
							},
							BackgroundColor = Color.Olive,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							VerticalOptions = LayoutOptions.CenterAndExpand
						}, columns, i);
					}
				}
				else
				{
					dynamicGrid.Children.Add(new StackLayout()
					{
						Children =
							{
								new Label()
								{
									Text = "Hello World....!",
									BackgroundColor= Color.Olive,
									TextColor = Color.White,
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand
								},
							},
						BackgroundColor = Color.Olive,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}, columns, rows);
				}


				//dynamicGrid.Children.Add(new Label()
				//{
				//	Text = "Hello World....!",
				//	TextColor = Color.White,
				//	HorizontalOptions = LayoutOptions.CenterAndExpand,
				//	VerticalOptions = LayoutOptions.CenterAndExpand
				//}, columns, rows);
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}
		}

	}

	//public class Listing
	//{
	//	public string thisName { get; set;}
	//}
}
