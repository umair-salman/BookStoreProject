using System.Collections.Generic;
namespace BookStoreProject
{
    public class Order
    {
        public int Id { get; set; }
        public int bookId { get; set; }

        public int categoryId { get; set; }
        public int quantity { get; set; }

        public List<Order> GetCustomerOrder()
        {

            var ordersList = new List<Order>();

            ordersList.Add(new Order { Id = 1, bookId = 1, categoryId = 1, quantity = 1 });
            ordersList.Add(new Order { Id = 2, bookId = 2, categoryId = 2, quantity = 1 });
            ordersList.Add(new Order { Id = 3, bookId = 3, categoryId = 3, quantity = 1 });
            ordersList.Add(new Order { Id = 4, bookId = 4, categoryId = 2, quantity = 1 });
            ordersList.Add(new Order { Id = 5, bookId = 5, categoryId = 2, quantity = 1 });
            ordersList.Add(new Order { Id = 6, bookId = 6, categoryId = 1, quantity = 1 });
            ordersList.Add(new Order { Id = 7, bookId = 7, categoryId = 2, quantity = 1 });

            return ordersList;
        }


    }
}
