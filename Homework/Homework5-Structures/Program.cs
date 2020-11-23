using System;

public struct Pet
{
    public string Name;
    public string TypeOfPet;
}

class Program
{
    static void Main()
    {
        var numberOfPets = 0;
        var pets = new Pet[10];

        while (true)
        {
            //Give instructions to the user
            //Will need to change to add the "change" functionality
            Console.Write("A)dd C)hange D)elete L)ist pets:");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "A":
                case "a":
                    {
                        Console.Write("Name :");
                        var name = Console.ReadLine();

                        Console.Write("Type of pet :");
                        var typeOfPet = Console.ReadLine();

                        pets[numberOfPets].Name = name;
                        pets[numberOfPets].TypeOfPet = typeOfPet;


                        numberOfPets++;
                        break;
                    }
                case "C":
                case "c":
                    {
                        //
                        //This section will allow the user to change the name and type of the pet.
                        //
                        
                        //First use the same code from the "List" section so that the user can see what pets are available to change
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("No pets");
                        }

                        for (int index = 0; index < numberOfPets; index++)
                        {
                            Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                        }

                        //Now to change the pet

                        //Ask the user which pet they want to change
                        Console.Write("Which pet to change (1-{0})", numberOfPets);
                        var petNumberToChange = Console.ReadLine();
                        var indexToChange = int.Parse(petNumberToChange);
                        indexToChange--;

                        Console.Write("Name :");
                        var name = Console.ReadLine();

                        Console.Write("Type of pet :");
                        var typeOfPet = Console.ReadLine();

                        //Modify the pet
                        pets[indexToChange].Name = name;
                        pets[indexToChange].TypeOfPet = typeOfPet;
                        

                        break;
                    }

                case "D":
                case "d":
                    {
                        //Check if there are no pets
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("No pets");
                            break;
                        }

                        //Display current pets
                        for (var index = 0; index < numberOfPets; index++)
                        {
                            Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                        }

                        //Ask the user which pet they want to remove
                        Console.Write("Which pet to remove (1-{0})", numberOfPets);

                        var petNumberToDelete = Console.ReadLine();
                        var indexToDelete = int.Parse(petNumberToDelete);

                        // Squish the array from index to the end

                        for (var index = indexToDelete - 1; index < numberOfPets; index++)
                        {
                            // TODO: Just copy the pet from the next index into the current index
                            pets[index] = pets[index + 1];
                        }

                        // We have one less pet
                        numberOfPets--;

                        break;
                    }

                case "L":
                case "l":
                    {
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("No pets");
                        }

                        for (int index = 0; index < numberOfPets; index++)
                        {
                            Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option [{0}]", choice);
                        break;
                    }
            }
        }
    }
}