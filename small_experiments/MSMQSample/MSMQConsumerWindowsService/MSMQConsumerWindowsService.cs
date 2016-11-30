using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MSMQConsumerWindowsService
{
    public partial class MSMQConsumerService : ServiceBase
    {
        private System.Timers.Timer timer;

        public MSMQConsumerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.timer = new System.Timers.Timer(30000D);  // 30000 milliseconds = 30 seconds
            this.timer.AutoReset = true;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.ProcessQueueMessages);
            this.timer.Start();
        }

        protected override void OnStop()
        {
            this.timer.Stop();
            this.timer = null;
        }

        private void ProcessQueueMessages(object sender, System.Timers.ElapsedEventArgs e)
        {
            MessageProcessor.StartProcessing();
        }

    }
}

