using ag_grid.Models;

namespace ag_grid.Repository
{
    public class BookingRepository
    {
        private readonly List<Booking> _bookings;

        public BookingRepository()
        {
            _bookings = new List<Booking>
            {
                new Booking { Id = 1, StartDate = new DateTime(2024, 5, 20), EndDate = new DateTime(2024, 5, 22), Description = "Conference" },
                new Booking { Id = 2, StartDate = new DateTime(2024, 5, 21), EndDate = new DateTime(2024, 5, 23), Description = "Workshop" },
                new Booking { Id = 3, StartDate = new DateTime(2024, 5, 22), EndDate = new DateTime(2024, 5, 24), Description = "Meeting" },
                new Booking { Id = 4, StartDate = new DateTime(2024, 5, 23), EndDate = new DateTime(2024, 5, 29), Description = "Dubai Trip" },
                new Booking { Id = 5, StartDate = new DateTime(2024, 5, 24), EndDate = new DateTime(2024, 5, 26), Description = "Vist to Google" },
                new Booking { Id = 6, StartDate = new DateTime(2024, 5, 25), EndDate = new DateTime(2024, 5, 27), Description = "Go to penthouse" },
                // Add more bookings as needed
            };
        }

        public IEnumerable<Booking> GetBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _bookings.Where(b => b.StartDate <= endDate && b.EndDate >= startDate).ToList();
        }
    }
}

