﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetTopMostWindow
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Thread.Sleep(500);
				ProcessHelper.PrintProcessInformation();

			}
		}	
	}
}
