using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            //Assert.Throws<ArgumentException>(()=>customer.GetOrdersByName(null));
            var exceptionDetails = Assert.Throws<ArgumentException>(()=> customer.GetOrdersByName(""));
            Assert.Equal("Hello",exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }

    }
}
