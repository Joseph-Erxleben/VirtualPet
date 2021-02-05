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
                            Console.WriteLine(shelter.ListofPets[userPetIndex].Name + " has been adopted.");
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
                                shelter.ListofPets[i].GiveOil();
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
                                shelter.ListofPets[i].PerformMaintenance();
                            }
                        }
                        Console.WriteLine("You repaired the pets!");
                        break;

                    case "6":

                        Console.WriteLine("What pet do you want to interact with?");
                        string userPet = Console.ReadLine();

                        int userPetIndex = shelter.SelectPet(userPet);

                        SinglePet(userPetIndex);

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
                                Console.WriteLine($"{shelter.ListofPets[i].Name} the robotic {shelter.ListofPets[i].Species}- Oil: {shelter.ListofPets[i].Oil} " +
                                    $"Performance: {shelter.ListofPets[i].Performance} Boredom: {shelter.ListofPets[i].Boredom}");
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

                shelter.Tick();
                Console.ReadKey();
                Console.Clear();
            }



                
                void SinglePet(int index)
            {

                bool returnToKennel = false;
                while (returnToKennel == false)
                {
                    Console.Clear();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Name/Rename " + shelter.ListofPets[index].Name);
                    Console.WriteLine("2. Change Species of " + shelter.ListofPets[index].Name);
                    if (shelter.ListofPets[index].IsOrganic == true)
                    {
                        Console.WriteLine("3. Feed " + shelter.ListofPets[index].Name);
                        Console.WriteLine("4. Play with " + shelter.ListofPets[index].Name);
                        Console.WriteLine("5. Take " + shelter.ListofPets[index].Name + " to Doctor");

                    }
                    else
                    {
                        Console.WriteLine("3. Oil " + shelter.ListofPets[index].Name);
                        Console.WriteLine("4. Play with " + shelter.ListofPets[index].Name);
                        Console.WriteLine("5. Perform Maintenance on " + shelter.ListofPets[index].Name);
                    }
                    Console.WriteLine("6. Check " + shelter.ListofPets[index].Name + "'s status");
                    Console.WriteLine("7. Return to Kennel");

                    playerChoice = Console.ReadLine();

                    switch (playerChoice)
                    {
                        case "1":
                            Console.WriteLine("What would you like you to rename your pet?");
                            shelter.ListofPets[index].Name = Console.ReadLine();
                            Console.WriteLine("You named your pet " + shelter.ListofPets[index].Name);
                            break;
                        case "2":
                            Console.WriteLine("What species do you want " + shelter.ListofPets[index].Name + " to be?");
                            shelter.ListofPets[index].Species = Console.ReadLine();
                            Console.WriteLine(shelter.ListofPets[index].Name + " is a " + shelter.ListofPets[index].Species);
                            break;
                        case "3":

                            if (shelter.ListofPets[index].IsOrganic == true)
                            {
                                Console.WriteLine("What would you like to feed " + shelter.ListofPets[index].Name + "?");
                                string food = Console.ReadLine();
                                if (random.Next(1, 100) < shelter.ListofPets[index].Boredom)
                                {
                                    Console.WriteLine(shelter.ListofPets[index].Name + " doesnt't want your food.");
                                }
                                else
                                {
                                    pet.Feed(food.ToLower());
                                    Console.WriteLine("You fed " + shelter.ListofPets[index].Name);
                                    Console.WriteLine(shelter.ListofPets[index].Name + "s hunger level is " + shelter.ListofPets[index].Hunger);
                                }

                            }

                            else
                            {
                                Console.WriteLine("You oiled " + shelter.ListofPets[index].Name);
                                shelter.ListofPets[index].GiveOil();
                                Console.WriteLine(shelter.ListofPets[index].Name + "'s oil level is " + shelter.ListofPets[index].Oil);
                            }
                            break;
                        case "4":
                            pet.Play();
                            Console.WriteLine("You played with " + shelter.ListofPets[index].Name);
                            Console.WriteLine(shelter.ListofPets[index].Name + "s boredom level is " + shelter.ListofPets[index].Boredom);
                            if (shelter.ListofPets[index].IsOrganic == true)
                            {
                            Console.WriteLine(shelter.ListofPets[index].Name + "s health level is " + shelter.ListofPets[index].Health);
                            Console.WriteLine(shelter.ListofPets[index].Name + "s hunger level is " + shelter.ListofPets[index].Hunger);

                            }

                            else
                            {
                                Console.WriteLine(shelter.ListofPets[index].Name + "s oil level is " + shelter.ListofPets[index].Oil);
                                Console.WriteLine(shelter.ListofPets[index].Name + "s performance level is " + shelter.ListofPets[index].Performance);

                            }
                            break;
                        case "5":

                            if (shelter.ListofPets[index].IsOrganic == true)
                            {
                                pet.SeeDoctor();
                                Console.WriteLine("You took " + shelter.ListofPets[index].Name + " to the doctor.");
                                Console.WriteLine(shelter.ListofPets[index].Name + "'s health is now " + shelter.ListofPets[index].Health);

                            }
                            else
                            {
                                pet.PerformMaintenance();
                                Console.WriteLine("You performed maintenance on " + shelter.ListofPets[index].Name);
                                Console.WriteLine(shelter.ListofPets[index].Name + "'s oil level is now " + shelter.ListofPets[index].Oil);
                                Console.WriteLine(shelter.ListofPets[index].Name + "'s performance level is now " + shelter.ListofPets[index].Performance);
                            }
                            break;
                        case "6":
                            Console.WriteLine(shelter.ListofPets[index].Name);
                            Console.WriteLine(shelter.ListofPets[index].Species);
                            if (shelter.ListofPets[index].IsOrganic == true)
                            {

                                Console.WriteLine("Hunger: " + shelter.ListofPets[index].Hunger);
                                Console.WriteLine("Health: " + shelter.ListofPets[index].Health);
                            }
                            else
                            {
                                Console.WriteLine("Oil: " + shelter.ListofPets[index].Oil);
                                Console.WriteLine("Performance: " + shelter.ListofPets[index].Performance);
                            }
                            Console.WriteLine("Boredom: " + shelter.ListofPets[index].Boredom);

                            break;
                        case "7":
                            Console.WriteLine("Thank you for playing with " + shelter.ListofPets[index].Name + "!");
                            returnToKennel = true;

                            break;

                        default:
                            Console.WriteLine("Please enter a valid entry");
                            break;

                    }

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    Console.Clear();
                    shelter.ListofPets[index].Tick();

                    //if (shelter.ListofPets[index].Health <= 0)
                    //{
                    //    Console.WriteLine(shelter.ListofPets[index].Name.ToUpper() + " HAS DIED!");

                    //    returnToKennel = true;
                    //}

                    //else if (shelter.ListofPets[index].Performance <= 0)
                    //{
                    //    Console.WriteLine(shelter.ListofPets[index].Name.ToUpper() + " HAS BROKEN!");

                        
                    //    returnToKennel = true;
                    //}

                    //else if (shelter.ListofPets[index].Hunger > 100)
                    //{

                    //    shelter.ListofPets[index].Hunger -= 10;
                    //    Console.WriteLine(shelter.ListofPets[index].Name + " got hungry and found some food on their own.");

                    //}

                    //else if (shelter.ListofPets[index].Oil < 0)
                    //{
                    //    shelter.ListofPets[index].Oil += 10;
                    //    Console.WriteLine(shelter.ListofPets[index].Name + " got squeaky and found some oil on it's own.");
                    //}

                    //else if (shelter.ListofPets[index].Boredom > 100)
                    //{
                    //    shelter.ListofPets[index].Boredom -= 10;
                    //    Console.WriteLine(shelter.ListofPets[index].Name + " got bored and found a toy to play with.");

                    //}

                    //if (shelter.ListofPets[index].Health <= 0)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(X - X)");
                    //    Console.WriteLine("c(\")(\")");
                    //    shelter.RemovePet(index);
                    //}

                    //else if (shelter.ListofPets[index].Performance <= 0)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(X - X)");
                    //    Console.WriteLine("c(\")(\")");
                    //    shelter.RemovePet(index);
                    //}

                    //else if (shelter.ListofPets[index].Health < 20)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(0 ~ 0)");
                    //    Console.WriteLine("c(\")(\")");
                    //}

                    //else if (shelter.ListofPets[index].Performance <20)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(0 ~ 0)");
                    //    Console.WriteLine("c(\")(\")");
                    //}

                    //else if (shelter.ListofPets[index].Boredom > 80)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(- X -)");
                    //    Console.WriteLine("c(\")(\")");
                    //}

                    //else if (shelter.ListofPets[index].Hunger > 80)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(' O ')");
                    //    Console.WriteLine("c(\")(\")");
                    //}

                    //else if (shelter.ListofPets[index].Oil < 20)
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(' O ')");
                    //    Console.WriteLine("c(\")(\")");
                    //}

                    //else
                    //{
                    //    Console.WriteLine(@"(\ _ /)");
                    //    Console.WriteLine("(' X ')");
                    //    Console.WriteLine("c(\")(\")");
                    //}
                    //Console.ReadKey();

                }

                }
        

        }
    }
}
