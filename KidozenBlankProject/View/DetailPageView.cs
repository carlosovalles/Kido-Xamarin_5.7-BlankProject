/*

 Kidozen Blank Project - Xamarin

*/

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
#if __IOS__
using UIKit;
#endif

namespace KidozenBlankProject
{
	public class DetailPageView : ContentPage
	{

		List<Contacts> contacts = new List<Contacts>
		{
			new Contacts("John Doe","john.doe@email.com","+1 (800) 555 5555"),
			new Contacts("Peter Pan","peter.pan@email.com","+1 (800) 555 5555"),
			new Contacts("Diomedez Diaz","diomedez.diaz@email.com","+1 (800) 555 5555"),
			new Contacts("John Doe","john.doe@email.com","+1 (800) 555 5555"),

		};

		public DetailPageView ()
		{
			StackLayout baseLayout = new StackLayout{
				BackgroundColor = Color.White,
			};

			AbsoluteLayout singleListLayout =  new AbsoluteLayout{

				VerticalOptions = LayoutOptions.Start,
			};

			var backButton = new Image
			{
				HeightRequest = 24,
				WidthRequest = 24,
				Source = new FileImageSource { File = "arrowblack.png" },
			};
			backButton.GestureRecognizers.Add(new TapGestureRecognizer((view, args) =>
			{
				Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopModalAsync(true));
			}));
			AbsoluteLayout.SetLayoutBounds(backButton, new Rectangle(12f, 24f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
			singleListLayout.Children.Add (backButton);

			AbsoluteLayout cellLayout;
			cellLayout = new AbsoluteLayout
			{
				BackgroundColor = Color.White,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			ViewCell cell;
			ListView detailListView = new ListView
			{
				ItemsSource = contacts,
				HeightRequest = 390,
				WidthRequest = 345,
				ItemTemplate = new DataTemplate(() =>
					{

						Label nameLabel = new Label();
						nameLabel.SetBinding(Label.TextProperty, "Name" );
						nameLabel.TextColor = Color.FromHex("444F87");
						nameLabel.Font = Font.OfSize("Helvetica-Oblique", 18);

						AbsoluteLayout.SetLayoutBounds(nameLabel, new Rectangle(14f, 6f, AbsoluteLayout.AutoSize,50));
						cellLayout.Children.Add(nameLabel);


						Label phoneLabel = new Label();
						phoneLabel.SetBinding(Label.TextProperty, "PhoneNumber" );
						phoneLabel.TextColor = Color.FromHex("3C3C3C");
						phoneLabel.Font = Font.OfSize("Helvetica-Bold", 12);

						AbsoluteLayout.SetLayoutBounds(phoneLabel, new Rectangle(29f, 34f, AbsoluteLayout.AutoSize,50));
						cellLayout.Children.Add(phoneLabel);

						Label emailLabel = new Label();
						emailLabel.SetBinding(Label.TextProperty, "Email" );
						emailLabel.TextColor = Color.FromHex("3C3C3C");
						emailLabel.Font = Font.OfSize("Helvetica-Bold", 11);

						AbsoluteLayout.SetLayoutBounds(emailLabel, new Rectangle(29f, 56f, AbsoluteLayout.AutoSize,50));
						cellLayout.Children.Add(emailLabel);

						cell = new ViewCell()
						{
							View = new AbsoluteLayout
							{
								Children =
								{
									nameLabel,
									phoneLabel,
									emailLabel,

								}
							}
						};

						cell.View.BackgroundColor = Color.FromHex("FAFAFA");
						// approval.IndexOf
						return cell;

					})
			};

			detailListView.HasUnevenRows = true;
			detailListView.RowHeight = 84;
			AbsoluteLayout.SetLayoutBounds(detailListView, new Rectangle(-6f, 98, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			baseLayout.Children.Add(singleListLayout);
			baseLayout.Children.Add(detailListView);
			Content = baseLayout;

		}
	}
}

