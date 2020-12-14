using System;
using System.IO;
using System.Xml.Serialization;
using WorkflowCore.Models;

namespace WorkflowCore.DAL
{
    public class WorkflowRepo
    {
        public WorkflowRepo(){

        }

        public Workflow GetExample(){
            string input = File.ReadAllText("ExampleJob.xml");
            XmlSerializer ser = new XmlSerializer(typeof(Workflow));

            using (StringReader sr = new StringReader(input))
            {
                return (Workflow)ser.Deserialize(sr);
            }
        }

    }

}