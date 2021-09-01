using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteTakingApp.Domain;
using Xunit;

namespace NoteTakingApp.UnitTests.Domain
{
    public class NoteServiceTests
    {
        [Fact]
        public void RemoveDuplicates_ReturnsZero()
        {
            // arrange
            var service = new NoteService(repo: null);

            // act
            var result = service.RemoveDuplicateNotes();

            // assert
            Assert.Equal(expected: 0, actual: result);
        }
    }
}
