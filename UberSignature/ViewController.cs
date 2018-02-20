using System;
using IOSBITS.UberSignature;
using UIKit;

namespace UberSignature
{
    public partial class ViewController : UIViewController
    {
        UBSignatureDrawingViewController signatureViewController;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            signatureViewController = new UBSignatureDrawingViewController((UIImage)null);
            this.AddChildViewController(signatureViewController);
            this.View.AddSubview(signatureViewController.View);
            signatureViewController.DidMoveToParentViewController(this);

            this.View.AddConstraints(new NSLayoutConstraint[] { NSLayoutConstraint.Create(signatureViewController.View, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Leading, 1, 0),
                NSLayoutConstraint.Create(signatureViewController.View, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Trailing, 1, 0), 
                NSLayoutConstraint.Create(signatureViewController.View, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Top, 1, 0), 
                NSLayoutConstraint.Create(signatureViewController.View, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Bottom, 1, 0) });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
