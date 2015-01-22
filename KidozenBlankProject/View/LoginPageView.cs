/*

 Kidozen Blank Project - Xamarin

*/

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;


namespace KidozenBlankProject
{
	class LoginPageView : ContentPage
	{
		// Constructor 
		public LoginPageView ()
		{
			StackLayout baseLayout = new StackLayout{
				BackgroundColor = Color.White,
			};

			NavigationPage.SetHasNavigationBar(this, false);

			StackLayout verticalLayout = new StackLayout()
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Spacing = 26,  
			};

			var companyLogo = new Image
			{
				WidthRequest = 60,
				Source = FileImageSource.FromFile("logo.png"),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			verticalLayout.Children.Add(companyLogo);


			Entry userID = new Entry()
			{
				Placeholder = "Email",
				TextColor = Color.Gray,
				WidthRequest = 260,
				HeightRequest = 50,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			verticalLayout.Children.Add(userID);


			Entry userPassword = new Entry()
			{
				Placeholder = "Password",
				TextColor = Color.Gray,
				IsPassword = true,
				WidthRequest = 260,
				HeightRequest = 50,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			verticalLayout.Children.Add(userPassword);
			//
			Button objButton1 = new Button()
			{
				Text = "Log In",
				TextColor = Color.White,
				BackgroundColor = Color.FromHex("444F87"),
				WidthRequest = 180,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				BorderRadius = 0,
				Font = Font.SystemFontOfSize(NamedSize.Large).WithAttributes(FontAttributes.Bold),
			};
			verticalLayout.Children.Add(objButton1);

			// ContentView activityIndicator;

			var indicator = new ActivityIndicator
			{
				Color = Color.Black,
				IsVisible = true,
				HeightRequest=50,
				WidthRequest=50,
			};


			objButton1.Clicked += (sender, e) => { 
				// TO DO: (Try to display the indicator on top of the vertical layout. 
				verticalLayout.Children.Add(indicator);
				indicator.IsRunning = true; 

				KidoManager.SharedInstance.Login(userID.Text, userPassword.Text).ContinueWith(
					t =>
					{
						if (t.Result)
						{
							Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushModalAsync(App.GetMenuPage(), false));
						}else
						{
							indicator.IsRunning = false;
						}
					}
				);
			};

			baseLayout.Children.Add (verticalLayout);
			Content = baseLayout;
		}

		protected override void OnAppearing ()
		{
			Console.Write ("appearing");
		}

		protected override void OnDisappearing ()
		{
			Console.Write ("dis appearing");
		}
	}
}