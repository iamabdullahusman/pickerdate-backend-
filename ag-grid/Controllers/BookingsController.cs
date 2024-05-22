using ag_grid.Models;
using ag_grid.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ag_grid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly BookingRepository _repository;

        public BookingsController()
        {
            _repository = new BookingRepository();
        }

        [HttpGet("range")]
        public ActionResult<IEnumerable<Booking>> GetBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            var bookings = _repository.GetBookingsByDateRange(startDate, endDate);

            if (bookings == null || !bookings.Any())
            {
                return NotFound();
            }

            return Ok(bookings);
        }
        [HttpPost]
        public IActionResult SaveBooking(Booking booking)
        {
            if (booking == null)
            {
                return BadRequest("Invalid booking data");
            }

            // Simulate data storage (replace with your desired logic)
            Console.WriteLine($"Booking saved: Start Date - {booking.StartDate}, End Date - {booking.EndDate}, Description - {booking.Description}");

            return Ok();
        }
    }
}
