

namespace SwissTransport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;
    using FluentAssertions;






    public class Testing
    {
        private readonly ITransport testee;
        
        public Testing()
        {
            // arrange
            this.testee = new Transport();
        }

        [Fact]
        public void myTest()
        {
            // act
            Stations stations = this.testee.GetStations("Luzern");

            // assert
            stations.StationList.Should().NotBeNull();

        }
    }
}
