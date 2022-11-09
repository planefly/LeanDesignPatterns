using System;

namespace CompositePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Marking root entries...");
            Directory rootdir = new Directory("root");
            Directory bindir = new Directory("bin");
            Directory tmpdir = new Directory("tmp");
            Directory usrdir = new Directory("usr");
            rootdir.Add(bindir);
            rootdir.Add(tmpdir);
            rootdir.Add(usrdir);
            bindir.Add(new File("vi", 10000));
            bindir.Add(new File("latex", 20000));
            rootdir.PrintList();

        }
    }
}
