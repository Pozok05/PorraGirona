using System;
using System.Collections.Generic;

namespace PorraGironaWeb.DataLayer;

public partial class penyes
{
    public int idpenya { get; set; }

    public string? nom { get; set; }

    public virtual ICollection<penyistes> penyistes { get; set; } = new List<penyistes>();
}
