namespace FoodBank;

public class FoodItem
{
    public string name = "";
    public string category = "";
    public int quantity = 0;
    public string expDate = "";
    
    public FoodItem(string name, string category, int quantity, string expDate)
    {
        this.name = name;
        this.category = category;
        this.quantity = quantity;
        this.expDate = expDate;
    }
}
