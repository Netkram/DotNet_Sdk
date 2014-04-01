using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using concrete.Models;

namespace concrete.DAL
{
    public class UnitOfWork:IDisposable
    {
    
        private  UsersContext context = new UsersContext();
        private GenericRepository<carddata> carddataRepository;
        private GenericRepository<cyl> cyldataRepository;
        private GenericRepository<UserProfile> userProfileRepository;

        public GenericRepository<cyl> CyldataRepository
        {
            get
            {

                if (this.cyldataRepository == null)
                {
                    this.cyldataRepository = new GenericRepository<cyl>(context);
                }
                return cyldataRepository;
            }
        }

        public GenericRepository<carddata> CarddataRepository
        {
            get
            {

                if (this.carddataRepository == null)
                {
                    this.carddataRepository = new GenericRepository<carddata>(context);
                }
                return carddataRepository;
            }
        }

        public GenericRepository<UserProfile> UserProfileRepository
        {
            get
            {

                if (this.userProfileRepository == null)
                {
                    this.userProfileRepository = new GenericRepository<UserProfile>(context);
                }
                return userProfileRepository;
            }
        }

        
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


    }