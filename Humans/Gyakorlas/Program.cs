using ClassLibrary.Data;

String[] sorok = File.ReadAllLines(@"C:\Users\Diak\Downloads\Humans\\Humans.txt");


GyakContex _context = new GyakContex();

if (!_context.Human.Any())
{
    foreach (var s in sorok)
    {
        _context.Human.Add(new ClassLibrary.Models.Human(s));
    }
    _context.SaveChanges();
}

/*foreach (string s in sorok)
{
    Console.WriteLine(s);
}
*/