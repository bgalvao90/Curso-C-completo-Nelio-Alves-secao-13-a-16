Dictionary<string, int> dictionary = new Dictionary<string, int>();

string sourcePathFile = Console.ReadLine();

try
{
    using StreamReader sr = File.OpenText(sourcePathFile);
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');
        string candidate = line[0];
        int votes = int.Parse(line[1]);
        dictionary.Add(candidate, votes);

        if (dictionary.ContainsKey(candidate))
        {
            dictionary[candidate] += votes;
        }
        else
        {
            dictionary[candidate] = votes;
        }
    }
    foreach (var item in dictionary)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
