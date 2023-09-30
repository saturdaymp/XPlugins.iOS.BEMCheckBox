using System;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SaturdayMP.XPlugins.iOS
{
    // @interface BEMAnimationManager : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC11BEMCheckBox19BEMAnimationManager")]
    [DisableDefaultCtor]
    interface BEMAnimationManager
    {
        // @property (nonatomic) CFTimeInterval animationDuration;
        [Export("animationDuration")]
        double AnimationDuration { get; set; }

        // -(instancetype _Nonnull)initWithAnimationDuration:(CFTimeInterval)animationDuration __attribute__((objc_designated_initializer));
        [Export("initWithAnimationDuration:")]
        [DesignatedInitializer]
        BEMAnimationManager Constructor(double animationDuration);

        // -(CABasicAnimation * _Nonnull)strokeAnimationReverse:(BOOL)reverse __attribute__((warn_unused_result("")));
        [Export("strokeAnimationReverse:")]
        CABasicAnimation StrokeAnimationReverse(bool reverse);

        // -(CABasicAnimation * _Nonnull)opacityAnimationReverse:(BOOL)reverse __attribute__((warn_unused_result("")));
        [Export("opacityAnimationReverse:")]
        CABasicAnimation OpacityAnimationReverse(bool reverse);

        // -(CABasicAnimation * _Nonnull)morphAnimationFrom:(UIBezierPath * _Nullable)fromPath to:(UIBezierPath * _Nullable)toPath __attribute__((warn_unused_result("")));
        [Export("morphAnimationFrom:to:")]
        CABasicAnimation MorphAnimationFrom([NullAllowed] UIBezierPath fromPath, [NullAllowed] UIBezierPath toPath);

        // -(CAKeyframeAnimation * _Nonnull)fillAnimationWithBounces:(NSInteger)bounces amplitude:(CGFloat)amplitude reverse:(BOOL)reverse __attribute__((warn_unused_result("")));
        [Export("fillAnimationWithBounces:amplitude:reverse:")]
        CAKeyFrameAnimation FillAnimationWithBounces(nint bounces, nfloat amplitude, bool reverse);
    }

    // @interface BEMCheckBox : UIControl <CAAnimationDelegate>
    [BaseType(typeof(UIControl), Name = "_TtC11BEMCheckBox11BEMCheckBox", Delegates = new string[] { "WeakDelegate" }, Events = new Type[] { typeof(BEMCheckBoxDelegate) })]
    interface BEMCheckBox : ICAAnimationDelegate
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        BEMCheckBoxDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BEMCheckBoxDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) BOOL on;
        [Export("on")]
        bool On { get; set; }

        // @property (nonatomic) enum BEMBoxType boxType;
        [Export("boxType", ArgumentSemantic.Assign)]
        BEMBoxType BoxType { get; set; }

        // @property (nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) CFTimeInterval animationDuration;
        [Export("animationDuration")]
        double AnimationDuration { get; set; }

        // @property (nonatomic) BOOL hideBox;
        [Export("hideBox")]
        bool HideBox { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable onTintColor;
        [NullAllowed, Export("onTintColor", ArgumentSemantic.Strong)]
        UIColor OnTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable onFillColor;
        [NullAllowed, Export("onFillColor", ArgumentSemantic.Strong)]
        UIColor OnFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable offFillColor;
        [NullAllowed, Export("offFillColor", ArgumentSemantic.Strong)]
        UIColor OffFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable onCheckColor;
        [NullAllowed, Export("onCheckColor", ArgumentSemantic.Strong)]
        UIColor OnCheckColor { get; set; }

        // @property (nonatomic, strong) BEMCheckBoxGroup * _Nullable group;
        [NullAllowed, Export("group", ArgumentSemantic.Strong)]
        BEMCheckBoxGroup Group { get; set; }

        // @property (nonatomic) enum BEMAnimationType onAnimationType;
        [Export("onAnimationType", ArgumentSemantic.Assign)]
        BEMAnimationType OnAnimationType { get; set; }

        // @property (nonatomic) enum BEMAnimationType offAnimationType;
        [Export("offAnimationType", ArgumentSemantic.Assign)]
        BEMAnimationType OffAnimationType { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        BEMCheckBox Constructor(CGRect frame);

        // REM
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export ("initWithCoder:")]
        //[DesignatedInitializer]
        //      BEMCheckBox Constructor (NSCoder coder);

        // @property (nonatomic) CGRect frame;
        [Export("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(void)setOn:(BOOL)on animated:(BOOL)animated;
        [Export("setOn:animated:")]
        void SetOn(bool on, bool animated);

        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
        [Export("pointInside:withEvent:")]
        bool PointInside(CGPoint point, [NullAllowed] UIEvent @event);

        // -(void)animationDidStop:(CAAnimation * _Nonnull)anim finished:(BOOL)flag;
        [Export("animationDidStop:finished:")]
        void AnimationDidStop(CAAnimation anim, bool flag);
    }

    // @protocol BEMCheckBoxDelegate <NSObject>
    [Protocol(Name = "_TtP11BEMCheckBox19BEMCheckBoxDelegate_"), Model]
    [BaseType(typeof(NSObject), Name = "_TtP11BEMCheckBox19BEMCheckBoxDelegate_")]
    interface BEMCheckBoxDelegate
    {
        // @optional -(void)didTap:(BEMCheckBox * _Nonnull)checkBox;
        [Export("didTap:"), EventArgs("BeforeCheckboxChanged")]
        void DidTap(BEMCheckBox checkBox);

        // @optional -(void)animationDidStopFor:(BEMCheckBox * _Nonnull)checkBox;
        [Export("animationDidStopFor:"), EventArgs("AfterCheckboxChanged"), DefaultValueFromArgument("checkbox")]
        void AnimationDidStopFor(BEMCheckBox checkBox);
    }

    // @interface BEMCheckBoxGroup : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC11BEMCheckBox16BEMCheckBoxGroup")]
    interface BEMCheckBoxGroup
    {
        // @property (readonly, nonatomic, strong) NSHashTable<BEMCheckBox *> * _Nonnull checkBoxes;
        [Export("checkBoxes", ArgumentSemantic.Strong)]
        NSSet<BEMCheckBox> CheckBoxes { get; }

        // @property (nonatomic, strong) BEMCheckBox * _Nullable selectedCheckBox;
        [NullAllowed, Export("selectedCheckBox", ArgumentSemantic.Strong)]
        BEMCheckBox SelectedCheckBox { get; set; }

        // @property (nonatomic) BOOL mustHaveSelection;
        [Export("mustHaveSelection")]
        bool MustHaveSelection { get; set; }

        // -(instancetype _Nonnull)initWithCheckBoxes:(NSArray<BEMCheckBox *> * _Nonnull)checkBoxes;
        [Export("initWithCheckBoxes:")]
        BEMCheckBoxGroup Constructor(BEMCheckBox[] checkBoxes);

        // -(BOOL)contains:(BEMCheckBox * _Nonnull)checkBox __attribute__((warn_unused_result("")));
        [Export("contains:")]
        bool Contains(BEMCheckBox checkBox);

        // -(void)addCheckBoxToGroup:(BEMCheckBox * _Nonnull)checkBox;
        [Export("addCheckBoxToGroup:")]
        void AddCheckBoxToGroup(BEMCheckBox checkBox);

        // -(void)removeCheckBoxFromGroup:(BEMCheckBox * _Nonnull)checkBox;
        [Export("removeCheckBoxFromGroup:")]
        void RemoveCheckBoxFromGroup(BEMCheckBox checkBox);
    }
}