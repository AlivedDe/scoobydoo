Console.WriteLine("Hello, World!");
for (int i = 0; i < 100; i++)
{
    var scooby = i % 5 == 0;
    var doo = i % 7 == 0;
    string output = (scooby, doo) switch
    {
        (true, true) => "ScoobyDoo",
        (true, false) => "Scooby",
        (false, true) => "Doo",
        _ => ""
    };
    Console.WriteLine($"index: {i}, output: {output}");
}