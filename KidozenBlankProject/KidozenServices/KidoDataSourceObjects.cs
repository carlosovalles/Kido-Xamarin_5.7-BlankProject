/*

 Kidozen Blank Project - Xamarin

*/

using System;
using Xamarin.Forms;

namespace KidozenBlankProject
{
	public class BlankProjectMenuItems
	{
		public BlankProjectMenuItems(string approvalType, Color approvalColor)
		{
			this.Type = approvalType;
			this.ApprovalColor = approvalColor;
		}
		public string Type { private set; get; }
		public Color ApprovalColor { private set; get; }
	};

	public class Contacts
	{
		public Contacts(string name, string email, string phoneNumber)
		{
			this.Name = name;
			this.Email = email;
			this.PhoneNumber = phoneNumber;
		}
		public string Name { private set; get; }
		public string Email { private set; get; }
		public string PhoneNumber { private set; get; }


	};


}

