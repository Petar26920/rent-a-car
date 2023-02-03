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
        public void DodajVozilo(VoziloBO voziloBo);

    }
}
