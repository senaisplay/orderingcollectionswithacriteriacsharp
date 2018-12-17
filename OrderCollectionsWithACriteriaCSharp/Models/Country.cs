using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCollectionsWithACriteriaCSharp.Models
{
    public class Country
    {
        public static IEnumerable<Country> Countries = new[]
        {
            new Country { Id = Guid.NewGuid(), Name = "Canada" },
            new Country { Id = Guid.NewGuid(), Name = "Brasil" },
            new Country { Id = Guid.NewGuid(), Name = "Australia" },
        };

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
