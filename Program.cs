using System;

namespace DesignPattern_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor= new Editor();
            var history = new History();
            
            editor.Content="a";
            history.push(editor.createState());
            editor.Content="b";
            history.push(editor.createState());
            editor.Content="c";
            editor.restore(history.pop()); 
            System.Console.WriteLine(editor.Content);
        }
    }
}
