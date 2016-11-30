using ExceptionMSMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQConsumerWindowsService
{
    public class MessageProcessor
    {
        public static void StartProcessing()
        {
            List<string> messages = ExceptionMSMQ.ExceptionMSMQ.RetrieveMessages();
            foreach(string message in messages)
            {
                //write message in database
            }
        }
    }
}
