using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed Database associated with Context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    UserName = "rahulsikder223",
                    FirstName = "Rahul",
                    LastName = "Sikder",
                    EmailAddress = "rahulsikder223@gmail.com",
                    AddressLine1 = "BC-1, Salt Lake City, Sector-I",
                    AddressLine2 = "Bidhannagar, North 24 Parganas",
                    City = "Kolkata",
                    State = "West Bengal",
                    Country = "India",
                    ZipCode = "700064",
                    CardName = "Bishwadeep Sikder",
                    CardNumber = "1234567812344214",
                    Expiration = "11/27/2027",
                    CVV = "123",
                    PaymentMethod = 1
                }
            };
        }
    }
}
