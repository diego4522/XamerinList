using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class AccountsPage : ContentPage
	{
		public AccountsPage ()
		{
		Title = "Andre";
		Icon = "Contracts.png";
		var label = new Label
		{
			Text = "Andre el Gigante",
			Font = Font.SystemFontOfSize(30),
			WidthRequest = 150,
			HeightRequest = 40
		};
		var label2 = new Label
		{
			Text = "Telefono 9423421",
			Font = Font.SystemFontOfSize(30),
			WidthRequest = 150,
			HeightRequest = 40
		};
		var label3 = new Label
		{
			Text = "Correo andregigan hotmail.com",
			Font = Font.SystemFontOfSize(30),
			WidthRequest = 150,
			HeightRequest = 40
		};
		var button = new Image {

			Source="andre.png",
			WidthRequest = 200,
			HeightRequest = 200
		};

		var entry = new Label {
			Text = " ",
			//BackgroundColor = Color.Blue,
			Font = Font.SystemFontOfSize(30),
			WidthRequest = 150,
			HeightRequest = 40
		};



		Content = new StackLayout {
			Spacing = 10,
			Children = {button, entry, label,label2,label3	}
		};
		}
	}
}