Dictionary<int, int> d = new();
for(int i = 1; i<9;i++)
{
    int n=int.Parse(Console.ReadLine());
    d[i] = n;
}
var ans = d.OrderByDescending(x => x.Value);
int sum = ans.Select(x => x.Value).ToArray()[..5].Sum();
Console.WriteLine($"{sum}\n{string.Join(" ", ans.Select(x => x.Key).ToArray()[..5].OrderBy(x=>x))}");
