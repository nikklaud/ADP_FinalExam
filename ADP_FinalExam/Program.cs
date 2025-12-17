class Program
{
    static void Main()
    {
        List<Product> cart1 = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000 },
            new Product { Name = "Mouse", Price = 50 }
        };

        List<Product> cart2 = new List<Product>
        {
            new Product { Name = "Keyboard", Price = 100 },
            new Product { Name = "Monitor", Price = 300 }
        };
        
        Console.WriteLine($"Total for cart1: {CalculateTotalPrice(cart1)}");
        Console.WriteLine($"Total for cart2: {CalculateTotalPrice(cart2)}");

        //Вынес код подсчета суммы корзины в статический метод что бы он не повторялся
        static double CalculateTotalPrice(List<Product> cart)
        {
            double totalPrice = 0;
            foreach (var product in cart)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

//Не знаю надо или не надо делать задание данное на джаве но раз код отлитчается то лучше сделаю 
public class UserManagment
{
    public void AddUser(string username, string email)
    {
        if (!IsValidUsername(username) || !IsValidEmail(email))
        {
            return;
        }
        Console.WriteLine($"{username} has bin added");
    }

    public void UpdateUser(string username, string email)
    {
        if (!IsValidUsername(username) || !IsValidEmail(email))
        {
            return;
        }
        Console.WriteLine($"{username} has bin updated");
    }

    public void DeleteUser(string username, string email)
    {
        if (!IsValidUsername(username) || !IsValidEmail(email))
        {
            return;
        }
        Console.WriteLine($"{username} has bin deleted");
    }
    
    //в изначальном коде провекрка валидности данных была в виде if() конструкций выношу в методы валидации 
    private bool IsValidUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            Console.WriteLine("Invalid username");
            return false;
        }
        return true;
    }

    private bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Invalid email");
            return false;
        }
        return true;
    }
    
    //По хорошему валидатор должен быть отдельным классом по SOLID но в задании сказано только про DRY поэтому что бы не нарушать YAGNI сделал простейшую реализацию
}