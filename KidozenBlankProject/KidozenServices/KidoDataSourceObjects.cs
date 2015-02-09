/*

 Kidozen Blank Project - Xamarin

*/

using System;
using Xamarin.Forms;

namespace KidozenBlankProject
{
	public class XamarinMenu
	{
		public XamarinMenu(string type, string color, string datasource_name) 
		{ 
			this.Type = type; 
			this.Color = color; 
			this.DataSourceName = datasource_name; 
		}
		public string Type { set; get; }
		public string Color { set; get; }
		public string DataSourceName { set; get; }
	};

	public class Contacts
	{
		public string Name { set; get; }
		public string LastName { set; get; }
		public string Email { set; get; }
		public string Avatar { set; get; }
		public string Location { set; get; }
		public string Mobile { set; get; }
	};


}
