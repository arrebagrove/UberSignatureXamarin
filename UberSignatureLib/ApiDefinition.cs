using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace IOSBITS.UberSignature
{
    // @protocol UBSignatureDrawingViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UBSignatureDrawingViewControllerDelegate
    {
        // @optional -(void)signatureDrawingViewController:(UBSignatureDrawingViewController * _Nonnull)signatureDrawingViewController isEmptyDidChange:(BOOL)isEmpty;
        [Export("signatureDrawingViewController:isEmptyDidChange:")]
        void IsEmptyDidChange(UBSignatureDrawingViewController signatureDrawingViewController, bool isEmpty);
    }

    // @interface UBSignatureDrawingViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface UBSignatureDrawingViewController
    {
        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image __attribute__((objc_designated_initializer));
        [Export("initWithImage:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] UIImage image);

        // -(void)reset;
        [Export("reset")]
        void Reset();

        // -(UIImage * _Nonnull)fullSignatureImage;
        [Export("fullSignatureImage")]
        UIImage FullSignatureImage { get; }

        // @property (readonly, nonatomic) BOOL isEmpty;
        [Export("isEmpty")]
        bool IsEmpty { get; }

        // @property (nonatomic) UIColor * _Nonnull signatureColor;
        [Export("signatureColor", ArgumentSemantic.Assign)]
        UIColor SignatureColor { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        UBSignatureDrawingViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<UBSignatureDrawingViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }
}
