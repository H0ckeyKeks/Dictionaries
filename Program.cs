namespace Dictionaries_Excercise
{
    // Task 1: Defining a class "Student" with properties "Id", "Name", and "Grade"
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int id, int grade)
        {
            Name = name;
            Id = id;
            Grade = grade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2: Initializing a Dictionary with keys as student names and values as Student objects
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            // Task 3: Adding at least three Student objects to the dictionary 
            students.Add("John", new Student("John", 1, 85));
            students.Add("Alice", new Student("Alice", 2, 90));
            students.Add("Bob", new Student("Bob", 3, 78));

            // Task 4: Iterating through the dictionary and printing each student's details to the console
            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.Value.Name}, Id: {item.Value.Id}, Grade: {item.Value.Grade}");
            }
        }
    }
}
