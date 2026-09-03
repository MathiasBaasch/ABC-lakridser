namespace ABCLakridser;

public class Letters
{
    Dictionary<char, int> bagDict = new Dictionary<char, int>
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
            if (char.IsLetter(c))
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
        int bags = 0;

        foreach (var letter in totalDict)
        {
            if (bagDict.ContainsKey(letter.Key))
            {
                int piecesInBag = bagDict[letter.Key];
                int bagsNeeded = (int)Math.Ceiling((double)letter.Value / piecesInBag);

                if (bagsNeeded > bags)
                {
                    bags = bagsNeeded;
                }
            }
        }

        return bags;
    }
}