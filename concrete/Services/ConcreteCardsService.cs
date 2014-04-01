using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using concrete.Models;
using concrete.DAL;


namespace concrete.Services
{
    public class ConcreteCardsService:IDisposable
    {
        
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<UserProfile> CscTestDataservice()
        {
            var Users = unitOfWork.UserProfileRepository.Get();
            return (Users.ToList());
        }

        public void addcylinder(cyl cylmodel)
        {
            cyl Cyldata = new cyl();
            Cyldata.labnumber = cylmodel.labnumber;
            Cyldata.setnumber = cylmodel.setnumber;
            unitOfWork.CyldataRepository.Insert(Cyldata);
            unitOfWork.Save();
        }

        public void addcondata( carddata cardmodel )
        {
            carddata Carddata = new carddata();
            Carddata.labnumber = cardmodel.labnumber;
            Carddata.setnumber = cardmodel.setnumber;
            unitOfWork.CarddataRepository.Insert(Carddata);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

    }
}