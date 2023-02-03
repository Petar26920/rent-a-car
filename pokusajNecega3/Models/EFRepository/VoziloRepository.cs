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
        
        
        public IEnumerable<VoziloBO> NadjiVoziloPoReg(string reg)
        {
                List<VoziloBO> listaVozila = new List<VoziloBO>();
                foreach (Vozilo vozilo in baza.Vozilo.Where(t => t.RegistracioniBroj == reg))
                {
                    VoziloBO voziloBo = new VoziloBO();
                    voziloBo.RegistracioniBroj = vozilo.RegistracioniBroj;
                    voziloBo.Tip = vozilo.Tip;
                    voziloBo.Model = vozilo.Model;
                    voziloBo.Zauzeto = vozilo.Zauzeto;
                    listaVozila.Add(voziloBo);
                }
                return listaVozila; 
        }
        
        
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

        public void DodajVozilo(VoziloBO voziloBo)
        {
            Vozilo vozilo = new Vozilo();
            vozilo.RegistracioniBroj = voziloBo.RegistracioniBroj;
            vozilo.Tip = voziloBo.Tip;
            vozilo.Model = voziloBo.Model;
            vozilo.Boja = voziloBo.Boja;
            vozilo.Tezina = voziloBo.Tezina;
            vozilo.Zauzeto = voziloBo.Zauzeto;
            vozilo.VozniParkFk = voziloBo.vozniPark;

            baza.Vozilo.Add(vozilo);

            baza.SaveChanges();
        }

        public IEnumerable<string> NadjiVozilaTogTipa()
        {
            List<string> listaTipova = new List<string>();
            string trenutna;
            foreach(Vozilo vozilo in baza.Vozilo)
            {
                trenutna = vozilo.Tip;
                if(!listaTipova.Contains(trenutna))
                {
                    listaTipova.Add(trenutna);
                }
            }

            return listaTipova;
        }
    }
}
