using System.Collections.Generic;
using System.Threading.Tasks;
using com.orthofeet.ViewModels.OfApi;

namespace com.orthofeet.Services.Interfaces
{
	public interface IAppSettingsService
	{
		Task<ICollection<AppSettingsEntryVm>> GetAppSettings(string appName, string realm);
		Task<AppSettingsEntryVm> GetAppSettingsEntry(string appName, string realm, string name);
	}
}