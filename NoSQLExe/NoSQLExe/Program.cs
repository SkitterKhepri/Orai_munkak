using NoSQL;
using System.Net.Http;

Database db = new Database("https://index.hu");
//Console.WriteLine(db.Get().JSON);
string json = "{}";
Console.WriteLine(db.Post(json).JSON);

AdatBazis ab = new AdatBazis();
Jarmu j = new Jarmu();
j.Rendszam = "ABC-001";
ab.Jarmuvek.Add(j);

System.Net.Http.Json.