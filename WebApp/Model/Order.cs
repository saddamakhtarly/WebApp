using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Order
    {
        //Id, CustomerId, OrderDate, RequiredDate, ShipingAddressName, Address, City, Region, PostalCode, Country
        public int Id { get; set; }
        
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipingAddressName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        
        //Navigation Property
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer  Customer { get; set; }
    }
}
