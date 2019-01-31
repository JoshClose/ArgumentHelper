using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper.Tests
{
	[TestClass]
    public class UsageTests
    {
		//[TestMethod]
  //      public void OptionDoesNotTouchDescriptionWhen1CharBeforeTabEndTest()
		//{
		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Option("-a", "--abcdefgh").Description("description");
		//	var usage = argumentHelper.GetUsage();

		//	var expected = new StringBuilder();
		//	expected.AppendLine("Usage: [options]");
		//	expected.AppendLine();
		//	expected.AppendLine("options:");
		//	expected.AppendLine("  -a|--abcdefgh description");

		//	Assert.AreEqual(expected.ToString(), usage);
		//}

		//[TestMethod]
		//public void OptionDoesNotTouchDescriptionWhenCharsAreAtTabEndTest()
		//{
		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Option("-a", "--abcdefghi").Description("description");
		//	var usage = argumentHelper.GetUsage();

		//	var expected = new StringBuilder();
		//	expected.AppendLine("Usage: [options]");
		//	expected.AppendLine();
		//	expected.AppendLine("options:");
		//	expected.AppendLine("  -a|--abcdefghi        description");

		//	Assert.AreEqual(expected.ToString(), usage);
		//}

		//[TestMethod]
		//public void CommandDoesNotTouchDescriptionWhen1CharBeforeTabEndTest()
		//{
		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Command("34567").Description("description");
		//	var usage = argumentHelper.GetUsage();

		//	var expected = new StringBuilder();
		//	expected.AppendLine("Usage: [commands]");
		//	expected.AppendLine();
		//	expected.AppendLine("commands:");
		//	expected.AppendLine("  34567 description");

		//	Assert.AreEqual(expected.ToString(), usage);
		//}

		//[TestMethod]
		//public void CommandDoesNotTouchDescriptionWhenCharsAreAtTabEndTest()
		//{
		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Command("345678").Description("description");
		//	var usage = argumentHelper.GetUsage();

		//	var expected = new StringBuilder();
		//	expected.AppendLine("Usage: [commands]");
		//	expected.AppendLine();
		//	expected.AppendLine("commands:");
		//	expected.AppendLine("  345678        description");

		//	Assert.AreEqual(expected.ToString(), usage);
		//}

		//[TestMethod]
		//public void ArgumentsTest()
		//{
		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Argument("arg1");
		//	var usage = argumentHelper.GetUsage();

		//	var expected = new StringBuilder();
		//	expected.AppendLine("Usage: [arg1]");

		//	Assert.AreEqual(expected.ToString(), usage);
		//}

		//[TestMethod]
		//public void AllTest()
		//{
		//	var argumentHelper = new ArgumentHelper();
		//	argumentHelper.Configure()
		//		.Option("-h", "--help").Description("Show help.").Configure()
		//		.Option("-i", "--input").Description("Input file.").HasValue().Configure()
		//		.Command("help").Description("Show help.").Configure()
		//		.Command("input").Description("Input file.").HasValue().Configure()
		//		.Argument("input");
		//	var usage = argumentHelper.GetUsage();

		//	var expected = new StringBuilder();
		//	expected.AppendLine("Usage: [options] [commands] [input]");
		//	expected.AppendLine();
		//	expected.AppendLine("options:");
		//	expected.AppendLine("  -h|--help     Show help.");
		//	expected.AppendLine("  -i|--input    Input file.");
		//	expected.AppendLine();
		//	expected.AppendLine("commands:");
		//	expected.AppendLine("  help  Show help.");
		//	expected.AppendLine("  input Input file.");

		//	Assert.AreEqual(expected.ToString(), usage);
		//}
	}
}
