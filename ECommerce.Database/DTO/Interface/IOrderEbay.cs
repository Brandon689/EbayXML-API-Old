using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database.DTO.Interface
{
    public interface IOrder<TID>
    {
        public TID OrderId { get; set; }
    }

    //public interface IHog<TKE>
    //{
    //    public TKE Ramona { get; set; }
    //}

    //public class EScream : IHog<string>
    //{
    //    public string Ramona { get; set; }
    //}
}
