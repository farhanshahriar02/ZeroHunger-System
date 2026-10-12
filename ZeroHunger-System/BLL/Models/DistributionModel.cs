using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class DistributionModel
    {

        public int DistributionId { get; set; }

        public int RequestId { get; set; }

        public int EmployeeId { get; set; }

        public int DistributedQuantity { get; set; }

        public string DistributionLocation { get; set; } = null!;

        public int BeneficiaryCount { get; set; }

        public string DistributionDate { get; set; } = null!;

        public string Remarks { get; set; } = null!;
    }
}
