using BNetAPI.Core.Interfaces;

namespace BNetAPI.Guilds.Models.RequestModels
{
    public class GuildRequestModel : IBNetRequestModel
    {
        public string Region { get; set; }

        public string Realm { get; set; }

        public string GuildName { get; set; }

        public string NameSpace { get; set; }

        public string Locale { get; set; }
    }
}
