public enum ReservationStatus
{
    Reserved,    // Booked for the future
    Cancelled,   // Cancelled before pickup
    NoShow,      // Did not show up
    Overdue,      // Past the return date
    Fulfilled    // Customer arrived and the Rental contract was created!
}