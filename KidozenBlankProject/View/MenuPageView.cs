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

		//Mocked-up Data
		List<BlankProjectMenuItems> menuItems = new List<BlankProjectMenuItems>
		{
			new BlankProjectMenuItems("CONTACS", Color.FromHex("FC8D2C")),
			new BlankProjectMenuItems("DOCUMENTS",Color.FromHex("4E9A40")),
			new BlankProjectMenuItems("?", Color.FromHex("154A7C")),
			new BlankProjectMenuItems("?", Color.FromHex("718087")),

		};



		public MenuPageView()
		{            
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

			// To query for DataSources
			// KidoManager.SharedInstance.GeItems();
		}

		//Drawing the Box View dinamically
		void DrawBoxView()
		{
			var companyLogo = new Image
			{
				WidthRequest = 120,
				Source = FileImageSource.FromFile("iff_logo.png"),
			};

			mainLayout.Children.Add(companyLogo);

			Grid grid = new Grid()
			{
				Padding = new Thickness(17, 0, 17, 0),
			};
			grid.RowDefinitions.Add(new RowDefinition());

			int i = 0, r = 0;
			foreach (BlankProjectMenuItems item in menuItems)
			{
				grid.Children.Add(
					new Button()
					{
						Text = item.Type,
						TextColor = Color.White,
						Font = Font.SystemFontOfSize(NamedSize.Medium),
						BackgroundColor = item.ApprovalColor,
						BorderRadius = 0,
						WidthRequest = 180,
						HeightRequest = 180,
						MinimumHeightRequest = 140,
						MinimumWidthRequest = 140,
						HorizontalOptions = LayoutOptions.StartAndExpand,
						Command = new Command(() =>
							{
								//Xamarin.Forms.Device.BeginInvokeOnMainThread(() => NavigationPage.PushAsync(App.GetDetailPage(), true));
								Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushModalAsync(App.GetDetailPage(),true));
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