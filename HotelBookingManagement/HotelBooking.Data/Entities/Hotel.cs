using System;
using System.Collections.Generic;

namespace HotelBooking.Data.Entities;

public partial class Hotel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
