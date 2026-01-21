using FoodBank;

List<FoodItem> foodItems = new List<FoodItem>();
string userInput = "";

Console.WriteLine("Welcome to FoodBank!");

do
{
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a: add a food item");
    Console.WriteLine("b: delete a food item");
    Console.WriteLine("c: display food items");
    Console.WriteLine("d: exit program");
    userInput = Console.ReadLine();
    Console.Clear();
    if (userInput == "a")
    {
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
        FoodItem newItem = new FoodItem(name, category, quantity, expDate);
        foodItems.Add(newItem);
        Console.Clear();
        Console.WriteLine("New food item has been added.");
    } 
    else if (userInput == "b")
    {
        Console.WriteLine("Enter the name of the food item you want to delete:");
        string name = Console.ReadLine();
        int index = foodItems.FindIndex(x => x.name == name);
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
    else if (userInput == "c")
    {
        foreach (FoodItem foodItem in foodItems)
        {
            Console.WriteLine(foodItem.name + " - " + foodItem.category + " qty:" + foodItem.quantity + " exp:"  + foodItem.expDate);
        }
    }
    else if (userInput == "d")
    {
        Console.WriteLine("Goodbye");
    }
    else
    {
         Console.WriteLine("Invalid input");
    }

} while (userInput != "d");
