namespace ABCLakridser;

class Program
{
    static void Main(string[] args)
    {
        Letters letters = new Letters();

        Dictionary<char, int> totalDict = new Dictionary<char, int>();

        try
        {
            using (StreamReader r = new StreamReader("Text.txt"))
            {
                string line;

                while ((line = r.ReadLine()) != null)
                {
                    Dictionary<char, int> lineDict = letters.CountLetter(line);
                    foreach (var item in lineDict)
                    {
                        if (totalDict.ContainsKey(item.Key))
                        {
                            totalDict[item.Key] += item.Value;
                        }
                        else
                        {
                            totalDict.Add(item.Key, item.Value);
                        }
                    }
                }
            }
            
            foreach (var item in totalDict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.WriteLine($"Total number of bags needed to write the text: {letters.TotalBags(totalDict)}");
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}