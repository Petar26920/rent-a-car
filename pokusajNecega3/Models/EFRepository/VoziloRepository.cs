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
                    voziloBo.Boja = vozilo.Boja;
                    voziloBo.Tezina = (int)vozilo.Tezina;
                    voziloBo.Zauzeto = vozilo.Zauzeto;
                    voziloBo.vozniPark = vozilo.VozniParkFk;
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

        internal object ListaVozila(string reg)
        {
            List<VoziloBO> listavozila = new List<VoziloBO>();
            foreach (Vozilo vozilo in baza.Vozilo.Where(t => t.RegistracioniBroj == reg))
            {
                VoziloBO voziloBo = new VoziloBO();
                voziloBo.RegistracioniBroj = vozilo.RegistracioniBroj;
                voziloBo.Model = vozilo.Model;
                voziloBo.Tip = vozilo.Tip;
                voziloBo.Boja = vozilo.Boja;
                voziloBo.Zauzeto = vozilo.Zauzeto;
                listavozila.Add(voziloBo);
            }
            return listavozila;
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

        public void AzurirajVozilo(VoziloBO voziloBo)
        {
            Vozilo vozilo = new Vozilo();
            foreach(Vozilo voz in baza.Vozilo.Where(t=>t.RegistracioniBroj == voziloBo.RegistracioniBroj))
            {
                voz.Boja = voziloBo.Boja;
                voz.Model = voziloBo.Model;
                voz.Tezina = voziloBo.Tezina;
                voz.Tip = voziloBo.Tip;
                voz.Zauzeto = voziloBo.Zauzeto;
                voz.VozniParkFk = voziloBo.vozniPark;
            }
            //vozilo.RegistracioniBroj = voziloBo.RegistracioniBroj;
            //vozilo.Tip = voziloBo.Tip;
            //vozilo.Model = voziloBo.Model;
            //vozilo.Boja = voziloBo.Boja;
            //vozilo.Tezina = voziloBo.Tezina;
            //vozilo.Zauzeto = voziloBo.Zauzeto;
            //vozilo.VozniParkFk = voziloBo.vozniPark;


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
        public IEnumerable<string> NadjiSveReg()
        {
            List<string> listaReg = new List<string>();
            string trenutna;
            foreach (Vozilo vozilo in baza.Vozilo)
            {
                trenutna = vozilo.RegistracioniBroj;
                if (!listaReg.Contains(trenutna))
                {
                    listaReg.Add(trenutna);
                }
            }

            return listaReg;
        }

        public IEnumerable<string> NadjiSveTipove()
        {
            List<string> listaTipova = new List<string>();
            string trenutna;
            foreach (Vozilo vozilo in baza.Vozilo)
            {
                trenutna = vozilo.Tip;
                if (!listaTipova.Contains(trenutna))
                {
                    listaTipova.Add(trenutna);
                }
            }

            return listaTipova;
        }


        public void KreirajVozilo(VoziloBO voziloBo)
        {
            Vozilo vozilo = new Vozilo();
            vozilo.RegistracioniBroj = voziloBo.RegistracioniBroj;
            vozilo.Model = voziloBo.Model;
            vozilo.Tip = voziloBo.Tip;
            vozilo.VozniParkFk = voziloBo.vozniPark;
            vozilo.Boja = voziloBo.Boja;
            vozilo.Zauzeto = voziloBo.Zauzeto;

            baza.Vozilo.Add(vozilo);

            baza.SaveChanges();
        }



        public void Brisi(string reg)
        {
            Vozilo vozilo = baza.Vozilo.Single(t => t.RegistracioniBroj == reg);
            baza.Vozilo.Remove(vozilo);

            baza.SaveChanges();
        }


        //ZA RADNIKA
        public IEnumerable<VoziloBO> NadjiSvaVozilaRadnik(string reg)
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

        

        public bool PostojiVoziloPoReg(string reg)
        {
            bool postoji = false;
            foreach (Vozilo vozilo in baza.Vozilo)
            {
                if (vozilo.RegistracioniBroj == reg)
                {
                    postoji = true;
                }
            }
            return postoji;
        }



        //KORISNIK

        internal object ListaVozilaRadnik(string reg)
        {
            List<VoziloBO> listavozilaradnik = new List<VoziloBO>();
            foreach (Vozilo vozilo in baza.Vozilo.Where(t => t.RegistracioniBroj == reg))
            {
                VoziloBO voziloBo = new VoziloBO();
                voziloBo.RegistracioniBroj = vozilo.RegistracioniBroj;
                voziloBo.Model = vozilo.Model;
                voziloBo.Tip = vozilo.Tip;
                voziloBo.Boja = vozilo.Boja;
                voziloBo.Zauzeto = vozilo.Zauzeto;
                listavozilaradnik.Add(voziloBo);
            }
            return listavozilaradnik;
        }
        public IEnumerable<VoziloBO> NadjiVoziloPoRegRadnik(string reg)
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




    }
}
