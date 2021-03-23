using System;

namespace BookStoreProject
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                #region Objects Declaration

                double totalCostWithTax = 0.0;
                double totalCostWithoutTax = 0.0;
                Category category = new Category();
                Book book = new Book();
                Order orders = new Order();

                #endregion

                #region Setting Objects
                var categories = category.AddCategory();
                var booksList = book.AddBook();
                var ordersList = orders.GetCustomerOrder();
                #endregion

                #region Calculations

                foreach (var OrderItem in ordersList)
                {
                    //Fetching the book and category for the orderitem                
                    var bookItem = booksList.Find(b => b.Id == OrderItem.bookId);
                    var categoryitem = categories.Find(c => c.Id == bookItem.categoryId);

                    var unitPrice = bookItem != null ? bookItem.unitPrice : 0;
                    var discount = categoryitem != null ? categoryitem.discountPercentage : 0;

                    //Calculating the cost without Tax and delivery fee
                    totalCostWithoutTax += (OrderItem.quantity * unitPrice) - (discount * 0.01);

                }

                //Calculating the total cost with tax and delivery (if applicable)
                totalCostWithTax = Utitliy.AddDeliveryFee(Utitliy.ApplyGST(totalCostWithoutTax));

                //Adding the Delivery fee for the total cost without tax (if applicable)
                totalCostWithoutTax = Utitliy.AddDeliveryFee(totalCostWithoutTax);


                #endregion

                #region Displaying Results

                Console.WriteLine(string.Format("Total order Cost without Tax is: {0}", totalCostWithoutTax));
                Console.WriteLine(string.Format("Total order Cost with Tax is: {0}", totalCostWithTax));

                #endregion

            }
            catch (Exception ex)
            {
                //Logging of Exceptions (log4net) can be implemented.
                throw ex;
            }
        }


    }
}
