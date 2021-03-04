using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Ocupation { get; set; }
    }

    public enum Position
    {
        Chef,
        Waiter,
        Manager,
        DeputyManager,
    }
}
