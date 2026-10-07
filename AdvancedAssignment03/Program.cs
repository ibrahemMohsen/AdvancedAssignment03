namespace AdvancedAssignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            //List<int> grades = new List<int>()
            //{
            //    85, 92, 78, 95, 88, 70, 100, 65
            //};
            
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First: {grades[0]}");
            //Console.WriteLine($"Count: {grades[^1]}");

            //grades.Sort();
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(grades.Find(x => x > 90));

            //Console.WriteLine(string.Join(", ",grades.FindAll(x => x < 75)));
            //Console.WriteLine();

            //grades.RemoveAll(x => x < 75);
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(grades.Contains(100));

            //List<string> gradesText = grades.ConvertAll(x => $"Grade:{x}");
            //foreach (string grade in gradesText)
            //{
            //    Console.Write(grade + ", ");
            //}
            //Console.WriteLine();
            #endregion

            #region Exercise02
            //SortedDictionary<int, string> leaderboard = new()
            //{
            //    {500, "Ahmed" },
            //    {200, "Sara" },
            //    {800, "Ali" },
            //    {350, "Mona" }
            //};
            //Console.WriteLine(string.Join(", ", leaderboard));

            //var leaderboardEnum = leaderboard.GetEnumerator();
            //leaderboardEnum.MoveNext();
            //Console.WriteLine($"Key: {leaderboardEnum.Current.Key}, Value: {leaderboardEnum.Current.Value}");

            //Console.WriteLine(leaderboard.ContainsKey(500));

            //if (leaderboard.TryGetValue(999, out string? value))
            //{
            //    Console.WriteLine($"Value: {value}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            //leaderboard.Remove(200);
            //Console.WriteLine("Updated Leaderboard: ");
            //foreach(var element in leaderboard)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
        }
    }
}
