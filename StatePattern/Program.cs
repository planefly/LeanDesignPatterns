using System.Windows.Forms;

namespace StatePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SafeFrame());
        }
    }
}
