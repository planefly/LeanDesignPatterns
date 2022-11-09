using System;

namespace VisitorPattern
{
    public class ListVisitor : Visitor
    {
        public string _currentdir = "";

        public override void Visit(File file)
        {
            Console.WriteLine(_currentdir + "/" + file);
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine(_currentdir + "/" + directory);
            string savedir = _currentdir;
            _currentdir = _currentdir + "/" + directory.GetName();
            foreach (Entry entry in directory)
            {
                entry.Accept(this);
            }

            _currentdir = savedir;
        }
    }
}
