using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "list":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();


            }
        }
    }
}
