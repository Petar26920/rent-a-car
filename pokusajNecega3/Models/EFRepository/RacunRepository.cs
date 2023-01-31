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
    }
}
