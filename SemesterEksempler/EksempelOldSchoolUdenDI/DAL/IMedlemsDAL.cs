using EksempelOldSchoolUdenDI.DAL.Models;
using System.Collections.Generic;

namespace EksempelOldSchoolUdenDI.DAL
{
    public interface IMedlemsDAL
    {
        bool NytMedlem(NytMedlemDAL medlem);
        bool OpdaterMedlem(RedigeretMedlemDAL medlem);
        bool SletMedlem(int id);
        List<MedlemDAL> SøgMedlem(string navn);
    }
}
