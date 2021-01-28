using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Tebrikler! Kayıt Başarılı.");
            }else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kaydınız başarı ile silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kaydınız başarı ile güncellendi.");
        }
    }
}
