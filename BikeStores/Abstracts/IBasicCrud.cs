using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStores.Abstracts
{
    interface IBasicCrud
    {
        List<dynamic> fetchAll();//Method to fetch all records
        int checkPrivilege(string username, string methodName);//to check whether user can fetch data
        object fetchOne(object searchParam);
        void insert(object rec);
        void update(object updateParam, object newrec);
        void delete(object deleteParam);
    }
}
