// using System;
// using System.Text;
// namespace InvoiceGeneratorStringBuilder
// {
//     public class InvoiceGenerator
//     {
//         public static void Main()
//         {
//             StringBuilder invoice = new();
//             decimal grandTotal = 0;

//             invoice.AppendLine("---------------- INVOICE ----------------");
//             invoice.AppendLine("Item\t\tQty\tPrice\tTotal");

//             for (int i = 1; i <= 5; i++)
//             {
//                 Console.WriteLine($"Item {i}:");
//                 Console.Write("Name: "); string name = Console.ReadLine();
//                 Console.Write("Qty: "); int qty = int.Parse(Console.ReadLine());
//                 Console.Write("Price: "); decimal price = decimal.Parse(Console.ReadLine());

//                 decimal lineTotal = qty * price;
//                 grandTotal += lineTotal;

//                 invoice.AppendFormat("{0}\t\t{1}\t{2}\t{3}\n", name, qty, price, lineTotal);
//             }

//             invoice.AppendLine("-------------------------------");
//             invoice.AppendFormat("GRAND TOTAL:\t\t\t{0}", grandTotal);

//             Console.WriteLine("\nGenerating Invoice...\n");
//             Console.WriteLine(invoice.ToString());
//         }
//     }
// }