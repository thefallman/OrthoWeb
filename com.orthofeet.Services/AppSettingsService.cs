using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using com.orthofeet.Entities.ofapi;
using com.orthofeet.Repositories.Interfaces;
using com.orthofeet.Services.Interfaces;
using com.orthofeet.ViewModels.OfApi;

namespace com.orthofeet.Services
{
	public class AppSettingsService: IAppSettingsService
	{
		private readonly ISystemRepository _systemRepository;
		private readonly IMapper _mapper;
		public AppSettingsService(ISystemRepository systemRepository, IMapper mapper)
		{
			_systemRepository = systemRepository;
			_mapper = mapper;
		}

		public async Task<ICollection<AppSettingsEntryVm>> GetAppSettings(string appName, string realm)
		{
			var dbResult = await _systemRepository.GetAppSettings(appName, realm);
			return _mapper.Map<ICollection<AppSetting>, ICollection<AppSettingsEntryVm>>(dbResult);
		}

		public async Task<AppSettingsEntryVm> GetAppSettingsEntry(string appName, string realm, string name)
		{
			var dbResult = await _systemRepository.GetAppSettingsEntry(appName, realm, name);
			return _mapper.Map<AppSetting, AppSettingsEntryVm>(dbResult);
		}
	}
}