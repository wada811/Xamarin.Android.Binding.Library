using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Binding.Library;
using Newtonsoft.Json;

namespace Xamarin.Android.Binding.Project
{
	[Activity (Label = "Xamarin.Android.Binding.Project", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				TestClass test = new TestClass ();
				test.ABoolean = count % 2 == 0;
				test.ADouble -= count;
				test.AFloat -= count;
				test.ALong -= count;
				test.AnInt += count;
				test.AString = button.Text;
				test.Toast (this, test.ToString());
			};

		}
	}
}


