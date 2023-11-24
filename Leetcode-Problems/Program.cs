using Leetcode_Problems;

var cls = new Longest_Common_Prefix();

dynamic[] inputs = new dynamic[]
{
    new string[] { "flower", "flow", "flight" }, // fl
    new string[] { "dog", "racecar", "car" }, //
    new string[] { "flower", "fkow" } // f
};

foreach (var input in inputs)
{
    Console.WriteLine($"{string.Join(",", input)} {cls.Run(input)}");
}
