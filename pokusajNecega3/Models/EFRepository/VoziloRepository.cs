using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.EFRepository
{
    public class VoziloRepository : IVoziloRepository
    {
        private ProjekatZaPPPKojiRadiContext baza = new ProjekatZaPPPKojiRadiContext();
        public IEnumerable<VoziloBO> NadjiSvaVozila()
        {
            List<VoziloBO> listaVozila = new List<VoziloBO>();

            foreach(Vozilo voziloModel in baza.Vozilo)
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

        public IEnumerable<VoziloBO> NadjiSvaVozilaTogTipa(string tip)
        {
            List<VoziloBO> listaVozila = new List<VoziloBO>();
            foreach(Vozilo voz in baza.Vozilo.Where(t => t.Tip == tip).ToList())
            {
                VoziloBO voziloBO = new VoziloBO();
                voziloBO.RegistracioniBroj = voz.RegistracioniBroj;
                voziloBO.Tip = voz.Tip;
                voziloBO.Zauzeto = voz.Zauzeto;
                voziloBO.Model = voz.Model;
                voziloBO.Boja = voz.Boja;

                listaVozila.Add(voziloBO);
            }

            return listaVozila;
        }
    }
}
