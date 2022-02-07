using BNetAPI.Guilds.Models.RequestModels;
using BNetAPI.Guilds.Models.ResponseModels;
using System.Threading.Tasks;

namespace BNetAPI.Guilds.Interfaces
{
    public interface IBNetGuildClient
    {
        Task<GuildResponse> RequestGuild(GuildRequestModel request);

        Task<RosterResponse> RequestRoster(RosterRequestModel request);
    }
}
