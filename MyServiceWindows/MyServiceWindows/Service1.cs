using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceWindows
{
	public partial class Service1 : ServiceBase
	{
		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			Console.WriteLine("Hora: " + DateTime.Now.TimeOfDay);
			System.Threading.Thread.Sleep(5000);
		}

		protected override void OnStop()
		{

		}

		public void OnDebug()
		{
			do
			{
				this.OnStart(null);
			} while (true);
		}
	}
}
