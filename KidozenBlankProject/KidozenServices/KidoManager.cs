/*

 Kidozen Blank Project - Xamarin

*/

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json.Linq;
using Kidozen;

// Directives to load the Kidozen SDK according to the Mobile OS
#if __IOS__
using Kidozen.iOS;
#else
using Kidozen.Android;
using Android.Content;
#endif

namespace KidozenBlankProject
{
	public class KidoManager
	{
		static KidoManager singleton;
		static object locker = new object();

		public static KidoManager SharedInstance
		{
			get
			{
				if (singleton == null)
					singleton = new KidoManager();
				return singleton;
			}
		}

		public KidoApplication Kido
		{
			get;
			set;
		}

		public KidoManager()
		{
			Kido = new KidoApplication(KidoSettings.Marketplace, KidoSettings.Application, KidoSettings.Key);
		}


		public Task<Boolean> Login(string user, string password)
		{

			var authTask = Kido.Authenticate(user, password, "Kidozen");

			return authTask.ContinueWith(
				t =>
				{
					// if t fails you could get the exception t.Exception.GetBaseException();
					return !t.IsFaulted;
				}
			);
		}
	}
}

