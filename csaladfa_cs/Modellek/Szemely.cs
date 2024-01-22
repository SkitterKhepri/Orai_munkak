namespace csaladfa_cs.Modellek
{
    public class Szemely
    {
        
        public int Id {  get; set; }
        public string? Nev{ get; set; }
        public DateTime? SzuletesiDatum { get; set; }
        public string? SzuletesiHely { get; set; }
        public int Anya { get; set; }
        public int Apa { get; set; }

    }
}
