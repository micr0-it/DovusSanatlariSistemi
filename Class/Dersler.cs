using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Dersler
    {
        public List<Database.tbl_ds_dersler> GetDerslers(string dersadi, string kullanicstil) 
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_dersler.Where(p => p.ds_ders_adi.Contains(dersadi));
            return sonuc.ToList();
        }
        public List<Database.tbl_ds_dersler> Listele()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var liste = entities.tbl_ds_dersler.OrderBy(p => p.ds_ders_adi).ToList();
            return liste;
        }
        public string AddDers(Database.tbl_ds_dersler ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            Database.tbl_ds_dersler yeniders = new Database.tbl_ds_dersler();
            yeniders = ders;
            entities.tbl_ds_dersler.Add(yeniders);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";

        }
        public string DeleteDers(string dersadi, Database.tbl_ds_dersler ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_dersler.Where(p => p.ds_ders_adi == dersadi).FirstOrDefault();
            entities.tbl_ds_dersler.Remove(aranan);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public string UpdateDers(string dersadi, Database.tbl_ds_dersler ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_dersler.Where(p => p.ds_ders_adi == dersadi).ToList().FirstOrDefault();
            aranan = ders;
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public List<Database.tbl_ds_dersler> Getir()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            return entities.tbl_ds_dersler.ToList();
        }
    }
}
