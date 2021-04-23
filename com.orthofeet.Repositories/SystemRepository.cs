using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.orthofeet.Entities.ofapi;
using com.orthofeet.EntityFramework;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace com.orthofeet.Repositories
{
	public class SystemRepository: ISystemRepository
	{
		private readonly OfApiDbContext _context;
		public SystemRepository(OfApiDbContext context)
		{
			_context = context;
		}
		#region App Settings

		public async Task<ICollection<AppSetting>> GetAppSettings(string realm)
		{
			return await _context.AppSettings.Where(s => s.Realm == realm).ToListAsync();
		}


		public async Task<AppSetting> GetAppSettingsEntry(string realm, string name)
		{
			return await _context.AppSettings.FirstOrDefaultAsync(s => s.Realm == realm && s.Name == name);
		}

		#endregion App Settings

	}
}