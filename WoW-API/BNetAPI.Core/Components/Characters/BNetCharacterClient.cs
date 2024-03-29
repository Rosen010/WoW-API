﻿using BNetAPI.Core.Components.Characters.Models.Interfaces;
using BNetAPI.Core.Components.Characters.Models.RequestModels;
using BNetAPI.Core.Components.Characters.Models.ResponseModels;
using BNetAPI.Core.Interfaces;
using BNetAPI.Core.Utilities.Constants;

namespace BNetAPI.Core.Components.Characters
{
    public class BNetCharacterClient : IBNetCharacterClient
    {
        private readonly IBNetRestClient _restClient;

        public BNetCharacterClient(IBNetRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<CharacterResponse> RequestCharacterAsync(CharacterRequestModel request)
        {
            var endpoint = string.Format(Endpoints.Character, request.Region, request.Realm, request.CharacterName);
            return await _restClient.GetFromBlizzardApiAsync<CharacterResponse>(endpoint, request);
        }

        public async Task<CharacterMediaResponse> RequestCharacterMediaAsync(CharacterRequestModel request)
        {
            var endpoint = string.Format(Endpoints.CharacterMedia, request.Region, request.Realm, request.CharacterName);
            return await _restClient.GetFromBlizzardApiAsync<CharacterMediaResponse>(endpoint, request);
        }
    }
}
