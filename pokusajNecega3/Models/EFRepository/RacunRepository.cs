using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.EFRepository
{
    public class RacunRepository : IRacunRepository
    {
        ProjekatZaPPPKojiRadiContext baza = new ProjekatZaPPPKojiRadiContext();

        public void Brisi(int id)
        {
            Racun racun = baza.Racun.Single(t => t.RacunId == id);
            baza.Racun.Remove(racun);

            baza.SaveChanges();
        }

        public void KreirajRacun(RacunBO racunBo)
        {
            Racun racun = new Racun();
            racun.RacunId = racunBo.RacunId;
            racun.VoziloFk = racunBo.VoziloFk;
            racun.DokumentacijaFk = racunBo.DokumentacijaFk;
            racun.Cena = racunBo.Cena;
            racun.BrojDana = racunBo.BrojDana;
            racun.Datum = racunBo.Datum;

            baza.Racun.Add(racun);

            baza.SaveChanges();
        }

        public IEnumerable<RacunBO> NadjiRacunPoID(int id)
        {
            List<RacunBO> listaRacuna = new List<RacunBO>();
            foreach(Racun racun in baza.Racun.Where(t=>t.RacunId==id))
            {
                RacunBO racunBo = new RacunBO();
                racunBo.RacunId = racun.RacunId;
                racunBo.Datum = racun.Datum;
                racunBo.BrojDana = racun.BrojDana;
                racunBo.Cena = racun.Cena;
                listaRacuna.Add(racunBo);
            }
            return listaRacuna;
        }

        public IEnumerable<RacunBO> NadjiSveRacune()
        {
            List<RacunBO> listaRacuna = new List<RacunBO>();
            foreach(Racun racun in baza.Racun)
            {
                RacunBO racunBO = new RacunBO();
                racunBO.RacunId = racun.RacunId;
                racunBO.Datum = racun.Datum;
                racunBO.Cena = racun.Cena;
                racunBO.BrojDana = racun.BrojDana;
                racunBO.DokumentacijaFkNavigation = racun.DokumentacijaFkNavigation;

                listaRacuna.Add(racunBO);
            }

            return listaRacuna;
        }

        public IEnumerable<VoziloBO> NadjiSvaVozila()
        {
            List<VoziloBO> listaVozila = new List<VoziloBO>();

            foreach (Vozilo voziloModel in baza.Vozilo)
            {
                VoziloBO vozilo = new VoziloBO();
                vozilo.RegistracioniBroj = voziloModel.RegistracioniBroj;
                vozilo.Tip = voziloModel.Tip;
                vozilo.Zauzeto = voziloModel.Zauzeto;
                vozilo.Model = voziloModel.Model;
                vozilo.Boja = voziloModel.Boja;

                listaVozila.Add(vozilo);
            }

            return listaVozila;
        }

        public IEnumerable<DokuemntacijaBO> NadjiSvuDokumentaciju()
        {
            List<DokuemntacijaBO> listaDokum = new List<DokuemntacijaBO>();

            foreach (Dokumentacija dokumenModel in baza.Dokumentacija)
            {
                DokuemntacijaBO dokum = new DokuemntacijaBO();
                dokum.Idvozacke = dokumenModel.Idvozacke;
                dokum.Ime = dokumenModel.Ime;
                dokum.Prezime = dokumenModel.Prezime;
                dokum.DatumRodjenja = dokumenModel.DatumRodjenja;
                dokum.DatumIzdavanjaDozvole = dokumenModel.DatumIzdavanjaDozvole;

                listaDokum.Add(dokum);

            }

            return listaDokum;
        }

        public bool PostojiRacunPoID(int id)
        {
            bool postoji = false;
            foreach(Racun racun in baza.Racun)
            {
                if(racun.RacunId == id)
                {
                    postoji = true;
                }
            }
            return postoji;
        }
    }
}
