using System;
using Xunit;
using BL;

namespace Test
{
    public class HealthStatusTest
    {
        [Fact]
        public void FbmiTest()
        {
            //Arrange
            double expectedFbmi=17.46746652225517;
            double ribcage=14, legLength=2;
           //Act
           var actualFbmi=HealthStatus.Fbmi(ribcage,legLength);
           //Assert
            Assert.Equal(expectedFbmi,actualFbmi);
        }
        [Fact]
        public void FbmiThrowsArguementExceptionTest()
        {
            double ribcage=-14, legLength=-2;        
            Assert.Throws<ArgumentException>(()=>HealthStatus.Fbmi(ribcage,legLength));
        }
        [Fact]
        public void CatHealthTest()
        {
             var expectedHealth=FbmiInterpretation.NormalWeight;
             var actualHealth=HealthStatus.CatHealth(13);
             Assert.Equal(expectedHealth,actualHealth);
        }
    }
}
