System.Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    System.Console.WriteLine("1 - Calculator, 2 - Access Control, 3 - Student, 4 - Order, 0 - Exit");
    System.Console.Write("Choose task: ");
    string choice = System.Console.ReadLine() ?? "";

    if (choice == "0")
    {
        break;
    }

    switch (choice)
    {
        // ---------- Task 1: Calculator ----------
        case "1":
            while (true)
            {
                System.Console.Write("Enter first number (or 'exit'): ");
                string first = System.Console.ReadLine() ?? "";
                if (first == "exit")
                {
                    break;
                }
                System.Console.Write("Enter second number: ");
                string second = System.Console.ReadLine() ?? "";
                System.Console.Write("Enter operation (+, -, *, /): ");
                string operation = System.Console.ReadLine() ?? "";

                if (!double.TryParse(first, out double num1) || !double.TryParse(second, out double num2))
                {
                    System.Console.WriteLine("Please enter valid numbers!");
                    continue;
                }

                Calculator calculator = new Calculator(num1, num2);
                switch (operation)
                {
                    case "+":
                        System.Console.WriteLine($"Result: {calculator.Sum()}");
                        break;
                    case "-":
                        System.Console.WriteLine($"Result: {calculator.Subtract()}");
                        break;
                    case "*":
                        System.Console.WriteLine($"Result: {calculator.Multiplication()}");
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            System.Console.WriteLine("Cannot divide by zero!");
                        }
                        else
                        {
                            System.Console.WriteLine($"Result: {calculator.Division()}");
                        }
                        break;
                    default:
                        System.Console.WriteLine("Unknown operation!");
                        break;
                }
            }
            break;

        // ---------- Task 2: Access Control ----------
        case "2":
            User[] users = new User[5];
            users[0] = new User("Shahrom", "Azizmurodov", "shahrom", "1111");
            users[1] = new User("Olamafruz", "Azizzoda", "olama", "2222");
            users[2] = new User("Muhammad", "Mirzoev", "muhammad", "3333");
            users[3] = new User("John", "Doe", "john", "4444");
            users[4] = new User("Emily", "Parker", "emily", "5555");

            while (true)
            {
                System.Console.Write("Enter username (or 'exit'): ");
                string userName = System.Console.ReadLine() ?? "";
                if (userName == "exit")
                {
                    break;
                }
                System.Console.Write("Enter password: ");
                string password = System.Console.ReadLine() ?? "";

                bool found = false;
                foreach (User user in users)
                {
                    if (user.Login(userName, password))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    System.Console.WriteLine("Login failed!");
                }
            }
            break;

        // ---------- Task 3: Student ----------
        case "3":
            Student student1 = new Student(1, "Shahrom", 20, 4.5);
            Student student2 = new Student(2, "Olamafruz", 15, 3.8);
            student1.GetInfo();
            System.Console.WriteLine($"Excellent: {student1.IsExcellentStudent()}");
            student2.GetInfo();
            System.Console.WriteLine($"Excellent: {student2.IsExcellentStudent()}");
            break;

        // ---------- Task 4: Order ----------
        case "4":
            Order order1 = new Order(101, "Ноутбук", 2, 2500.0m);
            Order order2 = new Order("Смартфон", 5);
            Order order3 = new Order("Наушники", 120.5m);

            System.Console.WriteLine("Информация о заказах:");
            order1.DisplayInfo();
            order2.DisplayInfo();
            order3.DisplayInfo();
            break;

        default:
            System.Console.WriteLine("Unknown task!");
            break;
    }

    System.Console.WriteLine();
}