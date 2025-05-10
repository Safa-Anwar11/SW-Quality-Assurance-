using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest_Batch_6.Data
{
    public class GlobalConstant
    {
        public readonly static string loginLink = "https://localhost:44349/Auth/login";
        public readonly static string registerLink = "https://localhost:44349/Auth/RegisterUser";
        public readonly static string HerfaTestDataPath = "C:\\Users\\b.alhassoun.ext\\Documents\\HerfaTestData.xlsx";
        public readonly static string ConnectionString = "Data Source= localhost:1521/xe; User Id=C##QAFIRST; Password=Bayan123;";
        public readonly static string ImagesPath= "C:\\Users\\b.alhassoun.ext\\source\\repos\\HerfaTest-Batch 6\\HerfaTest-Batch 6\\Data\\Images";
        public readonly static string HTMLReportPath = "C:\\Users\\b.alhassoun.ext\\source\\repos\\HerfaTest-Batch 6\\HerfaTest-Batch 6\\Data\\HTMLReport\\";
    }
}
