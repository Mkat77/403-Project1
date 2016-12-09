using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1.Models;
using System.Data.Entity;


namespace Project1.DAL
{
    public class MissionarySiteContext : DbContext
    {
        public MissionarySiteContext() : base("MissionarySiteContext")
        {


         

        }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<MissionQuestions> MissionQuestion { get; set; }

        public DbSet<Users> Userss { get; set; }
    }
}