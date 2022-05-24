using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class DersProgrami
    {
        public List<Database.tbl_ds_dersprog> GetDerslers(string derstarih, string kullanicstil)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_dersprog.Where(p => p.ds_dersprog_tarih.Contains(derstarih));
            return sonuc.ToList();
        }
        public List<Database.tbl_ds_dersprog> Listele()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var liste = entities.tbl_ds_dersprog.OrderBy(p => p.tbl_ds_dersler.ds_ders_adi).ToList();
            return liste;
        }
        public List<Database.tbl_ds_dersprog> Getir()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            return entities.tbl_ds_dersprog.ToList();
        }
        public string AddDers(Database.tbl_ds_dersprog dersprog)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            Database.tbl_ds_dersprog yeniprogram = new Database.tbl_ds_dersprog();
            yeniprogram = dersprog;
            entities.tbl_ds_dersprog.Add(yeniprogram);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";

        }
        public string DeleteDers(int id, Database.tbl_ds_dersprog derstarih)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_dersprog.Where(p => p.ds_dersprog_id == id).FirstOrDefault();
            entities.tbl_ds_dersprog.Remove(aranan);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public string UpdateDers(int id, Database.tbl_ds_dersprog ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_dersprog.Where(p => p.ds_dersprog_id == id).ToList().FirstOrDefault();
            aranan = ders;
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
    }
}
