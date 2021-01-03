using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webProjeV2.Models
{
    public class FindUser
    {
        public static Kullanici FindById(List<Kullanici> liste, string id)
        {
            Kullanici found = new Kullanici();
            foreach (var item in liste)
            {
                if (item.Id.Equals(id))
                {
                    found = item;
                }
            }
            return found;
        }
    }
}
