using EksempelOldSchoolUdenDI.DAL;

namespace EksempelOldSchoolUdenDI.Domain
{
    public class DomainFacade
    {
        public IMedlemsDomain MedlemsDomain { get; set; }

        private DomainFacade(IMedlemsDomain MedlemsDAL)
        {
            this.MedlemsDomain = MedlemsDAL;
        }

        private static DomainFacade _facade;

        public static DomainFacade GetFacade()
        {
            if (_facade == null)
            {
                _facade = CreateNew();
            }

            return _facade;
        }

        private static DomainFacade CreateNew()
        {
            // Brug af "Facade" pattern
            var dalFacade = DALFacade.GetFacade();

            var medlemsDAL = new MedlemsDomain(dalFacade.MedlemsDAL);

            return new DomainFacade(medlemsDAL);
        }
    }
}
