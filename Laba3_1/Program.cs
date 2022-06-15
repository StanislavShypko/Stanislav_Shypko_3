var list = Enumerable.Range(1, 20);
SpiralPrint(list, 4);

void SpiralPrint(IEnumerable<int> elements, int n)
{
    var chunks = elements.Chunk(n);
    var reversed = false;
    foreach (var chunk in chunks)
    {
        foreach (var number in !reversed ? chunk : chunk.Reverse())
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
        reversed = !reversed;
    }
}