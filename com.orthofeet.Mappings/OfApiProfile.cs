using AutoMapper;
using com.orthofeet.Entities.ofapi;
using com.orthofeet.ViewModels.OfApi;

namespace com.orthofeet.Mappings
{
	public class OfApiProfile: Profile
	{
		public OfApiProfile()
		{
			CreateMap<AppSetting, AppSettingsEntryVm>();
		}
	}
}