using System;
using System.IO;
using System.Xml.Serialization;
using WorkflowCore.Models;

namespace WorkflowCore.Services
{
    public class WorkflowService
    {
        public WorkflowService(){

        }

        public void PrintSt(){
            Console.WriteLine("Hello");
        }

        public void RunWorkflow(Workflow workflowToRun){
            foreach(Task workflowTask in workflowToRun.Task){
                if(workflowTask.TaskType == "CoreExe"){
                    Console.WriteLine("Executing CoreExe Task");
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
