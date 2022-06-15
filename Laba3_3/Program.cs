var hymn = new List<string>
{
    "Ще не вмерла України, нi слава, нi воля",
    "Ще нам, браття молодiї, усмiхнеться доля!",
    "Згинуть нашi ворiженьки, як роса на сонцi,",
    "Запануєм i ми, браття, у своїй сторонцi!",
    "Душу й тiло ми положим за нашу свободу",
    "I — покажем, що ми, браття, козацького роду!",
    "Душу й тiло ми положим за нашу свободу",
    "I — покажем, що ми, браття, козацького роду!",  
};

foreach (var ch in GetFirstCharsReversed(hymn))
{
    Console.WriteLine(ch);
}

List<char> GetFirstCharsReversed(List<string> lines)
{
    return lines.Select(line => line[0]).Reverse().ToList();
}