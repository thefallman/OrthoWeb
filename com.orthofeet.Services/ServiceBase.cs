using com.orthofeet.Services.Interfaces;
using NLog;

namespace com.orthofeet.Services
{
	public class ServiceBase
	{
		protected readonly ILogger Logger =  LogManager.GetCurrentClassLogger();
		protected readonly IAppSettingsService AppSettingsService;


		protected ServiceBase(IAppSettingsService appSettingsService )
		{
			AppSettingsService = appSettingsService;
		}
	}
}