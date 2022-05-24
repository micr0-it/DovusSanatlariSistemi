using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Derece
    {
        public List<Database.tbl_ds_derece> GetDerslers(string derece)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var sonuc = entities.tbl_ds_derece.Where(p => p.ds_derece.Contains(derece));
            return sonuc.ToList();
        }
        public List<Database.tbl_ds_derece> Listele()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var liste = entities.tbl_ds_derece.OrderBy(p => p.ds_derece).ToList();
            return liste;
        }
        public string AddDers(Database.tbl_ds_derece ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            Database.tbl_ds_derece yeniders = new Database.tbl_ds_derece();
            yeniders = ders;
            entities.tbl_ds_derece.Add(yeniders);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";

        }
        public string DeleteDers(string dersadi, Database.tbl_ds_derece ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_derece.Where(p => p.ds_derece == dersadi).FirstOrDefault();
            entities.tbl_ds_derece.Remove(aranan);
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public string UpdateDers(string dersadi, Database.tbl_ds_derece ders)
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            var aranan = entities.tbl_ds_derece.Where(p => p.ds_derece == dersadi).ToList().FirstOrDefault();
            aranan = ders;
            var result = entities.SaveChanges();
            if (result == 1)
                return "1";
            else
                return "0";
        }
        public List<Database.tbl_ds_derece> Getir()
        {
            Database.DovusSanatlariEntities entities = new Database.DovusSanatlariEntities();
            return entities.tbl_ds_derece.ToList();
        }
    }
}

