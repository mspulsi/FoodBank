namespace FoodBank;

public class FoodItem
{
    // food item attributes
    public string name = "";
    public string category = "";
    public int quantity = 0;
    public string expDate = "";
    
    // constructor that assigns the attributes
    public FoodItem(string name, string category, int quantity, string expDate)
    {
        this.name = name;
        this.category = category;
        this.quantity = quantity;
        this.expDate = expDate;
    }
}
