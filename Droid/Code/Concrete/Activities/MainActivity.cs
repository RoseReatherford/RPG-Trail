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
using Android.Support.V4.App;

namespace RPGTrail.Droid
{
	[Activity (Label = "RPGTrail.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : BaseActivity
	{
		#region implemented abstract members of BaseActivity

		protected override int LayoutResource {
			get {
				return Resource.Layout.main;
			}
		}

		#endregion

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			ViewPager pager = base.FindViewById<ViewPager>(Resource.Id.pager);
			pager.Adapter = new TabPagerAdapter(SupportFragmentManager);

			PagerSlidingTabStrip tabs = base.FindViewById <PagerSlidingTabStrip>(Resource.Id.tabs);
			tabs.SetViewPager (pager);

		}
	}
}

