using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace ProgramLanguages
{
    public partial class TableViewController : UITableViewController
    {
        //public string[] tableLanguages;
        //List<tableItem> tableItems = new List<tableItem>();
        //string[] keys;  
        //Dictionary<string, List<string>> indexedTableItems;
        List<TableItem> tableLanguages = new List<TableItem>();

        public TableViewController(IntPtr handle) : base(handle)
        {
            ///tableLanguages = new string[] {
            ///"Javascript", "Python", "Java", "Ruby", "PHP"
            ///};
            tableLanguages.Add(new TableItem("Javascript, 1995") { SubHeading = "Brendan Eich" });//, ImageName="Vegetables.jpg"});
            tableLanguages.Add(new TableItem("Python, 1990") { SubHeading = "Guido van Rossum" });
            tableLanguages.Add(new TableItem("Java, 1995") { SubHeading = "James Gosling" });
            tableLanguages.Add(new TableItem("Ruby, 1995") { SubHeading = "Yukihiro Matsumoto" });
            tableLanguages.Add(new TableItem("PHP, 1995") { SubHeading = "Rasmus Lerdorf" });

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
             * 
             *              private string[,] tableLanguages = new string[5, 4]{
            //{"Javascript", "Python", "Java", "Ruby", "PHP"};
            {"Javascript", "1995", "Brendan Eich", "ActionScript, AtScript, CoffeeScript, Dart, JScript .NET, LiveScript, Objective-J, Opa, Perl 6, QML, TypeScript"},
            {"Python", "1990", "Guido van Rossum", "Boo, Cobra, Coconut, CoffeeScript, D, F#, Falcon, Genie, Go, Groovy, JavaScript, Julia, Nim, Ring, Ruby, Swift"},
            {"Java", "1995", "James Gosling", "Ada 83, C++, C#, Eiffel, Generic Java, Mesa, Modula-3, Oberon, Objective-C, UCSD Pascal, Object Pascal"},
            {"Ruby", "1995", "Yukihiro Matsumoto", "Ada,[5] C++,[5] CLU,[6] Dylan,[6] Eiffel,[5] Lisp,[6] Lua, Perl,[6] Python,[6] Smalltalk[6]"},
            {"PHP", "1995", "Rasmus Lerdorf", "Perl, C, C++, Java, Tcl"}
            };
             * 
             *         
             private string[,] tableLanguages = new string[5, 4]{
            //{"Javascript", "Python", "Java", "Ruby", "PHP"};
            {"Javascript", "1995", "Brendan Eich", "ActionScript, AtScript, CoffeeScript, Dart, JScript .NET, LiveScript, Objective-J, Opa, Perl 6, QML, TypeScript"},
            {"Python", "1990", "Guido van Rossum", "Boo, Cobra, Coconut, CoffeeScript, D, F#, Falcon, Genie, Go, Groovy, JavaScript, Julia, Nim, Ring, Ruby, Swift"},
            {"Java", "1995", "James Gosling", "Ada 83, C++, C#, Eiffel, Generic Java, Mesa, Modula-3, Oberon, Objective-C, UCSD Pascal, Object Pascal"},
            {"Ruby", "1995", "Yukihiro Matsumoto", "Ada,[5] C++,[5] CLU,[6] Dylan,[6] Eiffel,[5] Lisp,[6] Lua, Perl,[6] Python,[6] Smalltalk[6]"},
            {"PHP", "1995", "Rasmus Lerdorf", "Perl, C, C++, Java, Tcl"}
            };
 * tableLanguages = new string[] {
"Javascript", "Python", "Java", "Ruby", "PHP"               
C++
CSS
C#
GO
C
TypeScript
Shell
Swift
Scala
Objective-C
Rust
Elixir
R
Perl
Elm
Kotlin
Crystal
Visual Basic
Matlab
Haskell

Groovy
SQL
XML
CoffeeScript
Groovy
Clojure
Arduino
Lua
Poweshell
XSL
Assembly
TypeScript
ActionScript
Erlang
ASP
Dart
VimL
Delhi
OCaml
ColdFusion
TeX
Makefile
F#
Prelog
Cuda
*/