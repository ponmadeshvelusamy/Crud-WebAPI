using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CrudWebApiClassLibrary
{
    class SchoolRepostory
    {
        public class RegisterRepository
        {
            
            IConfiguration _configurestion;
            public RegisterRepository(IConfiguration configurestion)
            {
                _configurestion = configurestion;
                var connection = _configurestion.GetConnectionString("DbConnection");
      
            }
            public IEnumerable<SchoolEntity> Showall(SchoolEntity obj)
            {
                var SelectQuery= $"select * from SchoolDetails";
                connection.open();
                var result =connection.Query<SchoolEntity>()
                connection.close();
                return 


            }
        }
    }

}
