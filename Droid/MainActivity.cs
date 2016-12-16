﻿using Android.OS;
using Android.App;
using Android.Content.PM;

using Java.Interop;

using Xamarin.Forms;

namespace FaceOff.Droid
{
	[Activity(Label = "FaceOff.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		App _app;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);

			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

			LoadApplication(_app = new App());
		}

		#region Xamarin Test Cloud Back Door Methods
#if DEBUG
		[Export("GetPicturePageTitle")]
		public string GetPicturePageTitle()
		{
			return ((NavigationPage)Xamarin.Forms.Application.Current.MainPage).CurrentPage.Title;
		}

		[Export("UseDefaultImageForPhoto1")]
		public void UseDefaultImageForPhoto1()
		{
			_app.UseDefaultImageForPhoto1();
		}

		[Export("UseDefaultImageForPhoto2")]
		public void UseDefaultImageForPhoto2()
		{
			_app.UseDefaultImageForPhoto2();
		}
#endif
		#endregion
	}
}

