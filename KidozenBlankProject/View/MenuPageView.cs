/*

 Kidozen Blank Project - Xamarin

*/

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using KidozenBlankProject;
#if __IOS__
using UIKit;
#endif

namespace BlankKidozenProject
{
	public class MenuPageView : ContentPage
	{
		StackLayout boxedLayout;
		StackLayout mainLayout;

		List<XamarinMenu> menuItems = new List<XamarinMenu>() {
			new XamarinMenu("CONTACTS", "FC8D2C", "datasource name"), 
			new XamarinMenu("DOCUMENTS", "4E9A40", "datasource name"), 
			new XamarinMenu("OTHER 1", "154A7C", "datasource name"), 
			new XamarinMenu("OTHER 2", "718087", "datasource name")
		};
		
		public MenuPageView()
		{            
			// ENABLE THIS TO READ A MENU DATA SOURCE FROM INSTANCE:
			//var ds = KidoManager.SharedInstance.Kido.DataSource("xamarinMenu");
			//menuItems = ds.Query<List<XamarinMenu>>().Result;

			NavigationPage.SetHasNavigationBar(this, false);
			boxedLayout = new StackLayout();
			mainLayout = new StackLayout()
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Spacing = 26,  
			};

			this.DrawBoxView();
			#if __IOS__
			UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.Default;
			#endif

		}

		//Drawing the Box View dinamically
		void DrawBoxView()
		{
			var companyLogo = new Image
			{
				WidthRequest = 50,
				Source = FileImageSource.FromFile("logo.png"),
			};

			mainLayout.Children.Add(companyLogo);

			Grid grid = new Grid()
			{
				Padding = new Thickness(17, 0, 17, 0),
			};
			grid.RowDefinitions.Add(new RowDefinition());

			int i = 0, r = 0;
			foreach (XamarinMenu item in menuItems)
			{
				grid.Children.Add(
					new Button()
					{
						Text = item.Type,
						TextColor = Color.White,
						Font = Font.SystemFontOfSize(NamedSize.Medium),
						BackgroundColor = Color.FromHex(item.Color),
						BorderRadius = 0,
						WidthRequest = 180,
						HeightRequest = 180,
						MinimumHeightRequest = 140,
						MinimumWidthRequest = 140,
						HorizontalOptions = LayoutOptions.StartAndExpand,
						Command = new Command(() =>
							{
								Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushModalAsync(App.GetDetailPage(item),false));
							}),
					},i, r);
				i+=1;
				if (i == 2){ i = 0; r += 1; }                    
			}
			mainLayout.Children.Add(grid);       

			// Adding Layout to the Content
			boxedLayout.BackgroundColor = Color.White;
			boxedLayout.Children.Add(mainLayout);

			this.Content = boxedLayout;
		}
	}
}
