using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using WorkflowCore.DAL;
using WorkflowCore.Models;

namespace WorkflowCore.Services
{
    public class WorkflowEngineService
    {
        private JobRepo _jobRepo;
        public WorkflowEngineService(JobRepo jobRepo){
            _jobRepo = jobRepo;
        }

        public void StartWorkflowEngine(){

            // while(true){
            //     List<Job> jobsToProcess = FindJobsToProcess();

            //     foreach(Job job in jobsToProcess){
            //         this.StartFunction();
            //     }
            // }
            //???

            // Find pending task and start their next task
        }

        private List<Job> FindJobsToProcess(){
            List<Job> pendingJobList = this._jobRepo.GetPendingJobs();
            return pendingJobList;
        }

        private void StartFunction(string typeName, string methodName)
        {
            //var xdoc = XDocument.Load("data.xml");
            //string typeName = (string)xdoc.Root.Element("typeName");
            //string methodName = (string)xdoc.Root.Element("methodName");
            // object[] parameters =
            //     xdoc.Root.Element("params")
            //         .Elements("param")
            //         .Select(p => (object)(int)p.Element("value").Element("i4"))
            //         .ToArray();

            // Type type = Type.GetType(typeName);
            // var flags = BindingFlags.Static | BindingFlags.Public;
            // var method = type.GetMethod(methodName, flags);
            // method.Invoke(null, parameters);

        }

        // private void StartFunction()
        // {
        //     var xdoc = XDocument.Load("data.xml");
        //     string typeName = (string)xdoc.Root.Element("typeName");
        //     string methodName = (string)xdoc.Root.Element("methodName");
        //     object[] parameters =
        //         xdoc.Root.Element("params")
        //             .Elements("param")
        //             .Select(p => (object)(int)p.Element("value").Element("i4"))
        //             .ToArray();

        //     Type type = Type.GetType(typeName);
        //     var flags = BindingFlags.Static | BindingFlags.Public;
        //     var method = type.GetMethod(methodName, flags);
        //     method.Invoke(null, parameters);

        // }
    }
}
