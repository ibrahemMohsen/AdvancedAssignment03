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
            //    {500, "Ebrahim" },
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

            #region Exercise03
            //Dictionary<string, string> phoneBook = new()
            //{
            //    ["Ahmed"] = "12345",
            //    ["Sara"] = "67890",
            //    ["Ali"] = "45323",
            //    ["Mona"] = "16731",
            //};

            /*
             System.ArgumentException
             HResult = 0x80070057
              Message = An item with the same key has already been added.Key: Ahmed
              Source = System.Private.CoreLib
            */

            // phoneBook.Add("Ahmed", "1234");

            //if (phoneBook.TryAdd("Ahmed", "1234"))
            //{
            //    Console.WriteLine("Succeeded! Ahmed Added");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to Add Ahmed");

            //}

            //if (phoneBook.TryGetValue("Amr", out string? value))
            //{
            //    Console.WriteLine($"Value: {value}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}


            //phoneBook.GetValueOrDefault("Amr", "Not Found");

            //foreach(var x in phoneBook.Keys)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();
            //foreach(var x in phoneBook.Values)
            //{
            //    Console.Write(x + " ");
            //}
            #endregion


            #region Exercise04
            HashSet<string> emailValidator = new(StringComparer.OrdinalIgnoreCase)
            {
                "ahmed@test.com",
                "AHMED@test.com",
                "sara@test.com",
                "Sara@test.com",
            };

            // Prints 2, since HashSet stores only unique elements and our comparer is case insensitive
            Console.WriteLine(emailValidator.Count);

            Console.WriteLine();
            HashSet<int> a = new() { 1, 2, 3, 4, 5 };
            HashSet<int> b = new() { 4, 5, 6, 7, 8 };

            var union = new HashSet<int>(a);
            union.UnionWith(b);
            foreach (int element in union)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            var intersect = new HashSet<int>(a);
            intersect.IntersectWith(b);
            foreach (int element in intersect)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            var except = new HashSet<int>(a);
            except.ExceptWith(b);
            foreach (int element in except)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();


            Console.WriteLine(a.IsSubsetOf([1, 2]));
            
            #endregion
        }
    }
}
