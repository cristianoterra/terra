using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terra.services
{
    public interface ipersonservice
    {
        person create(person person);
        person Findybyid(long id);
        List<person> Findall();
        person upadate(person person);
        void delete(long id);
    }
}
