using EksempelNewSchool.DAL.Models;

namespace EksempelNewSchool.DAL
{
    public interface IMedlemsDAL
    {
        bool NytMedlem(NytMedlemDAL medlem);
        bool OpdaterMedlem(RedigeretMedlemDAL medlem);
        bool SletMedlem(int id);
        List<MedlemDAL> SøgMedlem(string navn);
    }
}
