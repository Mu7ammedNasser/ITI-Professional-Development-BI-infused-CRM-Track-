using LINQtoObject;

namespace lab02_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 03

            #region 1-Display book title and its ISBN.
            var q1 = SampleData.Books.Select(x => new { BookTitle = x.Title, ISBN = x.Isbn });
            #endregion
            #region 2-	Display the first 3 books with price more than 25.
            var q2 = SampleData.Books.Where(b => b.Price > 25).Take(3);
            #endregion

            #region 3-	Display Book title along with its publisher name.
            var q3 = SampleData.Books.Select(b => new { Title = b.Title, publisherName = b.Publisher.Name });
            #endregion

            #region 4-	Find the number of books which cost more than 20.
            var q4 = SampleData.Books.Where(b => b.Price > 20).Count();
            #endregion

            #region 5-	Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            var q5 = SampleData.Books.Select(b => new { Title = b.Title, Price = b.Price, SubjectName = b.Subject.Name })
                                      .OrderBy(b => b.SubjectName)
                                      .ThenByDescending(b => b.Price);
            #endregion
            #region 6-  Display all subjects with books related to this subject. (Using 2 methods).
            #region method_1
            var q6_1 = SampleData.Books.GroupBy(b => b.Subject.Name)
                                       .Select(g => new
                                       {
                                           subName = g.Key,
                                           Books = g.Select(b => b.Title)
                                       });
            #endregion


            #region 7-Display books grouped by publisher & Subject.
            var q7 = SampleData.Books.GroupBy(b =>
            new
            {
                subName = b.Subject.Name,
                pubName = b.Publisher.Name,
            }).Select(g=> new 
            {
                Subject = g.Key.subName,
                Publisher = g.Key.pubName,
                Books = g.Select(b => b.Title)
            });

            #endregion
            #endregion
            foreach (var item in q7)
            {
                Console.WriteLine(item.Subject);
                Console.WriteLine(item.Publisher);
                foreach (var book in item.Books)
                {
                    Console.WriteLine($"  {book}");
                }

            }

            //Console.WriteLine(q4);
            #endregion
        }
    }
}
