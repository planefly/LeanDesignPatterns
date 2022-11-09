using System;
using System.IO;

namespace FacadePattern
{
    public static class PageMaker
    {
        public static void MakeWelcomPage(string mailAddr, string fileName)
        {
            System.Collections.Generic.Dictionary<string, string> mailprop = Database.GetProperties("maildata.txt");
            string username = mailprop[mailAddr];

            HtmlWriter writer = new HtmlWriter(new StreamWriter(fileName));
            writer.Title($"Welcome to {username}'s page!");
            writer.Paragraph($"{username} 欢迎来到 {username} 的主页。");
            writer.Paragraph(" 等你的邮件哦！");
            writer.MailTo(mailAddr, username);
            writer.Close();
            Console.WriteLine($"{fileName} is created for {mailAddr} ({username})");
        }

    }
}
