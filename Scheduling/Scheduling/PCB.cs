using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Scheduling
{
    public enum ProcessStateType {New, Ready, Run, Exit, Wait};
    internal class PCB
    {
        public string ProcessName { get; set; }
        public int ProcessPriority { get; set; }
        public ProcessStateType ProcessState { get; set; }

      
        
public override string ToString()
        {
            return $"{ProcessName},({ProcessPriority})";
        }

       
    }
}
