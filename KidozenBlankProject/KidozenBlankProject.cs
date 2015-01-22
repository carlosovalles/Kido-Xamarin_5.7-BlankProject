/*

 Kidozen Blank Project - Xamarin

*/

using System;
using BlankKidozenProject;
using Xamarin.Forms;

namespace KidozenBlankProject
{
	public class App
	{
		public static Page GetLoginPage()
		{
			return new LoginPageView();
		}
		public static Page GetMenuPage()
		{
			return new MenuPageView();
		}
		public static Page GetDetailPage()
		{
			return new DetailPageView();
		}
	}
}