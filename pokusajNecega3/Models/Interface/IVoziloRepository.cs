using pokusajNecega3.Models.BusinesObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.Interface
{
    interface IVoziloRepository
    {
        IEnumerable<VoziloBO> NadjiVoziloPoReg(string reg);
        IEnumerable<VoziloBO> NadjiSvaVozila();
        IEnumerable<VoziloBO> NadjiSvaVozilaTogTipa(string tip);

        IEnumerable<String> NadjiVozilaTogTipa();
        public IEnumerable<string> NadjiSveReg();
        public void KreirajVozilo(VoziloBO voziloBo);
        public void DodajVozilo(VoziloBO voziloBo);
        public void AzurirajVozilo(VoziloBO voziloBo);
        public bool PostojiVoziloPoReg(string reg);

        public void Brisi(string reg);
        //Radnik
        public IEnumerable<VoziloBO> NadjiVoziloPoRegRadnik(string reg);




    }
}
