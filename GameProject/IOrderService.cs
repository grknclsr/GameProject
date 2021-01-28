using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        void Add(Order order);
        void Update(Order order);

        void Delete(Order order);
    }
}
