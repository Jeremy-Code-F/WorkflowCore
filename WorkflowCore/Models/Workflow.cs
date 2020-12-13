using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace WorkflowCore.Models
{
	[XmlRoot(ElementName="param")]
	public class Param {
		[XmlElement(ElementName="paramType")]
		public string ParamType { get; set; }
		[XmlElement(ElementName="paramValue")]
		public string ParamValue { get; set; }
	}

	[XmlRoot(ElementName="params")]
	public class Params {
		[XmlElement(ElementName="param")]
		public List<Param> Param { get; set; }
	}

	[XmlRoot(ElementName="task")]
	public class Task {
		[XmlElement(ElementName="TaskId")]
		public string TaskId { get; set; }
		[XmlElement(ElementName="TaskType")]
		public string TaskType { get; set; }
		[XmlElement(ElementName="MethodName")]
		public string MethodName { get; set; }
		[XmlElement(ElementName="TypeName")]
		public string TypeName { get; set; }
		[XmlElement(ElementName="params")]
		public Params Params { get; set; }
		[XmlElement(ElementName="NextTaskID")]
		public string NextTaskID { get; set; }
	}

	[XmlRoot(ElementName="Workflow")]
	public class Workflow {
		[XmlElement(ElementName="WorkflowId")]
		public string WorkflowId { get; set; }
		[XmlElement(ElementName="task")]
		public List<Task> Task { get; set; }
	}

}
