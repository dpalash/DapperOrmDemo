using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using EFOrmDemo.DBEntities;

namespace EFOrmDemo.Repository
{
    public class DapperRepository
    {
        private readonly string _connectionString;
        public DapperRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EFOrmDemoConnection"].ConnectionString;
        }

        public List<User> GetAllUsers()
        {
            using (var db = new GymDbContext())
            {
                var ssFinds = db.Users.Find(1);
                var ssssss = db.Users.Find(1);
                var ss = db.Users.Find(1);//.Include(x => x.Stories).ToList();
                var sss = db.Users.Include(x => x.Stories).ToList();
                return sss;
            }
        }

        public List<Story> GetAllStories()
        {
            using (var db = new GymDbContext())
            {
                var ssFinds = db.Stories.Find(1);
                var ssssss = db.Stories.Find(1);
                var ss = db.Stories.Find(1);//.Include(x => x.Stories).ToList();
                var sss = db.Stories.Include(x => x.User).ToList();
                return sss;
            }
        }
    }
}
