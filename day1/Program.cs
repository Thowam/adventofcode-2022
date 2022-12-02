
var lines = File.ReadAllLines("input.txt");

IEnumerable<int> ElfTotals(string[] lines){
    var sum = 0;
    foreach(var line in lines)
    {
        if(string.IsNullOrWhiteSpace(line))
        {
            yield return sum;
            sum = 0;
            continue;
        }
        sum += Int32.Parse(line);
    }
    yield return sum;
    yield break;
}

var max = ElfTotals(lines).Max();
var top3 = ElfTotals(lines)
    .OrderByDescending(o => o)
    .Take(3)
    .Sum();

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Top 3 Sum: {top3}");