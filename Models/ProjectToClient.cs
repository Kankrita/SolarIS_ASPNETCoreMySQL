using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace finalWS_2015233.Models

{
    public class ProjectToClient
    {
        [Key]
        public int Connection_Id { get; set;}

        public virtual Client Client { get; set;}

        public virtual SolarisPrj SolarisPrj { get; set;}
    }
}