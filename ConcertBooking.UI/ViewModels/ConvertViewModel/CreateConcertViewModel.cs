using ConcertBooking.Entities;

namespace ConcertBooking.UI.ViewModels.ConvertViewModel
{
    public class CreateConcertViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int VenueID { get; set; }
    }
}
