using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webProjeV2.Models
{
    public class FindBook
    {
        public static Kitap FindById(List<Kitap> liste, int id)
        {
            Kitap found = new Kitap();
            foreach (var item in liste)
            {
                if (item.KitapId == id)
                {
                    found = item;
                }
            }
            return found;
        }
    }
}
