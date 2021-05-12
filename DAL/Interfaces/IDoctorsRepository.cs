using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDoctorsRepository
    {
        void AddDoctor(Doctor newDoctor);
        void DelDoctor(int delDoctorId);
        Doctor SeacrhByName(string doctorName);
        IEnumerable<Doctor> GetDoctorsByHospital(int hospitalId);

    }
}
