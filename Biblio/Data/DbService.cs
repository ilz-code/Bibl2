namespace Biblio.Data
{
    public class DbService
    {
        public readonly Bibl2DbContext context;

        public DbService(Bibl2DbContext Context)
        {
            context = Context;
        }
    }
}
