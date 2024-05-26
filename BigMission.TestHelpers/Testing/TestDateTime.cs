namespace BigMission.TestHelpers.Testing;

public class TestDateTime : IDateTimeHelper
{
    public DateTime? DateTimeTestValue { get; set; }

    public DateTime Now => DateTimeTestValue ?? DateTime.Now;

    public DateTime UtcNow => DateTimeTestValue ?? DateTime.UtcNow;
}
