using System;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XamarinSamples.iOS
{
	public class MyTouchTestingRender : UIViewController
	{
		public MyTouchTestingRender()
		{
			NSSet nss = new NSSet();
			UITouch utt = new UITouch();
			UIEvent uie = new UIEvent();
			UITextView uitv = new UITextView();
			uitv.TouchesMoved(nss, uie);
		}

	}
}

