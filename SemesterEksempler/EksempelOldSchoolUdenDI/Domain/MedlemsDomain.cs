using EksempelOldSchoolUdenDI.DAL;
using EksempelOldSchoolUdenDI.DAL.Models;
using EksempelOldSchoolUdenDI.Domain.Models;
using System.Collections.Generic;

namespace EksempelOldSchoolUdenDI.Domain
{
    public class MedlemsDomain : IMedlemsDomain
    {
        private readonly IMedlemsDAL medlemsDAL;

        public MedlemsDomain(IMedlemsDAL medlemsDAL) {
            this.medlemsDAL = medlemsDAL;
        }

        public bool NytMedlem(NytMedlemDto medlem)
        {
            // TODO: Konvertér NytMedlemDto til NytMedlemDAL
            var medlemDAL = new NytMedlemDAL();

            return medlemsDAL.NytMedlem(medlemDAL);
        }

        public bool OpdaterMedlem(RedigeretMedlemDto medlem)
        {
            // TODO: Konvertér RedigeretMedlemDto til RedigeretMedlemDAL
            var medlemDAL = new RedigeretMedlemDAL();

            return medlemsDAL.OpdaterMedlem(medlemDAL);
        }

        public bool SletMedlem(int id)
        {
            return medlemsDAL.SletMedlem(id);
        }

        public List<MedlemDto> SøgMedlem(string navn)
        {
            var søgeresultatFraDAL = medlemsDAL.SøgMedlem(navn);

            // TODO: Konvertér søgeresultatFraDAL-liste fra MedlemDAL til MedlemDto, og kom i listen
            var result = new List<MedlemDto>();

            return result;
        }
    }
}
