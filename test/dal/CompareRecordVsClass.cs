using FluentAssertions;
using src.dal;
namespace test.dal;

public class CompareRecordVsClass
{
    [Fact]
    public void TwoEqualRecordsMustReturnTrue()
    {
        var firstname = "firstname";
        var lastname = "lastname";
        var id = 1;
        var sr1 = new StudentRecord { FirstName = firstname, LastName = lastname, Id = id };
        var sr2 = new StudentRecord { FirstName = firstname, LastName = lastname, Id = id };

        sr1.Should().Be(sr2);
    }

    [Fact]
    public void TwoEqualClassesMustReturnFlase()
    {
        var firstname = "firstname";
        var lastname = "lastname";
        var id = 1;
        var s1 = new Student { FirstName = firstname, LastName = lastname, Id = id };
        var s2 = new Student { FirstName = firstname, LastName = lastname, Id = id };

        s1.Should().NotBe(s2);
    }
}