[![GitHub release (with filter)](https://img.shields.io/github/v/release/saturdaymp/XPlugins.iOS.BEMCheckBox?sort=semver&label=Latest%20Release)](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/latest)]
[![Nuget](https://img.shields.io/nuget/dt/SaturdayMP.XPlugins.iOS.BEMCheckBox?logo=nuget&label=Downloads)](https://www.nuget.org/packages/SaturdayMP.XPlugins.iOS.BEMCheckBox)]
[![CI](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/actions/workflows/ci.yml/badge.svg)](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/actions/workflows/ci.yml)
[![Release Notes](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/actions/workflows/release-notes.yml/badge.svg)](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/actions/workflows/release-notes.yml)

# XPlugins.iOS.BEMCheckBox
This plugin lets you use the [BEMCheckBox](https://github.com/saturdaymp/BEMCheckBox) in your Xamarin iOS applications.  Below outlines how to get started with BEMCheckBox in Xamarin and some common uses.  For a list of all the features of the please see the BEMCheckBox GitHub [page](https://github.com/saturdaymp/BEMCheckBox).

# Installing
You can find the latest stable version of the BEMCheckBox XPlugin is avaliable via [NuGet](https://www.nuget.org/packages/SaturdayMP.XPlugins.iOS.BEMCheckBox/).  You can find alpha builds from [MyGet](https://www.myget.org/feed/saturdaymp/package/nuget/SaturdayMP.XPlugins.iOS.BEMCheckBox).  If you have any trouble installing please let me know by opening an [issue](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues).

# Quickstart
To create a BEMCheckBox call the constructor with a frame as shown below.

```C#
var checkbox = new SaturdayMP.XPlugins.iOS.BEMCheckBox(new CoreGraphics.CGRect(140, 40, 25, 25));
```

You can modify things such as making the checkbox square:

```C#
checkbox.BoxType = BEMBoxType.Square;
```

You can also change the animation type:

```C#
checkbox.OnAnimationType = BEMAnimationType.Fill;
checkbox.OffAnimationType = BEMAnimationType.Fill;
```

Yes you can set the on and off animation types to be different.  You can set the color:

```C#
checkbox.OnFillColor = UIColor.Red;
```

To change if the checkbox is checked or not:

```C#
// Check to the checkbox.
checkbox.On = true;

// Uncheck the checkbox.
checkbox.On = false;
```

Finally to handle checkbox clicks setup an event:

```C#
private void CheckBoxClickedEvent(object sender, EventArgs eventArgs)
{
  var checkbox = sender as BEMCheckBox;
  if (checkbox == null)
    return;
    
  // Do what you need to do with the checkbox.
}
```

Then subscribe to it:

```C#
checkbox.AnimationDidStopFor += CheckBoxClickedEvent;
```

For a full list of settings such as animation type, colours, etc see the [BEMCheckBox](https://github.com/saturdaymp/BEMCheckBox) page.

You can also play with the BEMCheckBox settings in the [Example Client](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/tree/master/Source/ExampleClient).  To run the Example Client open the source in Visual Studio 2017 and set the Example Client as the startup project.  If the Example Client does not run please [let me know](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues).

# Version Mapping
The version of this BEMCheckBox plugin will match the BEMCheckBox major and minor version number but the patch number might differ.  When possible the patch number will match but if there is an issue with the wrapper that needs to be fixed then the patch number might be higher then the BEMCheckBox version.

| BEMCheckBox | XPlugin | Frameworks/Versions |
| ---:        | ---:    | ---:       |
| [1.4.1](https://github.com/saturdaymp/BEMCheckBox/releases/tag/1.4.1) | [1.4.1](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.1) | Xamarin.iOS/xamarinios10
| [1.4.1](https://github.com/saturdaymp/BEMCheckBox/releases/tag/1.4.1) | [1.4.2](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.2) | Xamarin.iOS/xamarinios10
| [1.4.1](https://github.com/saturdaymp/BEMCheckBox/releases/tag/1.4.1) | [1.4.3](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.3) | Xamarin.iOS/xamarinios10
| [2.0.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.0.0) | [2.0.0](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/2.0.0) | Xamarin.iOS/xamarinios10

# Acknowledgements
Thanks to [Boris Emorine](https://github.com/Boris-Em) for creating the BEMCheckBox.

# Further Reading
## Xamarin
[Walkthrough: Binding an iOS Objective-C Library](https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/walkthrough/)

## Noise from the Basement
Today I Learned How to Create a Xamarin iOS Binding for Objective-C Libraries:
* [Part 1](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-1-compiling-the-objective-c-library/)
* [Part 2](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-2-combining-libraries/)
* [Part 3](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-3-using-sharpie-to-create-binding-interface/)
* [Part 4](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-4-the-actual-binding/)

[Today I Learned How to Automate Objective-c Builds in TeamCity](https://nftb.saturdaymp.com/today-i-learned-how-to-automate-objective-c-builds-in-teamcity/)
