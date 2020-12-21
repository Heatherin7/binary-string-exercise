using System;
using BinaryString;
using NUnit.Framework;

namespace BinaryStringTests
{
	public class Tests
	{
		private BinaryStringConverter _converter;

		[SetUp]
		public void Setup() => _converter = new BinaryStringConverter();

		[TestCase("0", 0)]
		[TestCase("1", 1)]
		[TestCase("00", 0)]
		[TestCase("10", 1)]
		[TestCase("01", 2)]
		[TestCase("11", 3)]
		[TestCase("000", 0)]
		[TestCase("100", 1)]
		[TestCase("010", 2)]
		[TestCase("110", 3)]
		[TestCase("001", 4)]
		[TestCase("101", 5)]
		[TestCase("011", 6)]
		[TestCase("111", 7)]
		[TestCase("01010100", 42)]
		public void Converts_String_To_Int(string input, int expectedResult)
		{
			var result = _converter.ConvertString(input);
			Assert.AreEqual(expectedResult, result);
		}

		[TestCase("INVALID")]
		[TestCase("")]
		[TestCase(null)]
		[TestCase(" ")]
		[TestCase("0102011")]
		public void Throw_Exception_For_Invalid_Input(string input)
		{
      Assert.Throws<ArgumentException>(() => _converter.ConvertString(input));
		}
	}
}