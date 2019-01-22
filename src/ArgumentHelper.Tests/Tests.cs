using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper.Tests
{
	[TestClass]
    public class Tests
    {
		[TestMethod]
        public void Test()
		{
			var args = new[] { "-i", "adfadsf" };

			var argumentHelper = new ArgumentHelper();

			//var config = argumentHelper.Configuration;
			//config.ProgramName = "file-sorter";
			//config.Description = "Sorts files into diretories.";
			//config.AddOption("-h", "--help").Description("Show help.");
			//config.AddOption("-i", "--input").Description("Input directory.").HasValue();
			//config.AddOption("-o", "--output").Description("Output directory.").HasValue();
			//config.AddOption("-r", "--recursive").Description("Find files recursively");

			argumentHelper.Configure()
				.ProgramName("file-sorter")
				.Description("Sorts files into diretories.")
				.Option("-h", "--help").Description("Show help.").Configure()
				.Option("-i", "--input").Description("Input directory.").HasValue().Configure()
				.Option("-o", "--output").Description("Output directory.").HasValue().Configure()
				.Option("-r", "--recursive").Description("Find files recursively");

			var arguments = argumentHelper.Parse(args);
			if (arguments.Options.ContainsKey("-h"))
			{
				argumentHelper.GetUsage();
			}

			arguments.Options.TryGetValue("-i", out string inputDirectory);
			arguments.Options.TryGetValue("-o", out string outputDirectory);
			var shouldRecurse = arguments.Options.ContainsKey("-r");
		}
    }
}
