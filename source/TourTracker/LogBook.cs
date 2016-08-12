namespace TourTracker
{
    using System;
    using System.Collections.Generic;

    public class LogBook
    {
        private Guid id;

        public IReadOnlyList<Event> Create(Guid id)
        {
            this.id = id;
            return new[] { new LogBookCreated(id) };
        }

        public IReadOnlyList<Event> Depart()
        {
            return new[] { new TourStarted(this.id) };
        }
    }

    public class TourStarted : Event
    {
        public TourStarted(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }

    public class LogBookCreated : Event
    {
        public LogBookCreated(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }

    public abstract class Event
    {
    }
}