using BNetAPI.Core.Components.Guilds.Models.RequestModels;
using BNetAPI.Core.Components.Guilds.Models.ResponseModels;

namespace BNetAPI.Core.Components.Guilds
{
    public interface IBNetGuildClient
    {
        Task<GuildResponse> RequestGuildAsync(GuildRequestModel request);

        Task<RosterResponse> RequestRosterAsync(RosterRequestModel request);
    }
}
