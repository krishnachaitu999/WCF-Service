using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _21_WCFAssignment_1DOTNET_Task1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService
    {
        public string SayHello(string Name)
        {
            string Message = "";
            if (DateTime.Now.Hour <= 12)
                Message = string.Format("Good Morning " + Name);
            if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 17)
                Message = string.Format("Good Afternoon " + Name);
            if (DateTime.Now.Hour > 17 && DateTime.Now.Hour <= 24)
                Message = string.Format("Good Evening " + Name);
            return Message;
        }
        public string TodayProgram(string Name)
        {
            string Message = "";
            if ((DateTime.Now.DayOfWeek == DayOfWeek.Saturday) || (DateTime.Now.DayOfWeek == DayOfWeek.Sunday))
                Message = string.Format("Happy weekend ", Name);
            else
                Message = string.Format("Enjoy Working day ", Name);
            return Message;
        }
     
      
    }
}
