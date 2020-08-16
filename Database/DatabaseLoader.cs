using MongoDB.Driver;

namespace Remmy.Database
{
    class DatabaseLoader
    {

        public DatabaseLoader()
        {
            DotNetEnv.Env.Load();
        }

        public IMongoDatabase Start()
        {
            DotNetEnv.Env.Load();

            var Client = new MongoClient(DotNetEnv.Env.GetString("MONGODB_URI"));
            var DB = Client.GetDatabase("remmy");

            return DB;
        }

    }
}
