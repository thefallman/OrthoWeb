using System.Threading.Tasks;

namespace com.orthofeet.Services.Interfaces
{
	public interface IShipStationService
	{
		Task GetOrder(string url);
	}
}