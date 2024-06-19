using System;


namespace TechBodiaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter notification channel here: ");
            string notfChan = Console.ReadLine();

            bool isFirst = true, isOpenBracketFounded = false;
            string chan = "";
            

            for (int i = 0; i < notfChan.Length; i++) {
                if (notfChan[i] == '[') {
                    isOpenBracketFounded = true;
                    chan = "";
                } else if (notfChan[i] == ']' && isOpenBracketFounded){
                    isOpenBracketFounded = false;

                    if (chan == "BE" || chan == "FE" || chan == "QA" || chan == "Urgent") {

                        if (isFirst) {
                            isFirst = false;
                            
                            Console.Write($"Receive channels: {chan}");
                        } else {
                            Console.Write($", {chan}");
                        }
                    }

                } else if (isOpenBracketFounded){
                    chan += notfChan[i];
                }
            }

            if (isFirst) {
                Console.Write("No valid channel found");
            }
        }
    }
}
