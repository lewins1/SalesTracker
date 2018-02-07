using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SalesTracker
{
    class InitializeDataFileXml
    {
        #region Methods

        private static Salesperson InitializeSalesperson()
        {
            Salesperson salesperson = new Salesperson()
            {
                FirstName = "Bonzo",
                LastName = "Regan",
                AccountID = "banana103",
                CurrentStock = new Product(ProductType.Furry, 20, false),
                CitiesVisited = new List<string>()
                {
                    "Detriot",
                    "Grand Rapids",
                    "Ann Arbor"
                }
            };
            return salesperson;
        }
        public static void SeedDataFile()
        {
            XmlServices xmlService = new XmlServices(DataSettings.dataFilePathXml);

            xmlService.WriteSalespersonToDataFile(InitializeSalesperson());
        }
        #endregion
    }
}
