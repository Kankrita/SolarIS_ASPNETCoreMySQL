using System.ComponentModel.DataAnnotations;

namespace finalWS_2015233.Models
{
    public class Client
    {
        [Key]
        public int Client_Id { get; set; }

        public string First_name { get; set; }

        public string Last_name { get; set; }

        public string City { get; set; }

        public string Phone_number { get; set; }
    }
}