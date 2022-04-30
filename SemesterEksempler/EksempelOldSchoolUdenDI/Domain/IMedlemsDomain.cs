
using EksempelOldSchoolUdenDI.Domain.Models;
using System.Collections.Generic;

namespace EksempelOldSchoolUdenDI.Domain
{
    public interface IMedlemsDomain
    {
        bool NytMedlem(NytMedlemDto medlem);
        bool OpdaterMedlem(RedigeretMedlemDto medlem);
        bool SletMedlem(int id);
        List<MedlemDto> SøgMedlem(string navn);
    }
}
