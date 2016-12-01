using System;
using Flex;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		FLEXManager sharedManager = new FLEXManager();
		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			sharedManager.ShowExplorer();
		}

		public override void MotionEnded (UIEventSubtype motion, UIEvent evt)
		{
			if (motion == UIEventSubtype.MotionShake)
			{
				if ( sharedManager.IsHidden)
					sharedManager.ShowExplorer();
				else
					sharedManager.HideExplorer();
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
