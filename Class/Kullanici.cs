using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Kullanici
    {
        public Database.tbl_ds_kullanici GetByKullanici(string mail, string sifre, string yetki)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_kullanici.Where(p => p.ds_kullanici_posta == mail && p.ds_kullanici_sifre == sifre && p.ds_kullanici_stili == yetki);
            if (sonuc != null)
                return sonuc.FirstOrDefault();
            else
                return null;
        }
        public List<Database.tbl_ds_kullanici> GetKullanicis(string Ad)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_kullanici.Where(p => p.ds_kullanici_ad.Contains(Ad) && p.ds_kullanici_posta != "@mu.edu.tr");
            return sonuc.ToList();
        }
        public List<Database.tbl_ds_kullanici> Getir()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            return entities.tbl_ds_kullanici.ToList();
        }
        public List<Database.tbl_ds_kullanici> Getir2(int dersid)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc= entities.tbl_ds_kullanici.Where(p => p.ds_kullanici_dersfkid== dersid);
            return sonuc.ToList();
        }
        public string AddKullanici(Database.tbl_ds_kullanici kullanici) 
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            Database.tbl_ds_kullanici kullanici1 = new Database.tbl_ds_kullanici();
            kullanici1 = kullanici;
            entities.tbl_ds_kullanici.Add(kullanici1);
            var sonuc = entities.SaveChanges();
            if (sonuc == 1)
                return "1";
            else
                return "0";

        }
        public string UpdateKullanici(string kullaniciad, Database.tbl_ds_kullanici kullanici)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_kullanici.Where(p => p.ds_kullanici_ad == kullaniciad).ToList().FirstOrDefault();
            aranan = kullanici;
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public string DeleteKullanici(string kullaniciad, Database.tbl_ds_kullanici kullanici)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan  = entities.tbl_ds_kullanici.Where(p => p.ds_kullanici_ad == kullaniciad).FirstOrDefault();
            var result1 = entities.tbl_ds_kullanici.Remove(aranan);
            var result2 = entities.SaveChanges();
            if (result2 == 1)
                return "1";
            else
                return "0";
        }
        public List<Database.tbl_ds_kullanici> Listele() 
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var liste = entities.tbl_ds_kullanici.OrderBy(p => p.ds_kullanici_ad).ToList();
            return liste;
        }
    }
}
