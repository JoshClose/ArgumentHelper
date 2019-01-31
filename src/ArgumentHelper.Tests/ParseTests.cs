using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper.Tests
{
	[TestClass]
    public class ParseTests
    {
		//[TestMethod]
  //      public void MultipleOptionsCanBeFoundTest()
		//{
		//	var args = new[] { "-h" };

		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Option("-h", "--help");
		//	var arguments = argumentHelper.Parse(args);

		//	Assert.IsTrue(arguments.Options.Contains("-h"));
		//	Assert.IsTrue(arguments.Options.Contains("--help"));
		//}

		//[TestMethod]
		//public void MultipleOptionsValueCanBeFoundTest()
		//{
		//	var args = new[] { "-i", "foo.bar" };

		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Option("-i", "--input").HasValue();
		//	var arguments = argumentHelper.Parse(args);

		//	Assert.AreEqual("foo.bar", arguments.Options["-i"]);
		//	Assert.AreEqual("foo.bar", arguments.Options["--input"]);
		//}
		
		//[TestMethod]
		//public void CommandExistsTest()
		//{
		//	var args = new[] { "help" };

		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Command("help");
		//	var arguments = argumentHelper.Parse(args);

		//	Assert.IsTrue(arguments.Commands.Contains("help"));
		//}

		//[TestMethod]
		//public void CommandArgumentTest()
		//{
		//	var args = new[] { "input", "foo.bar", "output", "bar.foo" };

		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Command("input").HasValue().Configure()
		//		.Command("output").HasValue();
		//	var arguments = argumentHelper.Parse(args);

		//	Assert.AreEqual("foo.bar", arguments.Commands["input"]);
		//	Assert.AreEqual("bar.foo", arguments.Commands["output"]);
		//}

		//[TestMethod]
		//public void CommandArgumentValueTest()
		//{
		//	var args = new[] { "foo.bar", "bar.foo" };

		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Argument("input").Configure()
		//		.Argument("output");
		//	var arguments = argumentHelper.Parse(args);

		//	Assert.AreEqual("foo.bar", arguments.Arguments[0]);
		//	Assert.AreEqual("bar.foo", arguments.Arguments[1]);
		//}

		[TestMethod]
		public void Test1()
		{
			var argumentHelper = new ArgumentHelper();
			argumentHelper.Configure()
				.ProgramName("program-name")
				.Description("This is a description of what the app does.")
				.Usage("Usage: program-name [options] [commands] [arg1] [arg2]")
				.Section("options").Separator(", ")
					.Argument("-h", "--help").Description("Show help.")
					.Argument("-i", "--input").Description("Input files.").HasValues("input", 2)
					.Argument("-o", "--output").Description("Output file.").HasValue("output")
				.Section("commands")
					.Argument("h", "help").Description("Show help")
					.Argument("i", "input").Description("Input files.").HasValues("input", 2)
					.Argument("o", "output").Description("Output file.").HasValue("output")
				.Section()
					.Argument("arg1")
					.Argument("arg2");

			var arguments = argumentHelper.Parse(new string[] { "--help" });
			var helpExists = arguments["options"]["-h"].Exists;
			var inputValues = arguments["options"]["-i"].Values;
			var outputValue = arguments["options"]["-o"].Value;
		}
	}
}
