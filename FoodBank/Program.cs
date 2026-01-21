using FoodBank;

// instantiate needed list and input variable
List<FoodItem> foodItems = new List<FoodItem>();
string userInput = "";

Console.WriteLine("Welcome to FoodBank!");

do
{
    // display a simple menu for user
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a: add a food item");
    Console.WriteLine("b: delete a food item");
    Console.WriteLine("c: display food items");
    Console.WriteLine("d: exit program");
    userInput = Console.ReadLine();
    Console.Clear();
    
    // add item
    if (userInput == "a")
    {
        // when a then prompt user for necessary info to make a new food item
        Console.WriteLine("Enter the name of the food item:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the category of the food item:");
        string category = Console.ReadLine();
        Console.WriteLine("Enter the quantity of the food item:");
        int quantity = int.Parse(Console.ReadLine());
        if (quantity < 0)
        {
            while (quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative, please try again");
                quantity = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter the expiration date of the food item");
        string expDate = Console.ReadLine();
        
        // make a new item and add to the list
        FoodItem newItem = new FoodItem(name, category, quantity, expDate);
        foodItems.Add(newItem);
        Console.Clear();
        Console.WriteLine("New food item has been added.");
    } 
    
    // delete item
    else if (userInput == "b")
    {
        // get the name of the item user wants to delete
        Console.WriteLine("Enter the name of the food item you want to delete:");
        string name = Console.ReadLine();
        
        // find it in the list
        int index = foodItems.FindIndex(x => x.name == name);
        
        // delete if it is there, else tell user it doesn't exist
        if (index != -1)
        {
            foodItems.RemoveAt(index);
            Console.WriteLine("The food item has been deleted.");
        }
        else
        {
            Console.WriteLine("No such food item in the list");
        }
    }
    
    // print out all items and their info from the list
    else if (userInput == "c")
    {
        foreach (FoodItem foodItem in foodItems)
        {
            Console.WriteLine(foodItem.name + " - " + foodItem.category + " qty:" + foodItem.quantity + " exp:"  + foodItem.expDate);
        }
    }
    
    // exit the program
    else if (userInput == "d")
    {
        Console.WriteLine("Goodbye");
    }
    
    // message if any other input is given
    else
    {
         Console.WriteLine("Invalid input");
    }

} while (userInput != "d");
