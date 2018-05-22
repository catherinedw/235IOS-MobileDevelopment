using System;
using UIKit;


namespace TicTacToe
{
    public class NameModel : UIPickerViewModel
    {
        private string[] names = new string[] {
                "Cruella De Vil",
                "Darth Vader",
                "Iago",
                "Khan Noonien Singh",
                "Medusa",
                "Professor Moriarty",
                "Queen of hearts",
                "Sauron",
                "The White Witch",
                "Voldermort"
            };

        private PlayViewController controller; //need to instantiate the controller that has the picker and therefore creates the option

        public NameModel(PlayViewController vc)
        {
            controller = vc;
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return names.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                return names[row];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            controller.DisplayName(names[pickerView.SelectedRowInComponent(0)]);
        }


        public override nfloat GetComponentWidth(UIPickerView picker, nint component)
        {
            // there is only one component, this is it's width setting
            return 200f;
        }

        public override nfloat GetRowHeight(UIPickerView picker, nint component)
        {
            return 40f;
        }
    }
}
