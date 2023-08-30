using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Logic
{
    public class Manager
    {
        MyBst Tree = new MyBst();
        public Manager(TextBlock info) => Info = info;
        public TextBlock Info { get; }
        public ObservableCollection<Box> Collection => Tree.allBoxes;   
        public void AddBox(Box tempBox)
        {
            try
            {
                if (tempBox == null) return;

                Tree.Add(tempBox);
                Info.Text = tempBox.ToString();
            }
            catch (Exception e)
            {

                Info.Text = e.Message;
            }
        }
        public Box GetBox(double width, double height, int amount)
        {
            return Tree.GetBox(width, height, amount);
        }
        public Box GetBoxTenPresent(double width, double height, int amount)
        {
            return Tree.GetBoxTenPresent(width, height, amount);
        }
        public bool RemoveBox(Box b,int choice)
        {
            if (b == null) return false;
            bool result = Tree.RemoveBox(b, choice);
            return result;
        }
    }
}
