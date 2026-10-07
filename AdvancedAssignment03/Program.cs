namespace AdvancedAssignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            List<int> grades = new List<int>()
            {
                85, 92, 78, 95, 88, 70, 100, 65
            };
            
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First: {grades[0]}");
            Console.WriteLine($"Count: {grades[^1]}");

            grades.Sort();
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();

            Console.WriteLine(grades.Find(x => x > 90));

            Console.WriteLine(string.Join(", ",grades.FindAll(x => x < 75)));
            Console.WriteLine();

            grades.RemoveAll(x => x < 75);
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();

            Console.WriteLine(grades.Contains(100));

            List<string> gradesText = grades.ConvertAll(x => $"Grade:{x}");
            foreach (string grade in gradesText)
            {
                Console.Write(grade + ", ");
            }
            Console.WriteLine();
            #endregion


        }
    }
}
