using System;
using System.Collections.Generic;
using Foundation;

namespace Xamarin.Forms.Platform.iOS
{
	internal interface IAccessibilityElementsController
	{
		List<NSObject> GetAccessibilityElements();
	}
}