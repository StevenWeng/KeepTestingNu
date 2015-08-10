using System;
using NUnit.Framework;


[TestFixture]
public class TestFixture1
{
	[Test]
	public void TestTrue()
	{
		Assert.IsTrue(false);
	}

	// This test fail for example, replace result or delete this test to see all tests pass
	[Test]
	public void TestFault()
	{
		Assert.IsTrue(true);
	}
}

