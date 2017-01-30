﻿using System;
namespace Firebase.Auth
{
	public class Loader
	{
		static  Loader ()
		{
			Firebase.InstanceID.Loader.ForceLoad ();
			Firebase.Core.Loader.ForceLoad ();
			Firebase.Analytics.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Messaging
	{
		static Messaging ()
		{
			Firebase.Auth.Loader.ForceLoad ();
		}
	}
}