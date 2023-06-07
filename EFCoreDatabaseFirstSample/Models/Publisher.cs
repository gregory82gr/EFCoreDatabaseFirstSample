using System;
using System.Collections.Generic;

namespace EFCoreDatabaseFirstSample.Models;

public partial class Publisher
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
