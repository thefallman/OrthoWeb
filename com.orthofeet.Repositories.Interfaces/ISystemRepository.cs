using System.Collections.Generic;
using System.Threading.Tasks;
using com.orthofeet.Entities.ofapi;

namespace com.orthofeet.Repositories.Interfaces
{
	public interface ISystemRepository
	{
		Task<ICollection<AppSetting>> GetAppSettings(string appName, string realm);
		Task<AppSetting> GetAppSettingsEntry(string appName, string realm, string name);
	}
}