using DapperOrmDemo.DBEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Transactions;
using Dapper;
using TxF;
using TXFileManager;

namespace DapperOrmDemo.Repository
{
    public class DapperRepository
    {
        private readonly string _connectionString;
        public DapperRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DapperOrmDemoConnection"].ConnectionString;
        }

        public List<Authors> GetAllAuthors()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Authors>("Select * From Authors").ToList();
            }
        }

        public void BulkInsertInAuthorsTable(List<Authors> authorList)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    string processQuery = "INSERT INTO Authors VALUES (@FirstName, @LastName, @Age, @Comment, @Comment1, @Comment2, @Comment3, @Comment4, @Comment5, @Comment6, @Comment7, @Comment8, @Comment9, @Comment10, @Comment11, @Comment12, @Comment13, @Comment14, @Comment15)";

                    db.ExecuteAsync(processQuery, authorList).Wait();

                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {

            }
        }

        public void BulkInsertInAuthorsTableWithSp(DataTable authorDataTable)
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                var authorsDataTable = new
                {
                    authors = authorDataTable.AsTableValuedParameter("AuthorDataTable")
                };

                int recordsAffected = cnn.Execute("dbo.spAuthors_BulkInsert", authorsDataTable, commandType: CommandType.StoredProcedure);
            }
        }

        public void BulkInsertInUsersTableWithSp(DataTable authorDataTable)
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                var usersDataTable = new
                {
                    users = authorDataTable.AsTableValuedParameter("UsersDataTable")
                };

                int recordsAffected = cnn.Execute("dbo.spUsers_BulkInsert", usersDataTable, commandType: CommandType.StoredProcedure);
            }
        }

        public Tuple<List<Authors>, List<Users>> GetDataFrom2TablesWithSingleQuery()
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                string sql = @"select * from dbo.Authors;
                               select * from dbo.Users;";
                List<Authors> authors = null;
                List<Users> users = null;

                using (var lists = cnn.QueryMultiple(sql))
                {
                    authors = lists.Read<Authors>().ToList();
                    users = lists.Read<Users>().ToList();
                }

                return new Tuple<List<Authors>, List<Users>>(authors, users);
            }
        }
    }
}
