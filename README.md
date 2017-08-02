# XPlugins.iOS.BEMCheckBox
This plugin lets you use the excellent [BEMCheckBox](https://github.com/Boris-Em/BEMCheckBox) in your Xamarin iOS applications.  Below outlines how to get started with BEMCheckBox in Xamarin and some common uses.  For a list of all the features of the please see the [BEMCheckBox GitHub page](https://github.com/Boris-Em/BEMCheckBox).

# Installing
You can find the latest stable version of the BEMCheckBox XPlugin is avaliable via [NuGet](https://www.nuget.org/packages/SaturdayMP.XPlugins.iOS.BEMCheckBox/).  You can find alpha builds from [MyGet](https://www.myget.org/feed/saturdaymp/package/nuget/SaturdayMP.XPlugins.iOS.BEMCheckBox).  If you have any trouble installing please let me know by opening a [issue](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues).

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

Finlly to handle checkbox clicks setup an event:

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
checkbox.AnimationDidStopForCheckBox += CheckBoxClickedEvent;
```

For a full list of settings such as animation type, colours, etc see the [BEMCheckBox](https://github.com/Boris-Em/BEMCheckBox) page.

You can also play with the BEMCheckBox settings in the [Example Client](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/tree/master/Source/ExampleClient).  To run the Example Client open the source in Visual Studio 2017 and set the Example Client as the startup project.  If the Example Client does not run please [let me know](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues).

# Version Mapping
The version of this BEMCheckBox plugin will match the BEMCheckBox major and minor version number but the patch number might differ.  When possible the patch number will match but if there is an issue with the wrapper that needs to be fixed then the patch number might be higher then the BEMCheckBox version.

| BEMCheckBox | XPlugin |
| ---:        | ---:    |
| [1.4.1](https://github.com/Boris-Em/BEMCheckBox/releases/tag/1.4.1) | [1.4.1](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/releases/tag/1.4.1) |

# Acknowledgements
Thanks to [Boris Emorine](https://github.com/Boris-Em) for creating the BEMCheckBox.
