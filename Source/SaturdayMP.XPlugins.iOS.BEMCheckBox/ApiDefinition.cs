using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SaturdayMP.XPlugins.iOS
{
    // @interface BEMCheckBoxGroup : NSObject
    [BaseType(typeof(NSObject))]
    interface BEMCheckBoxGroup
    {
        // @property (nonatomic, strong) BEMCheckBox * _Nullable selectedCheckBox;
        [NullAllowed, Export("selectedCheckBox", ArgumentSemantic.Strong)]
        BEMCheckBox SelectedCheckBox { get; set; }

        // @property (nonatomic) BOOL mustHaveSelection;
        [Export("mustHaveSelection")]
        bool MustHaveSelection { get; set; }

        // +(instancetype _Nonnull)groupWithCheckBoxes:(NSArray<BEMCheckBox *> * _Nullable)checkBoxes;
        [Static]
        [Export("groupWithCheckBoxes:")]
        BEMCheckBoxGroup GroupWithCheckBoxes([NullAllowed] BEMCheckBox[] checkBoxes);

        // -(void)addCheckBoxToGroup:(BEMCheckBox * _Nonnull)checkBox;
        [Export("addCheckBoxToGroup:")]
        void AddCheckBoxToGroup(BEMCheckBox checkBox);

        // -(void)removeCheckBoxFromGroup:(BEMCheckBox * _Nonnull)checkBox;
        [Export("removeCheckBoxFromGroup:")]
        void RemoveCheckBoxFromGroup(BEMCheckBox checkBox);
    }

    // @interface BEMCheckBox : UIControl <CAAnimationDelegate>
    [BaseType(typeof(UIControl), Delegates = new string[] { "WeakDelegate" }, Events = new Type[] { typeof(BEMCheckBoxDelegate) })]
    interface BEMCheckBox
    {
        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        BEMCheckBoxDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BEMCheckBoxDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) BOOL on;
        [Export("on")]
        bool On { get; set; }

        // @property (nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) CGFloat animationDuration;
        [Export("animationDuration")]
        nfloat AnimationDuration { get; set; }

        // @property (nonatomic) BOOL hideBox;
        [Export("hideBox")]
        bool HideBox { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull onTintColor;
        [Export("onTintColor", ArgumentSemantic.Strong)]
        UIColor OnTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull onFillColor;
        [Export("onFillColor", ArgumentSemantic.Strong)]
        UIColor OnFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull offFillColor;
        [Export("offFillColor", ArgumentSemantic.Strong)]
        UIColor OffFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull onCheckColor;
        [Export("onCheckColor", ArgumentSemantic.Strong)]
        UIColor OnCheckColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (readonly, nonatomic, strong) BEMCheckBoxGroup * _Nullable group;
        [NullAllowed, Export("group", ArgumentSemantic.Strong)]
        BEMCheckBoxGroup Group { get; }

        // @property (nonatomic) BEMBoxType boxType;
        [Export("boxType", ArgumentSemantic.Assign)]
        BEMBoxType BoxType { get; set; }

        // @property (nonatomic) BEMAnimationType onAnimationType;
        [Export("onAnimationType", ArgumentSemantic.Assign)]
        BEMAnimationType OnAnimationType { get; set; }

        // @property (nonatomic) BEMAnimationType offAnimationType;
        [Export("offAnimationType", ArgumentSemantic.Assign)]
        BEMAnimationType OffAnimationType { get; set; }

        // @property (assign, nonatomic) CGSize minimumTouchSize;
        [Export("minimumTouchSize", ArgumentSemantic.Assign)]
        CGSize MinimumTouchSize { get; set; }

        // -(void)setOn:(BOOL)on animated:(BOOL)animated;
        [Export("setOn:animated:")]
        void SetOn(bool on, bool animated);

        // -(void)reload;
        [Export("reload")]
        void Reload();
    }

    // @protocol BEMCheckBoxDelegate <NSObject>
    [Model]
    [BaseType(typeof(NSObject))]
    interface BEMCheckBoxDelegate
    {
        // @optional -(void)animationDidStopForCheckBox:(BEMCheckBox * _Nonnull)checkBox;
        [Export("animationDidStopForCheckBox:"), EventArgs("AfterCheckboxChanged")]
        void AnimationDidStopForCheckBox(BEMCheckBox sender);
    }
}

