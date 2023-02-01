using pokusajNecega3.Models.BusinesObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.Interface
{
    interface IRacunRepository
    {
        /*Dodato zato sto mi trebaju id vozila*/
        IEnumerable<VoziloBO> NadjiSvaVozila();
        IEnumerable<DokuemntacijaBO> NadjiSvuDokumentaciju();
        IEnumerable<RacunBO> NadjiSveRacune();
        IEnumerable<RacunBO> NadjiRacunPoID(int id);

        public void KreirajRacun(RacunBO racunBo);

        public void Brisi(int id);
    }
}
