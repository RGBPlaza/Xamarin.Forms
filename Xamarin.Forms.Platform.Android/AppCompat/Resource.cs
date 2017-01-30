using Android.Runtime;

#if MXBUILD
[assembly: ResourceDesigner("Xamarin.Forms.Resource", IsApplication = false)]
#else
[assembly: ResourceDesigner("Xamarin.Forms.Platform.Android.Resource", IsApplication = false)]
#endif

namespace Xamarin.Forms.Platform.Android
{
	public class Resource
	{
		static Resource()
		{
			ResourceIdManager.UpdateIdValues();
		}

		public class Attribute
		{
			// aapt resource value: 0x7f0100a5
			// ReSharper disable once InconsistentNaming
			// Android is pretty insistent about this casing
			public static int actionBarSize = 2130772133;

			static Attribute()
			{
				ResourceIdManager.UpdateIdValues();
			}

			Attribute()
			{
			}
		}
	}
}