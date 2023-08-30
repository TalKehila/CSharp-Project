using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Logic
{
    public class MyBst
    {
        BST<double, BST<double, Queue<Box>>> Tree;// i want to use BST class  the queue is for the expiry date
        public bool Contains(double num) => Tree.Contains(num);// the big tree/root 
        public BST<double, Queue<Box>> GetInner(double num) => Tree.Search(num); //retrieves the inner tree 
        public BST<double, Queue<Box>> GetInnerTEN(double num) => Tree.SearchApToTenPresent(num);
        public ObservableCollection<Box> allBoxes = new ObservableCollection<Box>();// only display for list 
        public MyBst()
        {
            Tree = new BST<double, BST<double, Queue<Box>>>();
        }
        public Box GetBox(Box box)
        {
            if (Tree.Contains(box.width))
            {
                var inner = GetInner(box.width);
                if (inner.Contains(box.height))
                {

                    var queue = inner.Search(box.height);
                    if (queue == null)
                    {
                        Console.WriteLine("error");
                        return null;
                    }
                    else
                    {

                        return queue.GetFirst();

                    }

                }
                return null;
            }
            return null;
        }
        public Box GetBoxTenPresent(Box box)
        {
            if (Tree.ContainsApToTenPresent(box.width))
            {
                var inner = GetInnerTEN(box.width);
                if (inner.ContainsApToTenPresent(box.height))
                {
                    var queue = inner.SearchApToTenPresent(box.height);
                    if (queue == null)
                    {
                        Console.WriteLine("error");
                        return null;
                    }
                    else
                    {

                        return queue.GetFirst();

                    }
                }
                return null;
            }
            return null;
        }
        public void Add(Box box)
        {

            if (Tree.Contains(box.width))
            {
                var inner = GetInner(box.width);
                if (inner.Contains(box.height))
                {

                    var queue = inner.Search(box.height);
                    if (queue == null)
                    {
                        Queue<Box> newQueue = new Queue<Box>();
                        allBoxes.Add(box);
                        newQueue.Insert(box);
                        inner.Insert(box.height, newQueue);
                        Tree.Insert(box.width, inner);
                    }
                    else
                    {
                        foreach (var item in queue)
                        {
                            if (item.expiryDate.Date == box.expiryDate.Date)
                            {
                                item.amount += box.amount;
                            }
                            else
                            {
                                queue.Insert(box);
                            }
                        }
                    }

                }
                else
                {
                    Queue<Box> MyQueue = new Queue<Box>();
                    MyQueue.Insert(box);
                    inner.Insert(box.height, MyQueue);
                    allBoxes.Add(box);
                    Tree.Insert(box.width, inner);
                }
            }
            else
            {
                var newinnerTree = new BST<double, Queue<Box>>();
                Queue<Box> queue = new Queue<Box>();
                queue.Insert(box);
                newinnerTree.Insert(box.height, queue);
                Tree.Insert(box.width, newinnerTree);
                allBoxes.Add(box);

            }
        }
        public bool RemoveBox(Box box, int choice)
        {
            if (Tree.Contains(box.width))
            {
                var inner = GetInner(box.width);
                if (inner.Contains(box.height))
                {
                    var queue = inner.Search(box.height);
                    if (queue == null)
                    {
                        Console.WriteLine("error");
                        return false;
                    }
                    else
                    {
                        if (choice == box.amount)
                        {
                            box.amount -= choice;
                            inner.Delete(box.width);//inner 
                            queue.Remove();
                            allBoxes.Remove(box);
                            Tree.Delete(box.height); // the big tree 
                            return true;
                        }
                        if (choice > box.amount)
                        {
                            MessageBox.Show($"error there is only {box.amount} available ");
                            return false;
                        }
                        else
                        {
                            box.amount -= choice;
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void Scan(Action<BST<double, Queue<Box>>> a1)
        {
            Tree.ScanInOrder(x => a1(x));
        }
        public Box GetBox(double width, double height, int amount)
        {
            return GetBox(new Box() { amount = amount, height = height, width = width, expiryDate = DateTime.Now });
        }
        public Box GetBoxTenPresent(double width, double height, int amount)
        {
            return GetBoxTenPresent(new Box() { amount = amount, height = height, width = width, expiryDate = DateTime.Now });
        }
    }
}
