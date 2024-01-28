using ConcertBooking.Entities;
using ConcertBooking.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Interfaces
{
    public interface IDepartmentRepo :  IGenericRepo<Department>
    {
        //Task<IEnumerable<Department>> GetAll();
        //Department GetById(int id);
        //Task SaveDepartment(Department department);
        //void UpdateDepartment(Department department);
        //void DeleteDepartment(int id);

        Task<IEnumerable<Department>> Search(string name);

    }
}


//Step-1  Text Elements
//Step-2  Text Elements
//Step-3  async Image Tag
//Step-4  Text Element 