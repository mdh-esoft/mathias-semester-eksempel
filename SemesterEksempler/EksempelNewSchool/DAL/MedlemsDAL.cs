using EksempelNewSchool.DAL.Models;

namespace EksempelNewSchool.DAL
{
    public class MedlemsDAL : IMedlemsDAL
    {
        public MedlemsDAL(DALSettings settings)
        {
            Settings = settings;
        }

        public DALSettings Settings { get; }

        public bool NytMedlem(NytMedlemDAL medlem)
        {
            try
            {
                // TODO: Gem i databasen..

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool OpdaterMedlem(RedigeretMedlemDAL medlem)
        {
            try
            {
                // TODO: Gem i databasen..

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SletMedlem(int id)
        {
            try
            {
                // TODO: Gem i databasen..

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<MedlemDAL> SøgMedlem(string navn)
        {
            try
            {
                // TODO: Gem i databasen..
                var medlem = new MedlemDAL()
                {
                    ID = 1,
                    Navn = "Mathias Testersen",
                    Fødselsdag = new DateTime(2000, 1, 1)
                };

                var result = new List<MedlemDAL>();
                result.Add(medlem);

                return result;
            }
            catch (Exception)
            {
                return new List<MedlemDAL>();
            }
        }
    }
}
