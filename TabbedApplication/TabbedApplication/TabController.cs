using System;
using UIKit;

namespace TabbedApplication
{
    public class TabController : UITabBarController
    {

        UIViewController tab1, tab2, tab3;

        public TabController()
        {
            tab1 = new UIViewController();
            //tab1.Title = "Green";
            tab1.TabBarItem = new UITabBarItem(UITabBarSystemItem.Favorites, 0); //get the favorites icon
            tab1.View.BackgroundColor = UIColor.Green;

            //tab2 = new UIViewController();
            //tab2.Title = "Orange";
            //tab2.View.BackgroundColor = UIColor.Orange;
            tab2 = new UIViewController();
            tab2.TabBarItem = new UITabBarItem();
            tab2.TabBarItem.Image = UIImage.FromFile("second.png"); //add image
            tab2.TabBarItem.Title = "Second";
            tab2.View.BackgroundColor = UIColor.Orange;

            tab3 = new UIViewController();
            tab3.Title = "Red";
            tab3.TabBarItem.BadgeValue = "Hi"; //add badge
            //tab3.TabBarItem.BadgeValue = null; //remove badge
            tab3.View.BackgroundColor = UIColor.Red;

            var tabs = new UIViewController[] {
                                tab1, tab2, tab3
                        };

            ViewControllers = tabs;
        }
    }
}