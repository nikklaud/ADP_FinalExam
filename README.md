# ADP_FinalExam

Во втором заднии сделал оба задания (Java и C#) так как они отличаются но Java перевел на C# 

В задании с подсчетом стоимости корзины метод DRY нарушался потому что цикл с подсчетом повторялся для каждой картинки поэтому вынес подсчет суммы в статический метод 
```
static double CalculateTotalPrice(List<Product> cart)
        {
            double totalPrice = 0;
            foreach (var product in cart)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
```

В задании с управлением пользователями из раза в раз повторялось 
```
        if (username == null || username.isEmpty())
```
Поэтому сделал отдельные методы валидации 
```
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
```

По хорошему валидатор должен быть отдельным классом но что бы не нарушать принцип YAGNI сделаю реализацию в самом классе 



Created by SandvichLover
