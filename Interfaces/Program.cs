using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
	class Program {
		static void Main(string[] args) {

			IPrint printer = new Diagnostic();

			printer.Print("A single string to the console");

			IWrite writer = new Console();

		}
	}
}
