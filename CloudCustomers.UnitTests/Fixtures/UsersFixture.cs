using CloudCustomers.API.Models;
using System.Collections.Generic;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {

            new()
            {
                Id = 1,
                Name = "TestUser 1",
                Address = new Address()
                {
                    City = "Irvyng",
                    Street = "Honey Alley",
                    ZipCode = "55612"
                },
                Email = "trir@example.com"
            },
            new()
            {
                Id = 2,
                Name = "TestUser 2",
                Address = new Address()
                {
                    City = "Hostys",
                    Street = "Horror Alley",
                    ZipCode = "42124"
                },
                Email = "erar@example.com"
            },
        };
    }
}
