namespace Session5;

class Program
{
    static void Main(string[] args)
    { 
        //Task 1: Fixed Grades Array
        int[] grades = new int[5];

        for (int i = 0; i < grades.Length; i++) {
            Console.Write($"Enter grade {i + 1}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Grades entered:");
        foreach (int grade in grades) {
            Console.WriteLine(grade);
        }
        
        //Task 2: Dynamic To-Do List
        List<string> todoList = new List<string>();

        for (int i = 0; i < 5; i++) {
            Console.Write($"Enter task {i + 1}: ");
            todoList.Add(Console.ReadLine());
        }

        Console.WriteLine("\nYour To-Do List:");
        int count = 1;
        foreach (string task in todoList) {
            Console.WriteLine($"{count++}. {task}");
        }
        
        //Task 3: Browsing History Stack
        Stack<string> history = new Stack<string>();

        for (int i = 0; i < 3; i++) {
            Console.Write($"Enter URL {i + 1}: ");
            history.Push(Console.ReadLine());
        }

        Console.WriteLine($"\nPressing back button... Landing on: {history.Pop()}");
        
        //Task 4: Customer Service Queue
        Queue<string> customers = new Queue<string>();

        for (int i = 0; i < 3; i++) {
            Console.Write($"Enter customer name {i + 1}: ");
            customers.Enqueue(Console.ReadLine());
        }

        Console.WriteLine($"\nServing customer: {customers.Dequeue()}");
        
        //Task 5: Array Grade Range
        int[] Grades = new int[5];
        int sum = 0;

        for (int i = 0; i < Grades.Length; i++) {
            Console.Write($"Enter grade {i + 1}: ");
            Grades[i] = int.Parse(Console.ReadLine());
            sum += Grades[i];
        }

        Array.Sort(grades);
        double average = sum / 5.0;

        Console.WriteLine($"\nLowest Grade: {Grades[0]}");
        Console.WriteLine($"Highest Grade: {Grades[4]}");
        Console.WriteLine($"Average: {average}");
        
    
    }
}