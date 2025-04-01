

string sourcePathFile = Console.ReadLine();

try
{
    using StreamReader sr = File.OpenText(sourcePathFile);
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');
        string candidate = line[0];
        int votes = int.Parse(line[1]);

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
catch(IOException e)
{
    Console.WriteLine("An error occurred "+ e.Message);
}
