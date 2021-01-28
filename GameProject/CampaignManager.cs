using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void ApplyDiscount(Campaign campaign, Order order)
        {
            Console.WriteLine(campaign.Name + "  isimli kampanya " +order.Id + "  siparişinize uygulandı.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanyanız silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanyanız güncellendi.");
        }
    }
}
