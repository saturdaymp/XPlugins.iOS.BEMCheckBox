# AGENTS.md

This document provides guidance for AI agents (like Claude Code, GitHub Copilot, etc.) when working with the XPlugins.iOS.BEMCheckBox project.

## Project Overview

**XPlugins.iOS.BEMCheckBox** is a .NET iOS binding library that wraps the native Swift BEMCheckBox framework for use in .NET iOS applications. It enables .NET developers to use highly customizable, animated checkbox controls in their iOS applications.

**Current Version:** 9.0.0
**Target Framework:** net9.0-ios18.0
**Language:** C# 12
**Package:** SaturdayMP.XPlugins.iOS.BEMCheckBox (NuGet)

## Project Structure

```
/Source/
├── SaturdayMP.XPlugins.iOS.BEMCheckBox/   # Main binding library
│   ├── NativeReferences/                   # Native BEMCheckBox.xcframework (v2.2.0)
│   ├── ApiDefinitions.cs                   # C# binding API definitions
│   ├── StructsAndEnums.cs                  # Enums and structs
│   └── *.csproj                            # Binding project configuration
├── ExampleClient/                          # Demo iOS application
│   ├── MainViewController.cs               # Usage examples
│   └── *.csproj                            # Example app project
└── global.json                             # .NET SDK version (9.0.0)
```

## Key Components

### Core API Classes (ApiDefinitions.cs:1)

1. **BEMCheckBox** - Main checkbox control (UIControl subclass)
   - Properties: On, BoxType, LineWidth, CornerRadius, AnimationDuration, Colors, etc.
   - Methods: SetOn(bool, bool) for state changes with optional animation
   - Delegate: BEMCheckBoxDelegate for event handling

2. **BEMAnimationManager** - Handles checkbox animations
   - Methods: StrokeAnimationReverse, FillAnimationWithBounces, MorphAnimationFrom, etc.

3. **BEMCheckBoxGroup** - Groups checkboxes for radio button behavior
   - Properties: CheckBoxes, SelectedCheckBox, MustHaveSelection
   - Methods: AddCheckBoxToGroup, RemoveCheckBoxFromGroup, Contains

4. **BEMCheckBoxDelegate** (Protocol) - Event callbacks
   - DidTap: Fired before state changes
   - AnimationDidStopFor: Fired after animation completes

### Enumerations (StructsAndEnums.cs:1)

- **BEMBoxType**: Circle (0), Square (1)
- **BEMAnimationType**: Stroke, Fill, Bounce, Flat, OneStroke, Fade

## Development Guidelines

### When Adding/Modifying Bindings

1. **Always preserve Objective-C/Swift signatures in comments**
   - Keep existing comment patterns for method signatures
   - Example: `// @property (nonatomic, assign) BOOL on;`

2. **Use correct binding attributes**
   - `[BaseType]` for class inheritance
   - `[Export("selector:")]` for method/property mappings
   - `[Protocol]`, `[Model]` for delegates
   - `[NullAllowed]` for optional parameters
   - `[EventArgs("EventName")]` for delegate events

3. **Follow naming conventions**
   - Use PascalCase for properties and methods
   - Keep names close to original Swift/Objective-C names
   - Maintain .NET naming standards while preserving clarity

4. **Namespace organization**
   - All bindings go in namespace: `SaturdayMP.XPlugins.iOS`
   - Do not create sub-namespaces

### When Updating the Native Framework

