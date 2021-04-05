namespace ServerHandling.Database
{
    public class Book
    {
        public string name { get; }
        public string authorName { get; }
        public string typeName { get; }
        public int year { get; }

        public string describe { get; }

        public string filePath { get; }

        public Book(string name, string authorName, string typeName, int year, string describe, string filePath)
        {
            this.name = name;
            this.authorName = authorName;
            this.typeName = typeName;
            this.year = year;
            this.describe = describe;
            this.filePath = filePath;
        }
    }
}
