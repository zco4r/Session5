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
        
        //Task 6: Filtered Shopping List
        List<string> shoppingList = new List<string>();
        string input;

        Console.WriteLine("Enter items (type 'done' to finish):");
        while ((input = Console.ReadLine()) != "done") {
            shoppingList.Add(input);
        }

        Console.WriteLine("\nCurrent List: " + string.Join(", ", shoppingList));
        Console.Write("Enter an item to remove: ");
        string toRemove = Console.ReadLine();

        if (shoppingList.Remove(toRemove)) {
            Console.WriteLine($"Removed '{toRemove}'.");
        } else {
            Console.WriteLine("Item not found.");
        }

        Console.WriteLine("Final List: " + string.Join(", ", shoppingList));
        
        //Task 7: High Score Podium
        List<int> scores = new List<int>();
        for (int i = 0; i < 5; i++) {
            Console.Write($"Enter score {i + 1}: ");
            scores.Add(int.Parse(Console.ReadLine()));
        }

        scores.Sort();
        scores.Reverse();

        Console.WriteLine($"\n1st place: {scores[0]}");
        Console.WriteLine($"2nd place: {scores[1]}");
        Console.WriteLine($"3rd place: {scores[2]}");
        
        //Task 8: Undo Last Action
        Stack<string> actions = new Stack<string>();
        string Input;

        Console.WriteLine("Enter actions (type 'stop' to finish):");
        while ((input = Console.ReadLine()) != "stop") {
            actions.Push(input);
        }

        Console.WriteLine("\nUndoing actions:");
        for (int i = 0; i < 2 && actions.Count > 0; i++) {
            Console.WriteLine($"Undone: {actions.Pop()}");
        }

        Console.WriteLine("\nRemaining actions:");
        foreach (string action in actions) {
            Console.WriteLine(action);
        }
        
        //Task 9: Grade Analyzer with Functions
        static void Main() {
            Console.Write("How many grades? ");
            int count = int.Parse(Console.ReadLine());
            List<int> grades = new List<int>();
            for (int i = 0; i < count; i++) {
                Console.Write($"Enter grade {i + 1}: ");
                grades.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Average: {CalculateAverage(grades)}");
    
            int failing = FindFirstFailing(grades);
            if (failing != 0) Console.WriteLine($"First failing grade: {failing}");
            else Console.WriteLine("No failing grades found.");
        }

        static double CalculateAverage(List<int> list) => list.Average();

        static int FindFirstFailing(List<int> list) => list.Find(x => x < 60);
    
    }
}