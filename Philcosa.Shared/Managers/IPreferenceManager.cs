using Philcosa.Shared.Settings;
using System.Threading.Tasks;

namespace Philcosa.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();
    }
}
