
using EksempelNewSchool.Domain.Models;

namespace EksempelNewSchool.Domain
{
    public interface IMedlemsDomain
    {
        bool NytMedlem(NytMedlemDto medlem);
        bool OpdaterMedlem(RedigeretMedlemDto medlem);
        bool SletMedlem(int id);
        List<MedlemDto> SøgMedlem(string navn);
    }
}
