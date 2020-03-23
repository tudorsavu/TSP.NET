using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreCodeFirst.POCO
{
    public partial class Order
    {
        protected Order() { }

        public Client Client;
    }
}
