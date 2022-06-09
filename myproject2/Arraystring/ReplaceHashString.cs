using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class ReplaceHashString
    {
        static void Main(string [] args)
        {
            String str = "Microsoft is a good company";

            String result = str.Replace("Microsoft is a good company", "#");
            Console.WriteLine(result);

            //Interploation

            String msg = "Welcome to India";
            string msg1 = "Maharashtra";

            String mymsg = $"Hello { msg}";
            Console.WriteLine(mymsg);


            char[] ch = msg.ToCharArray();
            Console.WriteLine(String.Join(", " , ch));

            Console.WriteLine("Upper case " +msg.ToUpper());
            Console.WriteLine("Lower case " +msg.ToLower());

            String merge = string.Concat (msg," , ",msg1);
            Console.WriteLine(merge);
        }
    }
}
