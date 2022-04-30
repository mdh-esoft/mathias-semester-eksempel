namespace EksempelOldSchoolUdenDI.DAL
{
    public class DALFacade
    {
        public IMedlemsDAL MedlemsDAL { get; set;}

        private DALFacade(IMedlemsDAL MedlemsDAL)
        {
            this.MedlemsDAL = MedlemsDAL;
        }

        private static DALFacade _facade;

        public static DALFacade GetFacade()
        {
            if(_facade == null)
            {
                _facade = CreateNew();
            }

            return _facade;
        }

        private static DALFacade CreateNew()
        {
            var settings = new DALSettings("dette-skal-være-en-connectionString");

            var medlemsDAL = new MedlemsDAL(settings);

            return new DALFacade(medlemsDAL);
        }
    }
}
