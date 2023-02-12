using BNetAPI.Core.Components.Characters.Models.RequestModels;
using BNetAPI.Core.Components.Characters.Models.ResponseModels;

namespace BNetAPI.Core.Components.Characters.Models.Interfaces
{
    public interface IBNetCharacterClient
    {
        Task<CharacterResponse> RequestCharacterAsync(CharacterRequestModel request);

        Task<CharacterMediaResponse> RequestCharacterMediaAsync(CharacterRequestModel request);
    }
}
