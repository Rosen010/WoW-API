﻿namespace BNetAPI.Core.Utilities.Constants
{
    public static class Endpoints
    {
        public const string BNetOauth = "https://{0}.battle.net/oauth/token";

        public const string UserAuthentication = "https://oauth.battle.net/authorize";

        public const string TokenAuthorization = "https://oauth.battle.net/token";

        public const string Guild = "https://{0}.api.blizzard.com/data/wow/guild/{1}/{2}";

        public const string Roster = "https://{0}.api.blizzard.com/data/wow/guild/{1}/{2}/roster";

        public const string Character = "https://{0}.api.blizzard.com/profile/wow/character/{1}/{2}";

        public const string CharacterMedia = "https://{0}.api.blizzard.com/profile/wow/character/{1}/{2}/character-media";

        public const string WoWProfile = "https://{0}.api.blizzard.com/profile/user/wow";
    }
}
