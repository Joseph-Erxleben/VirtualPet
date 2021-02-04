using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets shelter");

            Shelter shelter = new Shelter();
            Pet pet = new Pet();
            Random random = new Random();

            bool keepPlaying = true;
            bool returnToOffice = false;
            string playerChoice;

            while (keepPlaying)
            {

                Console.WriteLine("Welcome to " + shelter.Name + " Animal Shelter.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Name/Re-Name Shelter");
                Console.WriteLine("2. Add Organic Pet");
                Console.WriteLine("3. Add Robotic Pet");
                Console.WriteLine("4. Adopt Organic Pet");
                Console.WriteLine("5. Adopt Robotic Pet");
                Console.WriteLine("6. List Pets in Shelter");
                Console.WriteLine("7. Enter the Kennel");
                Console.WriteLine("8. Quit");

                playerChoice = Console.ReadLine();

                Console.Clear();

                switch (playerChoice)
                {
                    case "1":

                        Console.WriteLine("What do you want to name your Animal Shelter?");
                        shelter.Name = Console.ReadLine();

                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":

                        returnToOffice = false;
                        while (returnToOffice == false)
                        {
                            Kennel();
                        }

                        break;

                    case "8":
                        keepPlaying = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }
                Console.Clear();

            }



                
                void Kennel()
                {


                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Name/Rename " + pet.Name);
                    Console.WriteLine("2. Species/Set Species");
                    Console.WriteLine("3. Feed " + pet.Name);
                    Console.WriteLine("4. Play with " + pet.Name);
                    Console.WriteLine("5. Take " + pet.Name + " to Doctor");
                    Console.WriteLine("6. Check " + pet.Name + "'s status");
                    Console.WriteLine("7. Return to Office");
                
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
                            Console.WriteLine("What would you like to feed " + pet.Name + "?");
                            string food = Console.ReadLine();
                            if (random.Next(1, 100) < pet.Boredom)
                            {
                                Console.WriteLine(pet.Name + " doesnt't want your food.");
                            }
                            else
                            {
                                pet.Feed(food.ToLower());
                                Console.WriteLine("You fed " + pet.Name );
                                Console.WriteLine(pet.Name + "s hunger level is " + pet.Hunger);
                            }
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
                            returnToOffice = true;
                            break;

                        default:
                            Console.WriteLine("Please enter a valid entry");
                            break;

                    }
               
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                       
                    Console.Clear();
                    pet.Tick();

                    if (pet.Health <= 0)
                    {
                        Console.WriteLine(pet.Name.ToUpper() + " HAS DIED! YOU LOSE! :(" );
                  
                        keepPlaying = false;
                    }
                    else if (pet.Hunger > 100)
                    {
                    
                        pet.Hunger -= 10;
                        Console.WriteLine(pet.Name + " got hungry and found some food on his own.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (pet.Boredom > 100)
                    {
                        pet.Boredom -= 10;
                        Console.WriteLine(pet.Name + " got bored and found a toy to play with.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    if (pet.Health <= 0)
                    {
                        Console.WriteLine(@"(\ _ /)");
                        Console.WriteLine("(X - X)");
                        Console.WriteLine("c(\")(\")");
                    }

                    else if (pet.Health < 20)
                    {
                        Console.WriteLine(@"(\ _ /)");
                        Console.WriteLine("(0 ~ 0)");
                        Console.WriteLine("c(\")(\")");
                    }


                    else if (pet.Boredom > 80)
                    {
                        Console.WriteLine(@"(\ _ /)");
                        Console.WriteLine("(- X -)");
                        Console.WriteLine("c(\")(\")");
                    }

                    else if (pet.Hunger > 80)
                    {
                        Console.WriteLine(@"(\ _ /)");
                        Console.WriteLine("(' O ')");
                        Console.WriteLine("c(\")(\")");
                    }

                    else
                    {
                        Console.WriteLine(@"(\ _ /)");
                        Console.WriteLine("(' X ')");
                        Console.WriteLine("c(\")(\")");
                    }
               
                }


        

        }
    }
}
