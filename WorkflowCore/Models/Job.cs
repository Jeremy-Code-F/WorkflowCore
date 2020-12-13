using System;
using System.Linq;
using System.Xml.Linq;

namespace WorkflowCore.Models
{
    public class Job
    {
        public int id {get; set;}
        public JobStatus status {get; set;}
        public string TypeName {get; set;}
        public string MethodName {get; set;}

        public enum JobStatus: ushort{
            COMPLETE = 0,
            PENDING = 0,
            ERROR = 0
        }
    }
}