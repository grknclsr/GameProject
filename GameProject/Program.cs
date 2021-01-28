using MernisServiceReference;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager(new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap)));
            gamerManager.Add(new Gamer { DateOfBirthday = new DateTime(2000,2,16), FirstName = "GÜRKAN", LastName = "ÇALIŞIR", Id = 01, IdentityNumber = 21262074936 });

            Order order1 = new Order()
            {
                Id = 3, OrderPrice=75, GameName="RDR2"
            };

            Order order2 = new Order()
            {
                Id = 5,
                OrderPrice = 35,
                GameName = "LoL"
            };

            Order order3 = new Order()
            {
                Id = 8,
                OrderPrice = 28,
                GameName = "Wolfteam"
            };
            Campaign campaign1 = new Campaign()
            {
                Id = 1, DiscountRate = 15, Name="Hoşgeldin Kampanyası"
            };
            Campaign campaign2 = new Campaign()
            {
                Id = 2,
                DiscountRate = 3,
                Name = "Güle güle Kampanyası"
            };

            OrderManager orderManager = new OrderManager();
            orderManager.Add(order1);
            orderManager.Delete(order2);
            orderManager.Update(order3);
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.ApplyDiscount(campaign2,order3);
            campaignManager.Delete(campaign2);

            Console.ReadLine();

        }
    }
}
