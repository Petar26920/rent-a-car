using pokusajNecega3.Models.BusinesObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.Interface
{
    interface IDokumentacijaRepository
    {
        public void Dodaj(DokuemntacijaBO dokumentacijaBO);

        public bool NadjiDokumentacijuPoID(int id);
    }
}
