using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    //Do i need this here? What is the deal with the SQL code? Look this up if there is a problem
    [Table("Mission")]
    public class Mission
    {
    [Key]
    public int MissionID { get; set; }
    public String MissionName { get; set; }
    public String PresidentName { get; set; }
    public String Address { get; set; }
    public String Language { get; set; }
    public String Climate { get; set; }
    public String Religion { get; set; }
    public String Flag { get; set; }
    
    }
}