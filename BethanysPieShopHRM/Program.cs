using BethanysPieShopHRM;
using BethanysPieShopHRM.HR;


List<Employee> employees = new List<Employee>();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("* Bethany's Pie Shop Employee App *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Load Specific Employee data");
    Console.WriteLine("9: Quit application");
    Console.WriteLine("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.LoadEmployeeByID(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}
while (userSelection != "9");

Console.WriteLine("Thanks for using the application");


//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowall.com", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//Employee audu = new("Audu", "Ali", "aali@snowall.com", new DateTime(1984, 3, 23), 30, EmployeeType.Research);

//#region First run Bethany

//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//bethany.ReceiveWage();
//bethany.DisplayEmployeeDetails();

//#endregion


//#region First run George

//audu.PerformWork(10);
//audu.PerformWork();
//audu.PerformWork();
//audu.ReceiveWage();
//audu.DisplayEmployeeDetails();

//#endregion


//Employee.taxRate = 0.02;

//#region Second run Bethany

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.ReceiveWage();
//bethany.DisplayEmployeeDetails();

//#endregion

//#region Second run George

//audu.PerformWork();
//audu.PerformWork();
//audu.PerformWork();
//audu.ReceiveWage();
//audu.DisplayEmployeeDetails();

//#endregion

//Employee.DisplayTaxRate();

//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };
//Console.WriteLine("How many employees IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//int[] employeesIds = new int[length];

//var testId = employeesIds[0];

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeesIds[i] = id;
//}

//for (int i = 0; i < employeesIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeesIds[i]}");
//}

//List<int> employeeIds = new List<int>();


//Console.WriteLine("How many employees IDs do you want to register");

//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds.Add(id);
//}

//IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowall.com", new DateTime(1979, 1, 16), 25);
//IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
//IEmployee bobjunior = new JuniorResearcher("bob", "Spencer", "bob@snowball.be", new DateTime(1988,1,23), 17);
//IEmployee kevin = new StoreManager("bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
//IEmployee kate = new StoreManager("bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(mary);
//employees.Add(bobjunior);
//employees.Add(kevin);
//employees.Add(kate);

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCompliment();
//}

//Employee jake = new Employee("Jake", "Smith", "jake@snowall.com", new DateTime(1995, 1, 16), 25, "New street", "123", "123456", "Pie ville");
//string streetName = jake.Address.Street;


//bethany.DisplayEmployeeDetails();
//bethany.PerformWork(8);
//bethany.PerformWork();
//bethany.PerformWork(3);
//bethany.ReceiveWage();

//mary.DisplayEmployeeDetails();
//mary.PerformWork(25);
//mary.PerformWork();
//mary.PerformWork();
//mary.ReceiveWage();
////mary.AttendManagementMeeting();

//bobjunior.ResearchNewPieTastes(5);
//bobjunior.ResearchNewPieTastes(5);



//List<Employee> employees = new List<Employee>();
//employees.Add(audu);
//employees.Insert(0, bethany);
//employees.Add(mary);
//employees.Add(bob);
//employees.Add(kevin);
//employees.Add(kate);
//employees.Add(kim);

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//}

//Employee[] employees = new Employee[7];
//employees[0] = bethany;
//employees[1] = audu;
//employees[2] = mary;
//employees[3] = bob;
//employees[4] = kevin;
//employees[5] = kate;
//employees[6] = kim;

//foreach (Employee e in employees)
//{ 
//    e.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    e.PerformWork(numberOfHoursWorked);
//    e.ReceiveWage();
//}


//string bethanyAsJson = bethany.ConvertToJson();
//Console.WriteLine(bethanyAsJson);


//bethany.PerformWork(25);

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

//int minimumBonus = 100;
//int bonusTax;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");


//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

//var receivedWageAudu = audu.ReceiveWage(true);

//WorkTask task;
//task.description = "Bake delicious pies";
//task.hours = 3;
//task.PerformWorkTask();