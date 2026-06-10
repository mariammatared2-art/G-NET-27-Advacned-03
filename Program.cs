namespace Advanced_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            
                //Console.WriteLine("--- Exercise 1: Student Grade Manager ---");
                //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

                //Console.WriteLine($"Grades: {string.Join(", ", grades)}");
                //Console.WriteLine($"Count: {grades.Count}");
                //Console.WriteLine($"First Grade: {grades.First()}");
                //Console.WriteLine($"Last Grade: {grades.Last()}");

                //grades.Sort();
                //Console.WriteLine($"Sorted Grades: {string.Join(", ", grades)}");

                //int firstAbove90 = grades.FirstOrDefault(g => g > 90);
                //Console.WriteLine($"First grade above 90: {firstAbove90}");

                //var failingGrades = grades.Where(g => g < 75);
                //Console.WriteLine($"Failing grades (below 75): {string.Join(", ", failingGrades)}");

                //grades.RemoveAll(g => g < 75);
                //Console.WriteLine($"Grades after removing failures: {string.Join(", ", grades)}");

                //bool hasPerfectScore = grades.Contains(100);
                //Console.WriteLine($"Any grade equals 100?: {hasPerfectScore}");

                //List<string> formattedGrades = grades.Select(g => $"Grade: {g}").ToList();
                //Console.WriteLine("Formatted Grades:");
                //formattedGrades.ForEach(Console.WriteLine);
                //Console.WriteLine();

            #endregion

            #region Exercise 2
           
                //Console.WriteLine("--- Exercise 2: Leaderboard ---");

                //SortedList<int, string> leaderboard = new SortedList<int, string>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

                //leaderboard.Add(500, "Ahmed");
                //leaderboard.Add(200, "Sara");
                //leaderboard.Add(800, "Ali");
                //leaderboard.Add(350, "Mona");

                //Console.WriteLine("Leaderboard Entries:");
                //foreach (KeyValuePair<int, string> entry in leaderboard)
                //{
                //    Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
                //}

                //Console.WriteLine($"First Key (Highest Score): {leaderboard.Keys[0]}");
                //Console.WriteLine($"First Value (Top Player): {leaderboard.Values[0]}");

                //Console.WriteLine($"Does score 500 exist?: {leaderboard.ContainsKey(500)}");

                //if (leaderboard.TryGetValue(999, out string player))
                //{
                //    Console.WriteLine($"Player with 999: {player}");
                //}
                //else
                //{
                //    Console.WriteLine("Player with score 999 not found.");
                //}

                //leaderboard.Remove(200);
                //Console.WriteLine("Updated Leaderboard after removing score 200:");
                //foreach (var entry in leaderboard)
                //{
                //    Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
                //}
                //Console.WriteLine();
            
            #endregion

            #region Exercise 3
          
        //        Console.WriteLine("--- Exercise 3: Phone Book ---");

        //        Dictionary<string, string> phoneBook = new Dictionary<string, string>
        //{
        //    { "John", "123-456" },
        //    { "Jane", "987-654" },
        //    { "Bob", "555-789" },
        //    { "Alice", "444-111" }
        //};

        //        phoneBook["Charlie"] = "222-333";

        //        try
        //        {
        //            phoneBook.Add("John", "000-000");
        //        }
        //        catch (ArgumentException ex)
        //        {
        //            Console.WriteLine($"[Exception caught] Cannot add duplicate key: {ex.Message}");
        //        }

        //        bool isAdded = phoneBook.TryAdd("John", "999-999");
        //        Console.WriteLine($".TryAdd() duplicate succeeded?: {isAdded}");

        //        Console.WriteLine($"Does 'Sam' exist?: {phoneBook.ContainsKey("Sam")}");

        //        string contactName = "Sam";
        //        string phoneNumber = phoneBook.TryGetValue(contactName, out string num) ? num : "Not Found";
        //        Console.WriteLine($"Phone for {contactName}: {phoneNumber}");

        //        Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
        //        Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
        //        Console.WriteLine();
            
            #endregion

            #region Exercise 4
            
                Console.WriteLine("--- Exercise 4: Unique Email Validator ---");

                HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                emails.Add("ahmed@test.com");
                emails.Add("AHMED@test.com");
                emails.Add("sara@test.com");
                emails.Add("Sara@Test.Com");

                Console.WriteLine($"Stored Emails Count: {emails.Count}");
                Console.WriteLine("Explanation: The count is 2 because StringComparer.OrdinalIgnoreCase makes the collection " +
                                  "treat uppercase and lowercase letters as identical. Duplicate emails were rejected.");

                HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
                HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

                HashSet<int> unionSet = new HashSet<int>(setA);
                unionSet.UnionWith(setB);
                Console.WriteLine($"UnionWith: {{{string.Join(", ", unionSet)}}}");

                HashSet<int> intersectSet = new HashSet<int>(setA);
                intersectSet.IntersectWith(setB); 
                Console.WriteLine($"IntersectWith: {{{string.Join(", ", intersectSet)}}}");

                HashSet<int> exceptSet = new HashSet<int>(setA);
                exceptSet.ExceptWith(setB); 
                Console.WriteLine($"ExceptWith (Set A except Set B): {{{string.Join(", ", exceptSet)}}}");

                HashSet<int> subsetCheck = new HashSet<int> { 1, 2 };
                Console.WriteLine($"Is {{1,2}} a subset of Set A?: {subsetCheck.IsSubsetOf(setA)}");
                Console.WriteLine();
            
            #endregion

            #region Exercise 5
            
                Console.WriteLine("--- Exercise 5: Print Queue Simulator ---");

                Queue<string> printerQueue = new Queue<string>();
                printerQueue.Enqueue("Report.pdf");
                printerQueue.Enqueue("Invoice.pdf");
                printerQueue.Enqueue("Letter.docx");
                printerQueue.Enqueue("Resume.pdf");
                printerQueue.Enqueue("Photo.jpg");

                Console.WriteLine($"Queue contents: {string.Join(", ", printerQueue)}");
                Console.WriteLine($"Queue Count: {printerQueue.Count}");

                Console.WriteLine($"Next document to print (Peek): {printerQueue.Peek()}");

                while (printerQueue.Count > 0)
                {
                    string currentDoc = printerQueue.Dequeue();
                    Console.WriteLine($"Printing: {currentDoc}");
                }

                bool dequeueSuccess = printerQueue.TryDequeue(out string emptyResult);
                Console.WriteLine($"TryDequeue on empty queue succeeded?: {dequeueSuccess}");
                Console.WriteLine($"Result returned: {(emptyResult ?? "null")}");
                Console.WriteLine("Explanation: TryDequeue returns false instead of throwing an InvalidOperationException.");
                Console.WriteLine();
            
            #endregion

            #region Exercise 6
           
                Console.WriteLine("--- Exercise 6: Browser History (Undo) ---");

                Stack<string> browserHistory = new Stack<string>();

                browserHistory.Push("google.com");
                browserHistory.Push("github.com");
                browserHistory.Push("stackoverflow.com");
                browserHistory.Push("youtube.com");
                browserHistory.Push("claude.ai");

                Console.WriteLine($"Current top page (Peek): {browserHistory.Peek()}");

                for (int i = 0; i < 3; i++)
                {
                    string leftPage = browserHistory.Pop();
                    Console.WriteLine($"Left page: {leftPage}");
                }

                Console.WriteLine($"Current page after navigating back: {browserHistory.Peek()}");

                browserHistory.Pop();
                browserHistory.Pop();

                bool popSuccess = browserHistory.TryPop(out string emptyResult);
                Console.WriteLine($"TryPop on empty stack succeeded?: {popSuccess}");
                Console.WriteLine($"Result returned: {(emptyResult ?? "null")}");
                Console.WriteLine("Explanation: TryPop returns false safely rather than crashing the application with an exception.");
                Console.WriteLine();
            
            #endregion


        }
    }
}
