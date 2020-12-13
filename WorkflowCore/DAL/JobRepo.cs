using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using Serilog;
using WorkflowCore.Models;

namespace WorkflowCore.DAL
{
    public class JobRepo
    {
        private PetaPoco.Database db;
        public JobRepo(string connStr){
            db = new PetaPoco.Database(connStr);
        }

        public List<Job> GetPendingJobs(){
            try{
                return db.Fetch<Job>("WHERE Status = @0", Job.JobStatus.PENDING);
            }catch(Exception ex){
                Log.Error(ex, $"Unexpected error trying to retreive pending workflow jobs Last SQL {db.LastSQL} Last Args {db.LastArgs}");
                throw;
            }
        }
    }
}