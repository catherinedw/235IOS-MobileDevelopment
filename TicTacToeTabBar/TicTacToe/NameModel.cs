using System;
using UIKit;


namespace TicTacToe
{
    public class NameModel : UIPickerViewModel
    {
        private string[] names = new string[] {
                "Darth Vader",
                "Khan Noonien Singh",
                "Sauron",
                "Voldermort"
            };

        private PlayViewController controller;

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
