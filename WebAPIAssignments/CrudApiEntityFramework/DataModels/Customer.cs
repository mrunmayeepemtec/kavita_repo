using System;
using System.Collections.Generic;

#nullable disable

namespace CrudApiEntityFramework.DataModels
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
