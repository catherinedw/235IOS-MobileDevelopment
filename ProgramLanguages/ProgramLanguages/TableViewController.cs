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
            ///tableLanguages.Add(new TableItem("Javascript") { SubHeading = "1995", Developer = "Brendan Eich" });//, ImageName="Vegetables.jpg"});
            tableLanguages.Add(new TableItem("ActionScript") { SubHeading = "1998", Developer = "Gary Grossman" });
            tableLanguages.Add(new TableItem("Ballerina") { SubHeading = "2017", Developer = "Sanjiva Weerawarana, WSO2" });
            tableLanguages.Add(new TableItem("BASIC") { SubHeading = "1964", Developer = "John George Kemeny and Thomas Eugene Kurtz at Dartmouth College" });
            tableLanguages.Add(new TableItem("C") { SubHeading = "1972", Developer = "Dennis Ritchie" });
            tableLanguages.Add(new TableItem("C shell") { SubHeading = "1978", Developer = "Bill Joy" });
            tableLanguages.Add(new TableItem("C#") { SubHeading = "2000", Developer = "Anders Hejlsberg, Microsoft (ECMA)" });
            tableLanguages.Add(new TableItem("C++") { SubHeading = "1983", Developer = "Bjarne Stroustrup" });
            tableLanguages.Add(new TableItem("Clojure") { SubHeading = "2007", Developer = "Rich Hickey" });
            tableLanguages.Add(new TableItem("CoffeeScript") { SubHeading = "2009", Developer = "Jeremy Ashkenas" });
            tableLanguages.Add(new TableItem("ColdFusion (CFML)") { SubHeading = "1995", Developer = "Allaire" });
            tableLanguages.Add(new TableItem("Crystal") { SubHeading = "2014", Developer = "Ary Borenszweig, Manas Technology Solutions" });
            tableLanguages.Add(new TableItem("D") { SubHeading = "2001", Developer = "Walter Bright, Digital Mars" });
            tableLanguages.Add(new TableItem("Dart") { SubHeading = "2011", Developer = "Google" });
            tableLanguages.Add(new TableItem("Eiffel") { SubHeading = "1986", Developer = "Bertrand Meyer" });
            tableLanguages.Add(new TableItem("Elixir") { SubHeading = "2012", Developer = "Johsé Valim" });
            tableLanguages.Add(new TableItem("Elm") { SubHeading = "2012", Developer = "Evan Czaplicki" });
            tableLanguages.Add(new TableItem("Erlang") { SubHeading = "1986", Developer = "Joe Armstrong and others in Ericsson" });
            tableLanguages.Add(new TableItem("Euclid") { SubHeading = "1977", Developer = "Butler Lampson at Xerox Parc, Ric Holt and James Cordy at University of Toronto" });
            tableLanguages.Add(new TableItem("F#") { SubHeading = "2005", Developer = "Don Syme, Microsoft Research" });
            tableLanguages.Add(new TableItem("Fortran (concept)") { SubHeading = "1954–55", Developer = "Team led by John W. Backus at IBM" });
            tableLanguages.Add(new TableItem("Go") { SubHeading = "2009", Developer = "Google" });
            tableLanguages.Add(new TableItem("Groovy") { SubHeading = "2004", Developer = "James Strachan" });
            tableLanguages.Add(new TableItem("Hack") { SubHeading = "2014", Developer = "Facebook" });
            tableLanguages.Add(new TableItem("Haskell") { SubHeading = "1990", Developer = "" });
            tableLanguages.Add(new TableItem("Java") { SubHeading = "1995", Developer = "James Gosling at Sun Microsystems" });
            tableLanguages.Add(new TableItem("JavaScript") { SubHeading = "1995", Developer = "Brendan Eich at Netscape" });
            tableLanguages.Add(new TableItem("Julia") { SubHeading = "2012", Developer = "Jeff Bezanson, Stefan Karpinski, Viral Shah, Alan Edelman, MIT" });
            tableLanguages.Add(new TableItem("Kotlin") { SubHeading = "2011", Developer = "JetBrains" });
            tableLanguages.Add(new TableItem("Lua") { SubHeading = "1993", Developer = "Roberto Ierusalimschy et al. at Tecgraf, PUC-Rio" });
            tableLanguages.Add(new TableItem("MATLAB") { SubHeading = "1978?", Developer = "Cleve Moler at the University of New Mexico" });
            tableLanguages.Add(new TableItem("Objective-C") { SubHeading = "1983", Developer = "Brad Cox" });
            tableLanguages.Add(new TableItem("OCaml") { SubHeading = "1996", Developer = "INRIA" });
            tableLanguages.Add(new TableItem("P") { SubHeading = "2012", Developer = "Vivek Gupta, Ethan Jackson, Shaz Qadeer, Sriram Rajamani, Microsoft" });
            tableLanguages.Add(new TableItem("Pascal") { SubHeading = "1970", Developer = "Niklaus Wirth, Kathleen Jensen" });
            tableLanguages.Add(new TableItem("Perl") { SubHeading = "1987", Developer = "Larry Wall" });
            tableLanguages.Add(new TableItem("PHP") { SubHeading = "1995", Developer = "Rasmus Lerdorf" });
            tableLanguages.Add(new TableItem("Pico") { SubHeading = "1997", Developer = "Free University of Brussels" });
            tableLanguages.Add(new TableItem("Python") { SubHeading = "1990", Developer = "Guido van Rossum" });
            tableLanguages.Add(new TableItem("R") { SubHeading = "1993", Developer = "Robert Gentleman and Ross Ihaka" });
            tableLanguages.Add(new TableItem("Regional Assembly Language") { SubHeading = "1951", Developer = "Maurice Wilkes" });
            tableLanguages.Add(new TableItem("Ruby") { SubHeading = "1995", Developer = "Yukihiro Matsumoto" });
            tableLanguages.Add(new TableItem("Rust") { SubHeading = "2010", Developer = "Graydon Hoare, Mozilla" });
            tableLanguages.Add(new TableItem("Scala") { SubHeading = "2003", Developer = "Martin Odersky" });
            tableLanguages.Add(new TableItem("Scratch") { SubHeading = "2002", Developer = "Mitchel Resnick, John Maloney, Natalie Rusk, Evelyn Eastmond, Tammy Stern, Amon Millner, Jay Silver, and Brian Silverman" });
            tableLanguages.Add(new TableItem("Structured Query language (SQL)") { SubHeading = "1972", Developer = "IBM" });
            tableLanguages.Add(new TableItem("Swift") { SubHeading = "2014", Developer = "Apple Inc." });
            tableLanguages.Add(new TableItem("TypeScript") { SubHeading = "2012", Developer = "Anders Hejlsberg, Microsoft" });
            tableLanguages.Add(new TableItem("Visual Basic") { SubHeading = "1991", Developer = "Alan Cooper, sold to Microsoft" });
            tableLanguages.Add(new TableItem("Visual Basic .NET") { SubHeading = "2001", Developer = "Microsoft" });
            tableLanguages.Add(new TableItem("Windows PowerShell") { SubHeading = "2006", Developer = "Microsoft" });
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            //tableLanguages = tableLanguages.Sort((x, y) => { return x.CompareTo(y); });
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
                   
