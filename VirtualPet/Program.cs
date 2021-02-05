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
                Console.WriteLine("4. Adopt a Pet");
                Console.WriteLine("5. List Pets in Shelter");
                Console.WriteLine("6. Enter the Kennel");
                Console.WriteLine("7. Quit");

                playerChoice = Console.ReadLine();

                Console.Clear();

                switch (playerChoice)
                {
                    case "1":

                        Console.WriteLine("What do you want to name your Animal Shelter?");
                        shelter.Name = Console.ReadLine();

                        break;

                    case "2":
                        Console.WriteLine("What is the name of your pet?");
                        string nameOfPet = Console.ReadLine();
                        Console.WriteLine("What is the species of your pet?");
                        string speciesOfPet = Console.ReadLine();
                        Organic organic = new Organic(nameOfPet, speciesOfPet);
                        shelter.AddPet(organic);
                       
                        break;

                    case "3":
                        Console.WriteLine("What is the name of your pet?");
                        nameOfPet = Console.ReadLine();
                        Console.WriteLine("What is the species of your pet?");
                        speciesOfPet = Console.ReadLine();
                        Robotic robotic = new Robotic(nameOfPet, speciesOfPet);
                        shelter.AddPet(robotic);
                        break;

                    case "4":
                        Console.WriteLine("Which pet would you like to adopt?");
                        string userPet = Console.ReadLine();

                        int userPetIndex = shelter.SelectPet(userPet);

                        if (userPetIndex == -1)
                        {
                            Console.WriteLine("That pet isn't listed in our records.");
                        }

                        else
                        {
                            shelter.RemovePet(userPetIndex);
                        }
                        
                        Console.ReadKey();
                        break;

                    case "5":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            if(shelter.ListofPets[i].IsOrganic == true)
                            {
                                Console.WriteLine(shelter.ListofPets[i].Name + " the organic " + shelter.ListofPets[i].Species);
                            }
                            else
                            {
                                Console.WriteLine(shelter.ListofPets[i].Name + " the robotic " + shelter.ListofPets[i].Species);
                            }

                        }
                        Console.ReadKey();
                        break;

                    case "6":

                        returnToOffice = false;
                        while (returnToOffice == false)
                        {
                            Kennel();
                        }

                        break;

                    case "7":
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
                Console.WriteLine("1. Feed all organic pets");
                Console.WriteLine("2. Oil all robotic pets");
                Console.WriteLine("3. Play with all pets");
                Console.WriteLine("4. Take all organic pets to Doctor");
                Console.WriteLine("5. Perform maintenence on all Robotic Pets");
                Console.WriteLine("6. Interact with a single pet");
                Console.WriteLine("7. Check all pet statuses");
                Console.WriteLine("8. Return to Office");

                playerChoice = Console.ReadLine();

                switch (playerChoice)
                { 
                   
                    case "1":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            if (shelter.ListofPets[i].IsOrganic == true)
                            {
                                shelter.ListofPets[i].Feed();
                            }
                        }
                        Console.WriteLine("You fed the pets!");
                        break;

                    case "2":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            if (shelter.ListofPets[i].IsOrganic == false)
                            {
                                //shelter.ListofPets[i].GiveOil();
                            }
                        }
                        Console.WriteLine("You oiled the pets!");
                        break;

                    case "3":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            shelter.ListofPets[i].Play();
                        }
                        Console.WriteLine("You played with the pets!");
                        break;

                    case "4":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            if (shelter.ListofPets[i].IsOrganic == true)
                            {
                                shelter.ListofPets[i].SeeDoctor();
                            }
                        }
                        Console.WriteLine("You took the pets to the doctor!");
                        break;

                    case "5":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            if (shelter.ListofPets[i].IsOrganic == false)
                            {
                                //shelter.ListofPets[i].PerformMaintanance();
                            }
                        }
                        Console.WriteLine("You repaired the pets!");
                        break;

                    case "6":

                        Console.WriteLine("What pet do you want to interact with?");


                        break;

                    case "7":
                        for (int i = 0; i < shelter.ListofPets.Count; i++)
                        {
                            if (shelter.ListofPets[i].IsOrganic  == true)
                            {
                                Console.WriteLine($"{shelter.ListofPets[i].Name} the organic {shelter.ListofPets[i].Species}- Hunger: {shelter.ListofPets[i].Hunger} " +
                                    $"Health: {shelter.ListofPets[i].Health} Boredom: {shelter.ListofPets[i].Boredom}");
                            }
                            else if (shelter.ListofPets[i].IsOrganic == false)
                            {
                                //Console.WriteLine($"{shelter.ListofPets[i].Name} the robotic {shelter.ListofPets[i].Species}- Oil: {shelter.ListofPets[i].Oil} " +
                                    //$"Performance: {shelter.ListofPets[i].Performance} Boredom: {shelter.ListofPets[i].Boredom}");
                            }
                        }
                        break;

                    case "8":
                        Console.WriteLine("Thank you for taking care of the pets.");
                        returnToOffice = true;
                        break;

                    default:
                        Console.WriteLine("Please select a valid option");
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }



                
                void SinglePet()
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
