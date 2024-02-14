using System.ComponentModel.DataAnnotations;

namespace Film_info.Models
{

    public class Film
    {
        
        private int Id { get; set; }
        private string Title { get; set; }
        private DateTime Release_date { get; set; }
        private bool Adult { get; set; }




    }
}
