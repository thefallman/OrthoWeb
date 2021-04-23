using AutoMapper;

namespace com.orthofeet.Mappings
{
	public class GlobalMapper
	{
		public static IMapper Mapper { get; private set; }
		public static void Startup()
		{
			var mappingConfig = new MapperConfiguration(
				mc =>
				{
					mc.AddProfile(new OfApiProfile());
				});
			Mapper = mappingConfig.CreateMapper();
		}
	}
}