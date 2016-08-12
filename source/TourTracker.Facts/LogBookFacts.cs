namespace TourTracker
{
    using System;
    using System.Linq;
    using FluentAssertions;
    using Xunit;

    public class LogBookFacts
    {
        private readonly LogBook testee;

        public LogBookFacts()
        {
            this.testee = new LogBook();
        }

        [Fact]
        public void CreatesTheLogBook()
        {
            var id = new Guid("8C1D7C4F-0DC4-43FB-8E6F-950BFB4559C5");
            var events = this.testee.Create(id);

            events.Should().HaveCount(1);
            events.First().As<LogBookCreated>().ShouldBeEquivalentTo(new LogBookCreated(id));
        }

        [Fact]
        public void DepartureStartsTour()
        {
            var id = new Guid("75030D83-2FEE-4907-B6CE-72D8852ABA49");
            this.testee.Create(id);

            var events = this.testee.Depart();

            events.Should().HaveCount(1);
            events.First().As<TourStarted>().ShouldBeEquivalentTo(new TourStarted(id));
        }
    }
}