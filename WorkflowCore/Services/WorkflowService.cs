using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using WorkflowCore.DAL;
using WorkflowCore.Models;

namespace WorkflowCore.Services
{
    public class WorkflowService
    {
        private WorkflowRepo _workflowRepo;
        public WorkflowService(WorkflowRepo workflowRepo){
            _workflowRepo = workflowRepo;
        }

        public void PrintSt(){
            Console.WriteLine("Hello");
        }

        public void RunWorkflow(){
            Workflow workflowToRun = _workflowRepo.GetExample();
            foreach(Task workflowTask in workflowToRun.Task){
                if(workflowTask.TaskType == "CoreExe"){
                    Type type = Type.GetType(workflowTask.TypeName);
                    var flags = BindingFlags.Public | BindingFlags.Static;
                    var method = type.GetMethod(workflowTask.MethodName, flags);
                    object[] inputParameters = new object[1];
                    inputParameters[0] = workflowTask.Params.Param[0].ParamValue;
                    method.Invoke(null, inputParameters);
                }
            }
        }


        public Workflow ReadWorkflowFromExample(){
            string input = File.ReadAllText("ExampleJob.xml");
            XmlSerializer ser = new XmlSerializer(typeof(Workflow));

            using (StringReader sr = new StringReader(input))
            {
                return (Workflow)ser.Deserialize(sr);
            }
        }
    }
}
