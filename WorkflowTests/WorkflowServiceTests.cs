using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkflowCore.Models;
using WorkflowCore.Services;

namespace WorkflowTests
{
    [TestClass]
    public class WorkflowServiceTests
    {
        [TestMethod]
        public void TestRunWorkflow()
        {
            List<Task> taskList = new List<Task>();
            Task taskOne = new Task();
            taskOne.TaskId = "0";
            taskOne.TaskType = "CoreExe";
            taskOne.MethodName = "PrintStatement";
            taskOne.TypeName = "WorkflowCore.DefaultLibs";
            taskOne.Params = new Params();
            taskOne.Params.Param = new List<Param>();
            Param paramOne = new Param();
            paramOne.ParamType = "String";
            paramOne.ParamValue = "First Message";
            taskOne.Params.Param.Add(paramOne);
            taskOne.NextTaskID = "1";

            Task taskTwo = new Task();
            taskTwo.TaskId = "0";
            taskTwo.TaskType = "CoreExe";
            taskTwo.MethodName = "PrintStatement";
            taskTwo.TypeName = "WorkflowCore.DefaultLibs";
            taskTwo.Params = new Params();
            taskTwo.Params.Param = new List<Param>();
            Param paramTwo = new Param();
            paramTwo.ParamType = "String";
            paramTwo.ParamValue = "First Message";
            taskTwo.Params.Param.Add(paramTwo);
            taskTwo.NextTaskID = "1";

            taskList.Add(taskOne);
            taskList.Add(taskTwo);

            Workflow testWorkflow = new Workflow();
            testWorkflow.Task =taskList;
            WorkflowService workflowService = new WorkflowService();

            workflowService.RunWorkflow(testWorkflow);
        }
    }
}
