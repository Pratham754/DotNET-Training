using System;
using System.Collections.Generic;

namespace CommandPatternMiniFramework
{
    public interface ICommand { void Execute(); void Undo(); }

    public class Cart
    {
        public List<string> Items = new();
        public decimal Discount;
    }

    public class AddItem(Cart c, string item) : ICommand
    {
        public void Execute() => c.Items.Add(item);
        public void Undo() => c.Items.Remove(item);
    }

    public class RemoveItem(Cart c, string item) : ICommand
    {
        private int _index;
        public void Execute() { _index = c.Items.IndexOf(item); if (_index >= 0) c.Items.RemoveAt(_index); }
        public void Undo() { if (_index >= 0) c.Items.Insert(_index, item); }
    }

    public class ApplyDiscount(Cart c, decimal amt) : ICommand
    {
        private decimal _old;
        public void Execute() { _old = c.Discount; c.Discount = amt; }
        public void Undo() => c.Discount = _old;
    }

    public class CommandManager
    {
        private readonly Stack<ICommand> _undo = new(), _redo = new();

        public void Do(ICommand cmd) { cmd.Execute(); _undo.Push(cmd); _redo.Clear(); }

        public void Undo() { if (_undo.Count > 0) { var c = _undo.Pop(); c.Undo(); _redo.Push(c); } }

        public void Redo() { if (_redo.Count > 0) { var c = _redo.Pop(); c.Execute(); _undo.Push(c); } }
    }

    public class Program
    {
        public static void Main()
        {
            var cart = new Cart();
            var manager = new CommandManager();

            manager.Do(new AddItem(cart, "Laptop"));
            manager.Do(new ApplyDiscount(cart, 10));
            manager.Undo(); // Discount gone
            manager.Redo(); // Discount back
            manager.Do(new RemoveItem(cart, "Laptop")); // Empty
            manager.Undo(); // Laptop returns

            Console.WriteLine($"Cart: {string.Join(", ", cart.Items)} | Disc: {cart.Discount}%");
        }
    }
}