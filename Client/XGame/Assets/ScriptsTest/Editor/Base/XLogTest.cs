using NUnit.Framework;

[TestFixture]
public class XLogTest  
{
    [Test]
    public void TestLog()
    {
        XLog log = new XLog();
        log.Debug("Test");
    }
	
}
