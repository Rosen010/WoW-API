using BNetAPI.Guilds.Models.RequestModels;
using BNetAPI.Guilds.Models.ResponseModels;
using System.Threading.Tasks;

namespace BNetAPI.Guilds.Interfaces
{
    public interface IBNetGuildClient
    {
        Task<GuildResponse> RequestGuildAsync(GuildRequestModel request);

        Task<RosterResponse> RequestRosterAsync(RosterRequestModel request);
    }
}
