## v3.0.1 (Oct, 14, 2023)


As part of this release we had [1 issue](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/milestone/5?closed=1) closed.

Fixed issues with v3.0.0 release that had the minimum iOS version of the Nuget package set to 16.1 instead of 12.0.

__DevOps__

- [__#26__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/26) Update minimum iOS version in NuGet Package to 12 instead of 16

## v3.0.0 (Oct, 14, 2023)


As part of this release we had [2 issues](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/milestone/4?closed=1) closed.

Upgraded to .NET 6 iOS (net6.0-ios).  If you need Xamarin support please try the v2 release.

__DevOps__

- [__#25__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/25) Prepare for v3.0.0 release

__Enhancement__

- [__#15__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues/15) net6.0-ios migration

## v2.0.0 (Aug, 17, 2023)


The underlying BEMCheckBox [v2.0.0](https://github.com/saturdaymp/BEMCheckBox/releases/tag/v2.0.0) has some breaking changes that affect this Xamarin wrapper:

- Minimum iOS version was increased from 8.4 to 12.
- Events renamed
  -  `DidTapCheckBox` renamed to `DidTap`
  - `AnimationDidStopForCheckBox` to `AnimationDidStopFor`


As part of this release we had [10 issues](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/milestone/3?closed=1) closed.



__Dependencies__

- [__#12__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues/12) Upgrade BEMCheckBox Native Framework from 1.4.1 to 2.0.0
- [__#16__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/16) Update Xamarin.Forms for the Example Client from 4 to 5.0.0.2578
- [__#18__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/18) Upgrade BEMCheckBox Native Framework from 1.4.1 to 2.0.0
- [__#19__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/19) Update BEMCheckBox binding from 1.4 to 2.0.0

__DevOps__

- [__#17__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/17) Fix issues with CI
- [__#21__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/21) Add release notes workflow
- [__#23__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/23) Updated the Nuspec file and added uploading to NuGet in the CI

__Documentation__

- [__#22__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/22) Update BEMCheckBox references and add badges in the README

__Enhancement__

- [__#11__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/issues/11) Migrate Automated Build to GitHub Actions

__Refactoring__

- [__#20__](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/pull/20) Move native reference files to the Native References folder

## 1.4.3 (Dec, 22, 2017)


Exposed the didTapCheckBox event.

For a full list of issues fixed see the [1.4.3 Milestone](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/milestone/2).
## 1.4.2 (Dec, 4, 2017)


Fixed an issue where publishing to the App Store with a project that included BEMCheckBox would raise a Bitcode error.

For a full list of issues fixed see the [1.4.2 Milestone](https://github.com/saturdaymp/XPlugins.iOS.BEMCheckBox/milestone/1).
## 1.4.1 (Aug, 2, 2017)


Wraps [BEMCheckBox](https://github.com/Boris-Em/BEMCheckBox) version [1.4.1](https://github.com/Boris-Em/BEMCheckBox/releases/tag/1.4.1).
