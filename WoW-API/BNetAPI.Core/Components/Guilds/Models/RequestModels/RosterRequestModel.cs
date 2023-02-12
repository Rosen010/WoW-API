using BNetAPI.Core.Interfaces;

namespace BNetAPI.Core.Components.Guilds.Models.RequestModels
{
    public class RosterRequestModel : IBNetRequestModel
    {
        public string Region { get; set; }

        public string Realm { get; set; }

        public string GuildName { get; set; }

        public string NameSpace { get; set; }

        public string Locale { get; set; }
    }
}
