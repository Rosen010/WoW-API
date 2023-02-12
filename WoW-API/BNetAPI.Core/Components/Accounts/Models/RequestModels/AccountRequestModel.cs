using BNetAPI.Core.Interfaces;

namespace BNetAPI.Core.Components.Accounts.Models.RequestModels
{
    public class AccountRequestModel : IBNetRequestModel
    {
        public string? NameSpace { get; set; }

        public string? Locale { get; set; }
    }
}
