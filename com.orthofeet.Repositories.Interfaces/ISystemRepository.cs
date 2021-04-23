using System.Collections.Generic;
using System.Threading.Tasks;
using com.orthofeet.Entities.ofapi;

namespace com.orthofeet.Repositories.Interfaces
{
	public interface ISystemRepository
	{
		Task<ICollection<AppSetting>> GetAppSettings(string realm);
		Task<AppSetting> GetAppSettingsEntry(string realm, string name);
	}
}