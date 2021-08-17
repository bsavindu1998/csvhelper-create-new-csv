using System;
using System.Collections.Generic;

namespace CSVCreate
{
    public class RocketInfo
    {
        public string RocketName { get; set; }
        public string Organization { get; set; }
        public int? PayloadCapacity { get; set; }
        public DateTime FirstLaunchDate { get; set; }

        public static List<RocketInfo> GetRockets()
        {
            return new()
            {
                new RocketInfo()
                {
                    RocketName="Saturn V",
                    Organization = "Nasa",
                    PayloadCapacity = 140000,
                    FirstLaunchDate = new DateTime(1967,09,11)
                },
                new RocketInfo()
                {
                    RocketName = "Falcon 9",
                    Organization = "SpaceX",
                    PayloadCapacity = 22000,
                    FirstLaunchDate = new DateTime(2013,09,29)
                },
                new RocketInfo()
                {
                    RocketName = "Falcon Heavy",
                    Organization = "SpaceX",
                    PayloadCapacity = 64000,
                    FirstLaunchDate = new DateTime(2018,06,02)
                },
                new RocketInfo()
                {
                    RocketName = "Star ship",
                    Organization = "SpaceX",
                    PayloadCapacity = 150000,
                    FirstLaunchDate = new DateTime(2020,09,12)
                },
                new RocketInfo()
                {
                    RocketName = "SLS",
                    Organization = "NASA",
                    PayloadCapacity = 70000,
                    FirstLaunchDate = new DateTime(2049,12,01)
                },
                new RocketInfo()
                {
                    RocketName = "Phoenix",
                    Organization = "Private",
                    FirstLaunchDate = new DateTime(2063,05,04)
                }
            };
        }
    } 
}
