using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        private readonly MernisServiceReference.KPSPublicSoapClient _client;
      
        public UserValidationManager(KPSPublicSoapClient client)
        {
            _client = client;
        }
        public bool Validate(Gamer gamer)
        {
            Task<TCKimlikNoDogrulaResponse> isValidated = _client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber),
                gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirthday.Year);
            return isValidated.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
