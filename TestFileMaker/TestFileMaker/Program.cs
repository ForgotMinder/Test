using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFileMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileTargetPath = @"E:\Test\";
            for(int i=0;i<=10;i++)
                Save(System.IO.Path.Combine(FileTargetPath,Guid.NewGuid().ToString()+".xml"));


        }
        static void Save(string FileFullName)
        {
            Console.WriteLine(FileFullName);
            using (System.IO.StreamWriter Writer=new System.IO.StreamWriter(FileFullName))
            {
                for (int i = 0; i <= 10; i++)
                {
                    string Text = string.Format("{0}：第{1}行", DateTime.Now, i + 1);
                    Console.WriteLine(Text);
                    Writer.WriteLine(Text);
                }
            }
        }
    }
}
