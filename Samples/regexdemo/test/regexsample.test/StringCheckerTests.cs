using System;
using Xunit;

namespace regexsample.test
{
    public class StringCheckerTests
    {
        [Fact]
        public void RegexMatchesOnStringLiteral()
        {
            Assert.True(StringChecker.CheckString("sample", @"amp"));
        }

        [Fact]
        public void RegexMatchesOnStringLiteralWithQuotes()
        {
            Assert.True(StringChecker.CheckString("\"sample\"", @"amp"));
        }

        [Fact]
        public void RegexMatchesOnQuotes()
        {
            Assert.True(StringChecker.CheckString("\"sample\"", "\""));
        }

        ////[Fact]
        ////public void WhenStringContainsExtraQuoteReturnTrue()
        ////{
        ////    var actual = "\"Sample\"";
        ////    Assert.True(StringChecker.CheckStringForExtraQuotes(actual));
        ////}
    }
}
