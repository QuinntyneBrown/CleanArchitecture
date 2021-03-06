using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Events;
using System.Linq;
using Xunit;

namespace CleanArchitecture.Tests.Core.Entities
{
    public class ToDoItemMarkCompleteShould
    {
        [Fact]
        public void SetIsDoneToTrue()
        {
            var item = new ToDoItem();

            item.MarkComplete();

            Assert.True(item.IsDone);
        }

        [Fact]
        public void RaiseToDoItemCompletedEvent()
        {
            var item = new ToDoItem();

            item.MarkComplete();

            Assert.Single(item.Events);
            Assert.IsType<ToDoItemCompletedEvent>(item.Events.First());
        }
    }
}
