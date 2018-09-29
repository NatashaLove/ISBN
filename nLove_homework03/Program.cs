using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            while (answer == "y")
            {
                //ask the user for a 7 digit number
                Console.Write("Enter a seven -digit number: ");

                //store the number in string var
                string input2 = Console.ReadLine();

                // create int var for the 7th digit
                //int seventhDigit = 0;

                //create total var
                int total = 1;

                //take each digit- use Substring method
                string firstDigit = input2.Substring(0, 1);// 0 - the place of the digit in the number - it is the 1st digit! and 1 is how many digits we take
                string secondDigit = input2.Substring(1, 1);
                string thirdDigit = input2.Substring(2, 1);
                string fourthDigit = input2.Substring(3, 1);
                string fifthDigit = input2.Substring(4, 1);
                string sixthDigit = input2.Substring(5, 1);
                string seventhDigit = input2.Substring(6,1); // 6 - the place of the 7th digit in the number - it is the 7th digit!

                // parse those digits into int
                int first = Int32.Parse(firstDigit);
                int second = Int32.Parse(secondDigit);
                int third = Int32.Parse(thirdDigit);
                int fourth = Int32.Parse(fourthDigit);
                int fifth = Int32.Parse(fifthDigit);
                int sixth = Int32.Parse(sixthDigit);
                int seventh = Int32.Parse(seventhDigit);           
            
                //create array of digits - created variables
                int[] numbers = { first, second, third, fourth, fifth, sixth, seventh};
                int i = 0;
                //multiply the 7 
                for (i = 0; i < numbers.Length; i++)
                {
                    // skip the digit if it is 0
                    if (numbers[i]==0)
                    {
                        continue;
                    }
                    total *=numbers[i];
               
                }
            
                Console.WriteLine("The total of the digits {0} multiplied together is {1}.", input2, total);

                //checking modulo 10 on the total (total%10)
                int mod = total % 10;

                //compare that to the seventh digit int
                if (mod == seventh)
                {
                    Console.WriteLine("good number");
                }
                else
                {
                    Console.WriteLine("bad number");
                }


                //ISBN
                //ask the user for a ISBN 13-digit number
                Console.Write("Enter a ISBN 13-digit number: ");

                //store the number as a string
                string input = Console.ReadLine();

                //take each digit- use Substring method
                string firstDig = input.Substring(0, 1);// 0 - the place of the digit in the number - it is the 1st digit! and 1 is how many digits we take
                string secondDig = input.Substring(1, 1);
                string thirdDig = input.Substring(2, 1);
                string fourthDig = input.Substring(3, 1);
                string fifthDig = input.Substring(4, 1);
                string sixthDig = input.Substring(5, 1);
                string seventhDig = input.Substring(6, 1);
                string eighthDig = input.Substring(7, 1);
                string ninethDig = input.Substring(8, 1);
                string tenthDig = input.Substring(9, 1);
                string eleventhDig = input.Substring(10, 1);
                string twelvthDig = input.Substring(11, 1);

                // parse those digits into int
                int firstD = Int32.Parse(firstDig);
                int secondD = Int32.Parse(secondDig);
                int thirdD = Int32.Parse(thirdDig);
                int fourthD = Int32.Parse(fourthDig);
                int fifthD = Int32.Parse(fifthDig);
                int sixthD = Int32.Parse(sixthDig);
                int seventhD = Int32.Parse(seventhDig);
                int eighthD = Int32.Parse(eighthDig);
                int ninethD = Int32.Parse(ninethDig);
                int tenthD = Int32.Parse(tenthDig);
                int eleventhD = Int32.Parse(eleventhDig);
                int twelvthD = Int32.Parse(twelvthDig);

                //take the last digit
                string lastDigit2 = input.Substring(12); // 12 - the place of the 13th digit in the number - it is the 13th digit!

                //parse the last digit into an int
                int intLastDigit2 = Int32.Parse(lastDigit2);

                //create array of digits - created variables
                int[] numbers2 = { firstD, secondD, thirdD, fourthD, fifthD, sixthD, seventhD, eighthD, ninethD, tenthD, eleventhD, twelvthD};
                int total2 = 1;

                //calculate with the for - loop - the total: multiplying by 3 every second / even number - 
                //but position of every even number is odd - so working with the position in the array, not the number itself!!!
                for (int j = 0; j < numbers2.Length; j++)
                {
                    int m = j % 2;
                    if (m == 0)
                    {
                        total2 += numbers2[j];// it is the position of the digit in the array - first position is=0, but the digit is '1' - 
                                            //(so need to multiply by 3 the opposite numbers, not these, which %2=0.)
                    }
                    else
                    {
                        total2 += numbers2[j] * 3;// total is added to the previous result
                    }

                }

                //checking modulo 10 on the total (total%10)
                int mod2 = total2 % 10;

                //compare that to the last digit int
                if (mod2 == intLastDigit2)
                {
                    Console.WriteLine("good ISBN number");
                }
                else
                {
                    Console.WriteLine("bad ISBN number");
                }

                //ask the user if he wants to continue
                Console.WriteLine("Wanna try again? y/n");
                answer = Console.ReadLine();

            }

            /**
             * I didn't understand - why you choose to use char, prof Morris??
             * 
            // create a char array from the string

            char[] charNumberArray = input2.ToCharArray();

            // loop through the string to get each char

            for (int i = 0; i < charNumberArray.Length; i++)
            {
                // Console.WriteLine (charNumberArray[i]);
                //check to see if the number is equal to 0
                // skip it if it is

                if (charNumberArray [i]=='0')
                {
                    continue;
                }

                else
                {
                    //convert the charNumber to a string, so then
                    // we can convert it to an int

                    int intNumber = Convert.ToInt32(charNumberArray[i].ToString());

                    //multiply and accumulate to total
                    total *= intNumber;

                    if (i== charNumberArray.Length - 1)// the last element position is 1 less than the array length - because the count starts with 0
                    {
                        seventhDigit = intNumber;
                    }

                }

            }
    **/



            //WriteLine - adds a new line; Write - stays in the same line.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}


