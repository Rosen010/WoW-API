using BNetAPI.Characters.Models.RequestModels;
using BNetAPI.Characters.Models.ResponseModels;

namespace BNetAPI.Characters.Models.Interfaces
{
    public interface IBNetCharacterClient
    {
        Task<CharacterResponse> RequestCharacterAsync(CharacterRequestModel request);

        Task<CharacterMediaResponse> RequestCharacterMediaAsync(CharacterRequestModel request);
    }
}
