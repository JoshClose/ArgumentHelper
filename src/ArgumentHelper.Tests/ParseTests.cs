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
		[TestMethod]
        public void MultipleOptionsCanBeFoundTest()
		{
			var args = new[] { "-h" };

			var argumentHelper = new ArgumentHelper();
			argumentHelper.Configure()
				.Option("-h", "--help");
			var arguments = argumentHelper.Parse(args);

			Assert.IsTrue(arguments.Options.Contains("-h"));
			Assert.IsTrue(arguments.Options.Contains("--help"));
		}

		[TestMethod]
		public void MultipleOptionsValueCanBeFoundTest()
		{
			var args = new[] { "-i", "foo.bar" };

			var argumentHelper = new ArgumentHelper();
			argumentHelper.Configure()
				.Option("-i", "--input").HasValue();
			var arguments = argumentHelper.Parse(args);

			Assert.AreEqual("foo.bar", arguments.Options["-i"]);
			Assert.AreEqual("foo.bar", arguments.Options["--input"]);
		}
		
		[TestMethod]
		public void CommandExistsTest()
		{
			var args = new[] { "help" };

			var argumentHelper = new ArgumentHelper();
			argumentHelper.Configure()
				.Command("help");
			var arguments = argumentHelper.Parse(args);

			Assert.IsTrue(arguments.Commands.Contains("help"));
		}

		[TestMethod]
		public void CommandArgumentTest()
		{
			var args = new[] { "input", "foo.bar", "output", "bar.foo" };

			var argumentHelper = new ArgumentHelper();
			argumentHelper.Configure()
				.Command("input").HasValue().Configure()
				.Command("output").HasValue();
			var arguments = argumentHelper.Parse(args);

			Assert.AreEqual("foo.bar", arguments.Commands["input"]);
			Assert.AreEqual("bar.foo", arguments.Commands["output"]);
		}

		[TestMethod]
		public void CommandArgumentValueTest()
		{
			var args = new[] { "foo.bar", "bar.foo" };

			var argumentHelper = new ArgumentHelper();
			argumentHelper.Configure()
				.Argument("input").Configure()
				.Argument("output");
			var arguments = argumentHelper.Parse(args);

			Assert.AreEqual("foo.bar", arguments.Arguments[0]);
			Assert.AreEqual("bar.foo", arguments.Arguments[1]);
		}
	}
}
