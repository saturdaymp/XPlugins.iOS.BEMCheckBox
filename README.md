[![GitHub release (with filter)](https://img.shields.io/github/v/release/saturdaymp/XPlugins.iOS.BEMCheckBox?sort=semver&label=Latest%20Release&labelColor=3C444C&logoColor=959DA5&logo=GitHub)](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/latest)
[![Nuget](https://img.shields.io/nuget/dt/SaturdayMP.XPlugins.iOS.BEMCheckBox?logo=nuget&label=Downloads&labelColor=3C444C&logoColor=959DA5)](https://www.nuget.org/packages/SaturdayMP.XPlugins.iOS.BEMCheckBox)
[![CI](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/actions/workflows/ci.yml/badge.svg)](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/actions/workflows/ci.yml)
[![GitHub Sponsors](https://img.shields.io/github/sponsors/saturdaymp?label=Sponsors&logo=githubsponsors&labelColor=3C444C)](https://github.com/sponsors/saturdaymp)

# XPlugins.iOS.BEMCheckBox
This .NET iOS binding library lets you use the [BEMCheckBox](https://github.com/saturdaymp/BEMCheckBox) framework in your .NET iOS applications.  This README outlines how to get started with BEMCheckBox in .NET and some common uses.  For a list of all features, please see the BEMCheckBox GitHub [page](https://github.com/saturdaymp/BEMCheckBox).

# Installing
XPlugins is a NuGet Package and can be installed using the dotnet command line:

```
dotnet add package SaturdayMP.XPlugins.iOS.BEMCheckBox
```

You can find other ways to install the latest stable version of the BEMCheckBox XPlugin on [NuGet](https://www.nuget.org/packages/SaturdayMP.XPlugins.iOS.BEMCheckBox/).  You can find work in progress (WIP) and alpha builds on [MyGet](https://www.myget.org/feed/saturdaymp/package/nuget/SaturdayMP.XPlugins.iOS.BEMCheckBox).  If you have any trouble installing, please let me know by opening an [issue](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues).

# Quickstart
To create a BEMCheckBox, call the constructor with a frame as shown below.

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

Yes, you can set the on and off animation types to be different.  You can set the color:

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

Finally, to handle the checkbox click event set up an event:

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

## Running the Example Client

You can also play with the BEMCheckBox settings in the [Example Client](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/tree/main/Source/ExampleClient).

### From an IDE
Open the solution in Visual Studio for Mac, Visual Studio, or your preferred .NET IDE and set the Example Client as the startup project, then run it (F5).

### From the Command Line
Building and running iOS applications from the command line requires an IDE. The recommended approach is:

1. Build the solution to verify it compiles:
   ```bash
   cd Source
   dotnet build -c Debug
   ```

2. Open the solution in Visual Studio and run the ExampleClient from there.

**Note:** Running iOS applications requires macOS with Xcode installed. Command-line execution of iOS apps is not directly supported by the .NET CLI and requires using an IDE or additional tools like `simctl`.

# Version Mapping
Below is the mapping of the BEMCheckBox version used in the XPlugin wrapper version along with the Xamarin/.NET version.

The .NET version lists the minimum .NET and iOS versions required.  For example, `net10.0-ios` with minimum iOS 18.0 means the XPlugin will work with .NET 10.0 and iOS 18.0 or higher (e.g. it will work with .NET 10, .NET 11, .NET 12, and iOS 18, iOS 19, iOS 20).

Starting with version 8, the XPlugin version will match the .NET release it is targeting.

|                                                                            XPlugin |                                                           BEMCheckBox | Frameworks/Minimum Version |
|-----------------------------------------------------------------------------------:|----------------------------------------------------------------------:|---------------------------:|
| [9.0.0](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/9.0.0) | [2.2.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.2.0) |        .NET/net9.0-ios18.0 |
| [8.0.0](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/8.0.0) | [2.2.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.2.0) |        .NET/net8.0-ios18.0 |
| [3.1.0](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/3.1.0) | [2.0.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.0.0) |        .NET/net6.0-ios12.0 |
| [3.0.1](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/3.0.1) | [2.0.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.0.0) |        .NET/net6.0-ios12.0 |
| [3.0.0](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/3.0.0) | [2.0.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.0.0) |        .NET/net6.0-ios16.1 |
| [2.0.0](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/2.0.0) | [2.0.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/2.0.0) |   Xamarin.iOS/xamarinios10 |
| [1.4.3](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.3) | [1.4.1](https://github.com/saturdaymp/BEMCheckBox/releases/tag/1.4.1) |   Xamarin.iOS/xamarinios10 |
| [1.4.2](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.2) | [1.4.1](https://github.com/saturdaymp/BEMCheckBox/releases/tag/1.4.1) |   Xamarin.iOS/xamarinios10 |
| [1.4.1](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.1) | [1.4.1](https://github.com/saturdaymp/BEMCheckBox/releases/tag/1.4.1) |   Xamarin.iOS/xamarinios10 |

If you spot any issues with the versioning table or a version combination you need is not listed, even unsupported versions, let me know by opening an [issue](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues).

# Acknowledgements
Thanks to [Boris Emorine](https://github.com/Boris-Em) for creating the BEMCheckBox.

# Further Reading

### Build the Xamarin lipo bundle (XPlugin 3.1.0 and earlier)

**Microsoft Learning:**
[Walkthrough: Bind an iOS Swift library](https://learn.microsoft.com/xamarin/ios/platform/binding-swift/walkthrough)

**Blog Posts:**
* [Part 1](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-1-compiling-the-objective-c-library/)
* [Part 2](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-2-combining-libraries/)
* [Part 3](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-3-using-sharpie-to-create-binding-interface/)
* [Part 4](https://nftb.saturdaymp.com/today-i-learned-how-to-create-a-xamarin-ios-binding-for-objective-c-libraries-part-4-the-actual-binding/)
* [Today I Learned How to Automate Objective-C Builds in TeamCity](https://nftb.saturdaymp.com/today-i-learned-how-to-automate-objective-c-builds-in-teamcity/)