using System;
using System.ComponentModel.DataAnnotations;

namespace finalWS_2015233.Models
{
    public class SolarisPrj
    {
        [Key]
        public int Project_Id { get; set; }

        public string Project_Title { get; set; }

        public double Cost { get; set; }

        public DateTime Due_date { get; set; }

    }
}