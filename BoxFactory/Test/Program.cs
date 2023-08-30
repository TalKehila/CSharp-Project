using Logic;
using System.Collections.ObjectModel;
using System.Threading.Channels;

MyBst tree = new();
Box delete = new Box(10, 10, DateTime.Now, 4);
tree.Add(delete);
//tree.Add(new Box(4, 2, DateTime.Now, 3));
//tree.Add(new Box(6, 8, DateTime.Now, 3));
//tree.Add(new Box(4, 4, DateTime.Now, 3));
Console.WriteLine(delete.width + "  " + delete.height+" "+delete.amount);
tree.RemoveBox(delete, 4);
//tree.Scan(x => Print(x));

//ObservableCollection<Box> allBoxes = new();
//Console.WriteLine("fromList");
//tree.Scan(
//    x => x.ScanInOrder(
//    x2 => allBoxes.Add(x2)));

 Console.WriteLine(delete.width + "  " + delete.height + " " + delete.amount);
//tree.Scan(
//    x => x.ScanInOrder(
//    x2 =>
//    {
//        //Convert from centimeters to inches
//        double inch = 0.4;
//        x2.width = x2.width * inch;
//        x2.height = x2.height * inch;
//    }));
//Console.WriteLine("inches");
//tree.Scan(x => Print(x));


//void Print(BST<double, Box> innerTree)
//{
//    innerTree.ScanInOrder(x => Console.WriteLine(x.width + "  " + x.height + " " + x.amount));
//}

//void SomeAction(BST<double, Box> x) => x.ScanInOrder(x2 => allBoxes.Add(x2));

