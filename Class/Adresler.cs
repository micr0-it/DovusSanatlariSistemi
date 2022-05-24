using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Adresler
    {
        public List<Database.tbl_ds_adres> GetAdres(string binaadi)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_adres.Where(p => p.bina_ad.Contains(binaadi));
            return sonuc.ToList();
        }
        public List<Database.tbl_ds_adres> Listele()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var liste = entities.tbl_ds_adres.OrderBy(p => p.bina_ad).ToList();
            return liste;
        }
        public string AddAdres(Database.tbl_ds_adres adres)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            Database.tbl_ds_adres yeni = new Database.tbl_ds_adres();
            yeni = adres;
            entities.tbl_ds_adres.Add(yeni);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";

        }
        public string DeleteAdres(string binadi, Database.tbl_ds_adres adres)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_adres.Where(p => p.bina_ad == binadi).FirstOrDefault();
            entities.tbl_ds_adres.Remove(aranan);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public string UpdateAdres(string binadi, Database.tbl_ds_adres adres)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_adres.Where(p => p.bina_ad == binadi).ToList().FirstOrDefault();
            aranan = adres;
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public List<Database.tbl_ds_adres> Getir()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            return entities.tbl_ds_adres.ToList();
        }
    }
}
