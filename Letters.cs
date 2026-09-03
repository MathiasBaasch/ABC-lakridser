namespace ABCLakridser;

public class Letters
{
    Dictionary<char, int> bagDict  = new Dictionary<char, int>
    {
        { 'A', 2 },
        { 'B', 2 },
        { 'C', 4 },
        { 'D', 6 },
        { 'E', 4 },
        { 'F', 1 },
        { 'G', 1 },
        { 'H', 4 },
        { 'I', 1 },
        { 'J', 8 },
        { 'K', 7 },
        { 'L', 4 },
        { 'M', 3 },
        { 'N', 3 },
        { 'O', 1 },
        { 'P', 2 },
        { 'Q', 4 },
        { 'R', 1 },
        { 'S', 1 },
        { 'T', 1 },
        { 'U', 1 },
        { 'V', 1 },
        { 'W', 1 },
        { 'X', 3 },
        { 'Y', 3 },
        { 'Z', 2 },
        { 'æ', 1 },
        { 'ø', 1 },
        { 'å', 1 }
    };

    public Dictionary<char, int> CountLetter(string line)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in line)
        {
            if (!char.IsLetter(c))
            {
            }
            else
            {
                char e = char.ToUpper(c);
                if (dict.ContainsKey(e))
                {
                    dict[e]++;
                }
                else
                {
                    dict.Add(e, 1);
                }
            }
        }

        return dict;
    }

    public int TotalBags(Dictionary<char, int> totalDict)
    {
        int piecesInBag = 0;
        double total = 0;
        int total2 = 0;
        int bags = 0;
        
        foreach (var VARIABLE in totalDict)
        {
            if (bagDict.ContainsKey(VARIABLE.Key))
            {
                piecesInBag = bagDict[VARIABLE.Key];
            }
            total = VARIABLE.Value / piecesInBag;
            total = Math.Ceiling(total);
            total2 = (int)total;
            if (total2 > bags)
            {
                bags = total2;
            }
        }
        return bags;
    }
}