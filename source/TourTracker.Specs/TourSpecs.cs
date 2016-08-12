namespace TourTracker
{
    using Xbehave;

    public class TourSpecs
    {
        public void TourIsOnRoadAfterDeparture(LogBook logBook)
        {
            "given a tour"._(() =>
                logBook = new LogBook());

            "when the tour is started"._(() =>
                logBook.Depart());

            "then the tour is OnRoad"._(() =>
            { });
        }
    }
}