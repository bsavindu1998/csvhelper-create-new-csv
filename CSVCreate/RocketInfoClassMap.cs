using CsvHelper.Configuration;

namespace CSVCreate
{
    public sealed class RocketInfoClassMap:ClassMap<RocketInfo>
    {
        public RocketInfoClassMap()
        {
            Map(r => r.RocketName).Name("rocket_name");
            Map(r => r.Organization).Name("organization");
            Map(r => r.PayloadCapacity).Name("payload_capacity").Convert(rocker => rocker.Value.PayloadCapacity.HasValue ? $"{rocker.Value.PayloadCapacity} kg" : string.Empty);
            Map(r => r.FirstLaunchDate).Name("first_launch").TypeConverterOption.Format("s");

        }
    }
}
