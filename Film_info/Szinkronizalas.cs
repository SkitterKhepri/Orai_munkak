﻿using RestSharp;

class Szinkronizalas
{

    public Szinkronizalas() {

        Frissit();


    }

    async private void Frissit()
    {
        var options = new RestClientOptions("https://api.themoviedb.org/3/search/movie?query=interstellar&include_adult=false&language=en-US&page=1");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwNGIwNTJkZTA4NWU4NzM1YjQ0OWQ2ZGJmYTU1ODcwYSIsInN1YiI6IjY1MWFkYjlmOTNiZDY5MDBmZTRhMTU1YSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.1C6EkNpjVDI-OfI6AnNDL3G9U4upzwXvCN9p4s40Pkc");
        var response = await client.GetAsync(request);

        //Console.WriteLine("{0}", response.Content);

        Console.WriteLine();
    }

}