using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;
using com.refractored;

namespace RPGTrail.Droid
{
	[Activity (Label = "RPGTrail.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.SetContentView (Resource.Layout.Main);

			ViewPager pager = base.FindViewById<ViewPager>(Resource.Id.pager);
			pager.Adapter;

			PagerSlidingTabStrip tabs = base.FindViewById <PagerSlidingTabStrip>(Resource.Id.tabs);
			tabs.SetViewPager (pager);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}

