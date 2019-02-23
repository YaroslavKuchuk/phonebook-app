
namespace Phonebook.AdonetLayer.Repositories
{
    public abstract class BaseRepository
    {
        protected string ConnectionString
        {
            get
            {
                return Properties.Settings.Default.PBConnectionString;
            }
        }
    }
}
