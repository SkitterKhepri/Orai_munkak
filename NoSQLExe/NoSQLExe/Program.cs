using NoSQL;
using System.Net.Http;

Database db = new Database("https://index.hu");
//Console.WriteLine(db.Get().JSON);
string json = "{}";
Console.WriteLine(db.Post(json).JSON);

AdatBazis ab = new AdatBazis();
ab.Jarmuvek = new List<Jarmu>();
Jarmu j = new Jarmu();
j.Rendszam = "ABC-001";
ab.Jarmuvek.Add(j);

Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(ab));
