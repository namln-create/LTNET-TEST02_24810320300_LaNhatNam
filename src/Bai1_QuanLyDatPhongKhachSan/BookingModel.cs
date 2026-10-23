using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_QuanLyDatPhongKhachSan
{

    public class BookingModel
    {
        public string BookingId { get; set; }
        public string CustomerName { get; set; }
        public string IdentityCard { get; set; }
        public string RoomType { get; set; }
        public DateTime CheckInDate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
