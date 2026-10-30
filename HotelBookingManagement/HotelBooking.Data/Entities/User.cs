using System;
using System.Collections.Generic;

namespace HotelBooking.Data.Entities;

public partial class User
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public int RoleId { get; set; }

    public string FullName { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string? Email { get; set; }

    public string PasswordHash { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? Updatedon { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
