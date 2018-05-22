using System;
using UIKit;
namespace ProgramLanguages
{
    public partial class TableViewController : UITableViewController
    {
        private string[] tableLanguages = {
            "Javascript", "Python", "Java", "Ruby", "PHP"
                /*
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
            };
        public TableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            TableView.DataSource = new TableViewDataSource(tableLanguages);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}