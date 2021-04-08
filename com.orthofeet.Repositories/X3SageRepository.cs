using com.orthofeet.EntityFramework;

namespace com.orthofeet.Repositories
{
    public abstract class X3SageRepository
    {
        protected readonly X3SageDbContext Context;
        public X3SageRepository(X3SageDbContext context)
        {
            Context = context;
        }
    }
}