using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Pet pet = new Pet();

            bool keepPlaying = true;
            string playerChoice;
            
            while (keepPlaying)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Name/Rename " + pet.Name);
                Console.WriteLine("2. Species/Set Species");
                Console.WriteLine("3. Feed " + pet.Name);
                Console.WriteLine("4. Play with " + pet.Name);
                Console.WriteLine("5. Take " + pet.Name + " to Doctor");
                Console.WriteLine("6. Check " + pet.Name + "'s status");
                Console.WriteLine("7. Exit Game");
                
                playerChoice = Console.ReadLine();

                switch (playerChoice)
                {
                    case "1":
                        Console.WriteLine("What would you like you to name your pet?");
                        pet.Name = Console.ReadLine();
                        Console.WriteLine("You named your pet " + pet.Name);
                        break;
                    case "2":
                        Console.WriteLine("What species do you want " + pet.Name + " to be?");
                        pet.Species = Console.ReadLine();
                        Console.WriteLine(pet.Name + " is a " + pet.Species);
                            break;
                    case "3":
                        pet.Feed();
                        Console.WriteLine("You fed " + pet.Name );
                        Console.WriteLine(pet.Name + "s hunger level is " + pet.Hunger);
                        break;
                    case "4":
                        pet.Play();
                        Console.WriteLine("You played with " + pet.Name);
                        Console.WriteLine(pet.Name + "s boredom level is " + pet.Boredom);
                        Console.WriteLine(pet.Name + "s health level is " + pet.Health);
                        Console.WriteLine(pet.Name + "s hunger level is " + pet.Hunger);  
                        break;
                    case "5":
                        pet.SeeDoctor();
                        Console.WriteLine("You took " + pet.Name + " to the doctor.");
                        break;
                    case "6":
                        Console.WriteLine(pet.Name);
                        Console.WriteLine(pet.Species);
                        Console.WriteLine("Hunger: " + pet.Hunger);
                        Console.WriteLine("Boredom: " + pet.Boredom);
                        Console.WriteLine("Health: " + pet.Health);

                        break;
                    case "7":
                        Console.WriteLine("Thank you for playing with " + pet.Name + "!");
                        keepPlaying = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid entry");
                        break;

                }
               
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                       
                Console.Clear();
                pet.Tick();
            }

        }
    }
}
