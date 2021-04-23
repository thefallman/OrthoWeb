using System.ComponentModel.DataAnnotations.Schema;

namespace com.orthofeet.Entities.ofapi
{
	public class AppSetting
	{
		public int Id { get; set; }
		public string AppName { get; set; }
		public string Realm { get; set; }
		public string Name { get; set; }
		public string Value { get; set; }
		public string LongValue { get; set; }
	}
}