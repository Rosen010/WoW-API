using BNetAPI.Core.Interfaces;

namespace BNetAPI.Characters.Models.RequestModels
{
    public class CharacterRequestModel : IBNetRequestModel
    {
        public string Region { get; set; }

        public string Realm { get; set; }

        public string CharacterName { get; set; }

        public string NameSpace { get; set; }

        public string Locale { get; set; }
    }
}
