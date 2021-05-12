using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using DAL.ORM;

namespace DAL.Repositories
{
    public class DoctorsRepository : IDoctorsRepository
    {
        private DataManager dm = new DataManager();


        public void AddDoctor(Doctor newDoctor)
        {
            dm.Doctors.Add(newDoctor);
            dm.SaveChanges();
        }
        public void DelDoctor(int delDoctorId)
        {
            var delDoctor = dm.Doctors.Where(d => d.Id == delDoctorId).FirstOrDefault();
            if (delDoctor != null) dm.Doctors.Remove(delDoctor);
            dm.SaveChanges();
        }
        public IEnumerable<Doctor> GetDoctorsByHospital(int hospitalId)
        {
            return dm.Doctors.Where(d => d.HospitalId == hospitalId).ToList();
        }
        public Doctor SeacrhByName(string doctorName)
        {
            return dm.Doctors.Where(d => d.Name == doctorName).FirstOrDefault();
        }
    }
}
