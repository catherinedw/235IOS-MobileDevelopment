using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace ProgramLanguages
{
    public partial class TableViewController : UITableViewController
    {
        List<TableItem> tableLanguages = new List<TableItem>();

        public TableViewController(IntPtr handle) : base(handle)
        {
            ///tableLanguages = new string[] {
            ///"Javascript", "Python", "Java", "Ruby", "PHP"
            ///};
            tableLanguages.Add(new TableItem("Javascript") { SubHeading = "1995", Developer = "Brendan Eich" });//, ImageName="Vegetables.jpg"});
            tableLanguages.Add(new TableItem("Python") { SubHeading = "1990", Developer = "Guido van Rossum" });
            tableLanguages.Add(new TableItem("Java") { SubHeading = "1995", Developer = "James Gosling" });
            tableLanguages.Add(new TableItem("Ruby") { SubHeading = "1995", Developer = "Yukihiro Matsumoto" });
            tableLanguages.Add(new TableItem("PHP") { SubHeading = "1995", Developer = "Rasmus Lerdorf" });

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            TableView.Source = new TableViewSource(tableLanguages, this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

};


            /* 
             * List<TableItem> languages = new List<TableItem>();
             * tableItems.Add (new TableItem("Javascript, 1995") { SubHeading="Brendan Eich"});//, ImageName="Vegetables.jpg"});
            tableItems.Add (new TableItem("Python, 1990") { SubHeading="Guido van Rossum"});
            tableItems.Add (new TableItem("Java, 1995") { SubHeading="James Gosling"})
            tableItems.Add (new TableItem("Ruby, 1995") { SubHeading="Yukihiro Matsumoto"});
            tableItems.Add (new TableItem("PHP, 1995") { SubHeading="Rasmus Lerdorf"});
            table.Source = new TableSource(tableItems, this);
            Add (table);
             */
                   
