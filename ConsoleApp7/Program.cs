using System;

namespace ConsoleApp7
{
    class Program
    {

        
        static void Main(string[] args)
        {
         

            string[] names = {"Jacob", "Drew", "Peter"};
            string[] food = {"Cookies", "Ices Cream", "Thai"};
            string[] hometown = {"Detroit", "Roseville", "Warren"};


            bool answ = true;
            while (answ)
            {

             
                    
                    Console.WriteLine("Enter a student number" + "\n" + "0 = Jacob, 1 = Drew, 2 = Peter");

                   
                    int input = int.Parse(Console.ReadLine());
            
                    Console.WriteLine("What would you like to learn, Favorite food or Hometown?  (Enter; food/hometown)");
                    string answer = Console.ReadLine();
                try
                {
                    if (answer == "food")
                    {

                        Console.WriteLine($"You chose {names[input]} they like to eat {food[input]}");


                    }
                    else if (answer == "hometown")
                    {
                        Console.WriteLine($" You chose {names[input]} they  are from {hometown[input]}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");

                    }

                    Console.WriteLine("Would you like to learn more? y/n");
                    string newinput = Console.ReadLine();

                    if (newinput == "y" || newinput == "Y" && answer == "food")
                    {

                        Console.WriteLine($"{names[input]} is from {hometown[input]}");
                        Console.WriteLine("Run Again? y/n");
                        string dataValue = Console.ReadLine();
                        if (dataValue == "y" || dataValue == "Y")
                        {

                        }
                        else if (dataValue == "N" || dataValue == "n")
                        {
                            Console.WriteLine("Goodbye");
                            answ = false;
                        }

                    }
                    else if (newinput == "y" || newinput == "Y" && answer == "hometown")
                    {
                        Console.WriteLine($"{names[input]} likes to eat {food[input]}");
                        Console.WriteLine("Run Again? y/n");
                        string dataValue = Console.ReadLine();
                        if (dataValue == "y" || dataValue == "Y")
                        {

                        }
                        else if (dataValue == "N" || dataValue == "n")
                        {
                            Console.WriteLine("Goodbye");
                            answ = false;
                        }

                    }
                    else if (newinput == "N" || newinput == "n")
                    {
                        Console.WriteLine("Goodbye");
                        answ = false;

                    }

                }
                catch (IndexOutOfRangeException ex)
                {

                    Console.WriteLine("Not in Range Try again");

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
    

            } 
            
        }
  
    }
}
