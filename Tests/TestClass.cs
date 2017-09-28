using System;
using Xunit;
using SourceLib;
using System.Diagnostics;

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

        [Fact]
        public void UseFxc()
        {
            Process.Start("fxc");
        }
    }
}
