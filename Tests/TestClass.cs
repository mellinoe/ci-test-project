using System;
using Xunit;
using SourceLib;

namespace Tests
{
    public class TestClass
    {
        [Fact]
        public void TestSampleClass()
        {
            int result = new SampleClass().GetValue();
            Assert.Equal(12, result);
        }

        [Fact]
        public void IntentionalFailure()
        {
            Assert.True(false);
        }
    }
}
