using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Menuler
    {
        public List<Database.tbl_ds_menu> Listele()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_menu.OrderBy(p => p.ds_menu_ad);
            return sonuc.ToList();
        }
        public List<Database.tbl_ds_menu> Getir()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            return entities.tbl_ds_menu.ToList();
        }
        public List<Database.tbl_ds_menu> GetByYetki(string yetki)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_menu.Where(p => p.ds_menu_yetki.Contains(yetki));
            return sonuc.ToList();
        }
    }
}
