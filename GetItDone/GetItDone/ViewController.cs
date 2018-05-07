using System;
using System.Collections.Generic; 
using UIKit;

namespace GetItDone
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //table = new UITableView(View.Bounds); // defaults to Plain style
            // Perform any additional setup after loading the view, typically from a nib.
            List < string > itemData = new List < string > ()  
            {  
                "Android",  
                "IOS",  
                "Windows Phone",  
                "Xamarin-IOS",  
                "Xamarin-Form",  
                "Xamarin_Android"  
            };  
            mainTableView.Source = new TableViewSource(itemData); 
            //mainListview.TableFooterView = new UIView(CoreGraphics.CGRect.Empty); 
            //table.Source = new TableViewSource(itemData); 
            //Add(table);
            var indexedTableItems = new Dictionary<string, List<string>>();
            foreach (var t in itemData)
            {
                if (indexedTableItems.ContainsKey(t[0].ToString()))
                {
                    indexedTableItems[t[0].ToString()].Add(t);
                }
                else
                {
                    indexedTableItems.Add(t[0].ToString(), new List<string>() { t });
                }
            }
            var keys = indexedTableItems.Keys;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        /*cell border is not left-aligned
        public override void WillDisplay(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)  
        {  
            if (cell.RespondsToSelector(new ObjCRuntime.Selector("setSeparatorInset:"))) cell.SeparatorInset = UIEdgeInsets.Zero;  
            if (cell.RespondsToSelector(new ObjCRuntime.Selector("setLayoutMargins:"))) cell.LayoutMargins = UIEdgeInsets.Zero;  
        } */ 

    }
}
