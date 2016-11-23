using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace XamarinSamples
{
	public partial class EntryBehaviourCSharpEx : ContentPage
	{
		public EntryBehaviourCSharpEx()
		{
			InitializeComponent();
			my_Entry = new Entry()
			{
				Placeholder = "This is not Behaviours Ex",
				PlaceholderColor = Color.Black,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			_my_Entry = new MyEntry()
			{
				Placeholder = "This is Behaviours Ex",
				PlaceholderColor = Color.Black,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			_my_Entry.Behaviors.Add(new NumericValidator());
			_my_Entry_ = new Entry()
			{
				Placeholder = "This is Behaviours Ex",
				PlaceholderColor = Color.Black,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			_my_Entry_.Behaviors.Add(new NumericValidators());
			my_Label = new Label()
			{
				Text = "",
				FontSize = 8,
				TextColor = Color.Red,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			//my_Entry.Behaviors.Add(new NumericValidator());


			my_Entry.Focused += (object sender, FocusEventArgs e) =>
			{
				my_Entry.TextChanged += onTextChanging;
			};
			my_Entry.Unfocused += (object sender, FocusEventArgs e) =>
			{
				my_Entry.TextChanged -= onTextChanging;
			};
			StackLayout holder1 = new StackLayout()
			{
				Children = { my_Entry, my_Label, _my_Entry, _my_Entry_ },
				Padding = new Thickness(10, 20, 10, 5),
				BackgroundColor = Color.Teal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			StackLayout holder = new StackLayout()
			{
				Children = { holder1 },
				Padding = new Thickness(10, 20, 10, 5),
				BackgroundColor = Color.Teal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			Content = holder;
		}
		Entry my_Entry, _my_Entry_;
		MyEntry _my_Entry;
		Label my_Label;
		void onTextChanging(object sender, TextChangedEventArgs e)
		{
			//string value = ((Entry)sender).Text;
			//bool valid = Regex.IsMatch(value, @"^[1-9][\d]{0-9}$");
			double result;
			bool isValid = double.TryParse(e.NewTextValue, out result);
			//((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
			if (isValid != true)
			{
				((Entry)sender).TextColor = Color.Red;
				my_Label.Text = "* only Numbers are Allowed";
				my_Label.IsVisible = true;
			}
			else
			{
				((Entry)sender).TextColor = Color.Default;
				my_Label.IsVisible = false;
			}

			if (((Entry)sender).Text == null || ((Entry)sender).Text == "")
			{
				((Entry)sender).TextColor = Color.Default;
				my_Label.IsVisible = false;
			}
			//my_Entry.TextChanged -= onTextChanging;
		}
	}


	#region this is for InBuiltEntry
	public class NumericValidators : Behavior<Entry>
	{
		//Entry myEntry = new Entry();
		protected override void OnAttachedTo(Entry myEntry)
		{
			myEntry.TextChanged += onTextChanged;
			base.OnAttachedTo(myEntry);
		}

		protected override void OnDetachingFrom(Entry myEntry)
		{
			myEntry.TextChanged -= onTextChanged;
			base.OnDetachingFrom(myEntry);
		}

		void onTextChanged(object sender, TextChangedEventArgs e)
		{
			double result;
			bool isValid = double.TryParse(e.NewTextValue, out result);
			((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
			//if(isValid != true)
			//{
			//	((Entry)sender).TextColor = Color.Red;
			//}

		}
	}
	#endregion

	public class MyEntry : Entry
	{
		
	}

	public class NumericValidator : Behavior<MyEntry>
	{
		//Entry myEntry = new Entry();
		protected override void OnAttachedTo(MyEntry myEntry)
		{
			myEntry.TextChanged += onTextChanged;
			base.OnAttachedTo(myEntry);
		}

		protected override void OnDetachingFrom(MyEntry myEntry)
		{
			myEntry.TextChanged -= onTextChanged;
			base.OnDetachingFrom(myEntry);
		}

		void onTextChanged(object sender, TextChangedEventArgs e)
		{
			double result;
			bool isValid = double.TryParse(e.NewTextValue, out result);
			((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
			//if (isValid != true)
			//{
			//	((MyEntry)sender).TextColor = Color.Red;
			//}
			//else
			//{
				
			//}
		}
	}
}