1. **Replace the xcframework in NativeReferences/**
   - Update BEMCheckBox.xcframework
   - Verify architecture support: ios-arm64, ios-arm64_x86_64-simulator

2. **Update ApiDefinitions.cs if API changes**
   - Review Swift framework changelog
   - Add/modify/remove bindings as needed
   - Test with ExampleClient

3. **Update version mapping in README.md**
   - Add row to version mapping table
   - Document any breaking changes

### When Modifying ExampleClient

1. **Keep it simple and focused**
   - Demonstrate core functionality only
   - One ViewController pattern (MainViewController.cs:1)
   - Console logging for debugging

2. **Update examples for new features**
   - Add usage examples for new bindings
   - Wire up event handlers
   - Show best practices

3. **Do not publish ExampleClient**
   - It's for testing/demonstration only
   - Only the binding library is published to NuGet

## Build and CI/CD

### Local Build Commands

```bash
# Restore dependencies
dotnet restore Source/SaturdayMP.XPlugins.iOS.BEMCheckBox.sln

# Build debug (includes ExampleClient smoke test)
dotnet build Source/SaturdayMP.XPlugins.iOS.BEMCheckBox.sln -c Debug

# Create NuGet package (Release configuration)
dotnet pack Source/SaturdayMP.XPlugins.iOS.BEMCheckBox/SaturdayMP.XPlugins.iOS.BEMCheckBox.csproj -c Release
```

### Version Management

**Strategy:** GitHubFlow with GitVersion

- Version is determined from Git tags and branch names
- Format: Semantic versioning (major.minor.patch)
- Configuration: GitVersion.yml:1
- Current version: 9.0.0

**Version workflow:**
1. Work on feature branches or release/* branches
2. Create PR to main
3. Merge to main (minor version increment)
4. Create release branch: `release/X.Y.Z`
5. Tag release: `vX.Y.Z`
6. CI automatically publishes to NuGet

**Important:** Do NOT manually edit version numbers in csproj files. They are automatically generated by GitVersion.

### CI/CD Pipeline (.github/workflows/ci.yml:1)

**Triggers:**
- Push to main or release/* branches
- Tags matching v*
- Pull requests

**Build steps:**
1. Checkout with full Git history (required for GitVersion)
2. Install .NET 9.0
3. Restore workloads
4. Install GitVersion (6.3.0)
5. Determine version
6. Restore NuGet packages
7. Build Debug (smoke test)
8. Create Release NuGet package
9. Publish to MyGet (all builds)
10. Publish to NuGet (tagged releases only)

**Runner:** macOS-15 (required for iOS builds)

### Release Notes (.github/workflows/release-notes.yml:1)

**Automated changelog generation:**
- Uses GitReleaseManager (0.20.0)
- Reads from GitHub milestones and issues
- Categories defined in GitReleaseManager.yml:1
- Auto-commits updated CHANGELOG.md

**Categories:**
- breaking: Breaking Changes
- bug: Bug Fixes
- devops: DevOps
- dependency: Dependencies
- documentation: Documentation
- enhancement: Enhancements
- refactoring: Refactoring
- security: Security

**Important:** Always tag issues/PRs with appropriate labels for changelog generation.

## Common Tasks

### Adding a New Property Binding

1. Locate the property in BEMCheckBox Swift source
2. Add to ApiDefinitions.cs in the BEMCheckBox interface
3. Use `[Export("propertyName")]` attribute
4. Add appropriate type mapping (nint, nuint, bool, NSString, etc.)
5. Add `[NullAllowed]` if optional
6. Test in ExampleClient

**Example:**
```csharp
// @property (nonatomic, strong) UIColor *onTintColor;
[Export("onTintColor", ArgumentSemantic.Strong)]
[NullAllowed]
UIColor OnTintColor { get; set; }
```

### Adding a New Method Binding

1. Locate the method in BEMCheckBox Swift source
2. Add to ApiDefinitions.cs in the appropriate interface
3. Use `[Export("methodName:withParam:")]` with full selector
4. Map parameter types correctly
5. Test in ExampleClient

**Example:**
```csharp
// - (void)setOn:(BOOL)on animated:(BOOL)animated;
[Export("setOn:animated:")]
void SetOn(bool on, bool animated);
```

### Adding a New Delegate Event

1. Define the delegate method in BEMCheckBoxDelegate protocol
2. Add `[EventArgs("EventArgType")]` attribute
3. Create corresponding EventArgs class if needed
4. Add `[EventName("EventName")]` for .NET event name
5. Test event firing in ExampleClient

### Updating to a New BEMCheckBox Version

1. Download new xcframework from source repository
2. Replace in NativeReferences/BEMCheckBox.xcframework/
3. Review BEMCheckBox changelog for API changes
4. Update ApiDefinitions.cs for new/changed APIs
5. Update StructsAndEnums.cs for new enums
6. Update ExampleClient to demonstrate new features
7. Test thoroughly
8. Update README.md version mapping table
9. Create GitHub issue/milestone for the update
10. Create release branch and tag

### Fixing Build Errors

**Common issues:**

1. **"Framework not found BEMCheckBox"**
   - Check NativeReferences/BEMCheckBox.xcframework exists
   - Verify NativeReference in csproj

2. **"Selector not found"**
   - Check Export selector matches exactly
   - Case-sensitive, include colons for parameters

3. **"Type mismatch"**
   - Review Objective-C to C# type mappings
   - Common mappings: BOOL→bool, NSInteger→nint, NSString→string

4. **"Workload not found"**
   - Run: `dotnet workload restore`
   - Ensure macOS with Xcode installed

### Running ExampleClient

**From an IDE:**
1. Open solution in Visual Studio for Mac or VS Code
2. Set ExampleClient as startup project
3. Select iOS Simulator
4. Build and run (F5)
5. Interact with checkbox to test functionality

**From the Command Line:**
The .NET CLI does not directly support running iOS applications. To verify the ExampleClient builds correctly:

```bash
# Navigate to Source directory
cd Source

# Build the solution (includes ExampleClient)
dotnet build -c Debug
```

To actually run the app, you must use an IDE (Visual Studio for Mac, Visual Studio, or Rider) or use advanced tools like `xcrun simctl` to manually install and launch the built .app bundle.

**Requirements:**
- macOS with Xcode installed
- .NET 9.0 SDK
- iOS Simulator available (for running)
- IDE required for running (command-line build only)

## Important Constraints

### Platform Requirements

- **macOS required** for building (iOS SDK dependency)
- **Xcode** must be installed (iOS development tools)
- **.NET 9.0 SDK** required (pinned in global.json:1)
- **iOS 18.0+** minimum target

### Binding Limitations

1. **No generic types** - Objective-C runtime limitation
2. **No operator overloading** - Use explicit methods
3. **Delegate pattern** - Use events or strong delegates
4. **Memory management** - Let runtime handle retain/release

### Package Configuration

**NuGet package contents:**
- Main DLL only (not ExampleClient)
- LICENSE.txt
- README.md (referenced, not embedded)
- Target framework: net9.0-ios18.0

## Testing Strategy

**Current approach:** Manual testing via ExampleClient

**No automated tests exist**, but CI validates:
- Entire solution compiles (Debug mode)
- NuGet package builds (Release mode)
- Implicit validation of binding correctness

**When making changes:**
1. Build in Debug mode: `dotnet build -c Debug`
2. Run ExampleClient in iOS Simulator (via IDE)
3. Test affected functionality manually
4. Verify NuGet package creation: `dotnet pack -c Release`
5. Check CI passes before merging

**Future considerations:**
- Add unit tests for binding layer
- Add UI tests for ExampleClient
- Add device testing (not just simulator)

## Code Quality Standards

### Code Style

- **C# 12** language features allowed
- **Nullable reference types** enabled
- **ImplicitUsings** enabled
- Follow .NET naming conventions
- Keep binding code minimal and clean

### Documentation

- Update README.md for user-facing changes
- Add inline comments for complex bindings
- Update CHANGELOG.md via GitReleaseManager
- Keep version mapping table current

### Git Workflow

1. Create feature branch from main
2. Make changes following these guidelines
3. Test locally with ExampleClient
4. Create PR to main
5. Ensure CI passes
6. Tag issues/PRs with appropriate labels
7. Merge to main
8. Create release branch for publishing
9. Tag for NuGet publication

## Common Pitfalls

### 1. Version Conflicts

**Pitfall:** Manually setting versions in csproj
**Solution:** Always use GitVersion; versions are auto-generated from Git tags

### 2. Missing Native Reference

**Pitfall:** Forgetting to include xcframework in project
**Solution:** Ensure `<NativeReference Include="...">` exists in csproj

### 3. Incorrect Selector Mapping

**Pitfall:** Export selector doesn't match Objective-C method
**Solution:** Use exact selector including colons (e.g., `setOn:animated:`)

### 4. Type Marshalling Errors

**Pitfall:** Using wrong C# type for Objective-C types
**Solution:** Refer to binding type reference:
- BOOL → bool
- NSInteger → nint
- NSUInteger → nuint
- NSString → string
- id → NSObject

### 5. Breaking API Changes

**Pitfall:** Changing public API without considering consumers
**Solution:** Mark breaking changes with issue label, increment major version, document in changelog

### 6. Platform-Specific Code

**Pitfall:** Assuming .NET Standard patterns work
**Solution:** This is iOS-specific; use iOS APIs and patterns only

### 7. CI Build Failures

**Pitfall:** Works locally but fails in CI
**Solution:** CI uses macOS-15 runner; ensure compatibility with GitHub Actions environment

## External References

### Documentation
- [Microsoft Learn: Binding iOS Swift Libraries](https://learn.microsoft.com/xamarin/ios/platform/binding-swift/)
- [Project README](README.md:1)
- [BEMCheckBox Original Framework](https://github.com/saturdaymp/BEMCheckBox)

### Package Distribution
- [NuGet Package](https://www.nuget.org/packages/SaturdayMP.XPlugins.iOS.BEMCheckBox)
- [MyGet Feed (WIP builds)](https://www.myget.org/feed/saturdaymp)

### Related Blog Posts
- [Creating Xamarin iOS Binding Series](https://www.saturdaymp.com/tag/creating-xamarin-ios-bindings/)

## Quick Reference

### File Responsibilities

| File | Purpose | When to Modify |
|------|---------|---------------|
| ApiDefinitions.cs:1 | C# binding definitions | Adding/modifying bindings |
| StructsAndEnums.cs:1 | Enums and structs | New enum types from framework |
| *.csproj | Project configuration | Changing target framework, references |
| MainViewController.cs:1 | Example usage | Demonstrating new features |
| README.md:1 | User documentation | API changes, version updates |
| GitVersion.yml:1 | Version configuration | Changing version strategy |
| GitReleaseManager.yml:1 | Release notes config | Adding new issue categories |

### Build Configuration Reference

- **Debug**: Includes ExampleClient, used for testing
- **Release**: Library only, creates NuGet package
- **Target Framework**: net9.0-ios18.0
- **Package ID**: SaturdayMP.XPlugins.iOS.BEMCheckBox
- **License**: MIT

### Support and Maintenance

- **Issues**: Report on GitHub repository
- **Sponsorship**: GitHub Sponsors enabled (FUNDING.yml:1)
- **Maintainer**: SaturdayMP organization

---

**Last Updated:** 2025-11-27
**For Version:** 9.0.0
**Agent Compatibility:** Optimized for Claude Code, GitHub Copilot, and other AI coding assistants
