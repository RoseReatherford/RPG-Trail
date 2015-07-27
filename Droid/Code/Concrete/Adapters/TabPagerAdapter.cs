
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace RPGTrail.Droid
{		
	public class TabPagerAdapter : FragmentPagerAdapter
	{
		private  string[] Titles = {"Home", "Hero Status"};

		public TabPagerAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
		{
		}

		public override Java.Lang.ICharSequence GetPageTitleFormatted (int position)
		{
			return new Java.Lang.String (Titles [position]);
		}
		#region implemented abstract members of PagerAdapter
		public override int Count {
			get {
				return Titles.Length;
			}
		}
		#endregion
		#region implemented abstract members of FragmentPagerAdapter
		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			switch (position) {
			case 0:
				return new HomeTabFragment ();
			case 1: 
				return new HeroStatusTabFragment ();
			}

			return null;
		}
		#endregion
	}
}

