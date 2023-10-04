using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblAniversario
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public int? ClientId { get; set; }

    public int? UserId { get; set; }

    public DateTime? ContactDate { get; set; }

    public string? ContactType { get; set; }
}
