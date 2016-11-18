using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class RelativeLayoutCSharpEx : ContentPage
	{
		public RelativeLayoutCSharpEx()
		{
			InitializeComponent();

			BoxView box1 = new BoxView()
			{
				BackgroundColor = Color.Navy,
				//HeightRequest = 100,
				//WidthRequest = 100
			};

			BoxView box2 = new BoxView()
			{
				BackgroundColor = Color.Maroon,
				//HeightRequest = 100,
				//WidthRequest = 100
			};

			BoxView box3 = new BoxView()
			{
				BackgroundColor = Color.Gray,
				//HeightRequest = 100,
				//WidthRequest = 100
			};

			BoxView box4 = new BoxView()
			{
				BackgroundColor = Color.Green,
				//HeightRequest = 100,
				//WidthRequest = 100
			};



			RelativeLayout relativeHolder = new RelativeLayout()
			{
				BackgroundColor = Color.Teal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			relativeHolder.Children.Add(box1,
										Constraint.RelativeToParent((parent) => { return (0.2 * parent.Width); }),
										Constraint.RelativeToParent((parent) => { return (0.2 * parent.Height); }),
										Constraint.Constant(100),
										Constraint.Constant(100)
									   );

			relativeHolder.Children.Add(box2,
										Constraint.RelativeToParent((parent) => { return (0.2 * parent.Width); }),
										Constraint.RelativeToParent((parent) => { return (0.2 * parent.Height); }),
										Constraint.Constant(50),
										Constraint.Constant(50)
									   );

			relativeHolder.Children.Add(box3,
										Constraint.RelativeToParent((parent) => { return (0.5 * parent.Width + 40); }),
										Constraint.RelativeToParent((parent) => { return (0.5 * parent.Height - 150); }),
										Constraint.RelativeToParent((parentsss) => { return (0.1 * parentsss.Width); }),
										Constraint.Constant(70)
									   );

			relativeHolder.Children.Add(box4,
										Constraint.RelativeToParent((parents) => { return (0.4 * parents.Width); }),
										Constraint.RelativeToParent((parentss) => { return (0.4 * parentss.Height); }),
										Constraint.RelativeToParent((parentsss) => { return (0.4 * parentsss.Width); }),
										Constraint.RelativeToParent((parentssss) => { return (0.45 * parentssss.Height); })
									   );

			StackLayout holder = new StackLayout()
			{
				Children = { relativeHolder },
				Padding = new Thickness(10, 20, 10, 10),
				BackgroundColor = Color.Olive,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Content = holder;
		}
	}
}
