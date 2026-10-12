using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class CollectRequest
{
    public int RequestId { get; set; }

    public int RestaurantId { get; set; }

    public int EmployeeId { get; set; }

    public string FoodDescription { get; set; } = null!;

    public int Quantity { get; set; }

    public string MaximumPreserveUntil { get; set; } = null!;

    public string CollectionDate { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Remarks { get; set; } = null!;
}
