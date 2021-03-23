using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreProject
{
    public static class Utitliy
    {
        const double minDeliveryCost = 5.95;
        const double deliveryFeeThreshold = 20.0;
        public static double ApplyGST(double cost)
        {

            try
            {
                if (!(double.IsNaN(cost)))

                {

                    cost += cost * 0.1;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cost;

        }

        public static double AddDeliveryFee(double cost)
        {
            try
            {
                if (!(double.IsNaN(cost)) && cost < deliveryFeeThreshold)

                {

                    cost = cost + minDeliveryCost;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cost;

        }

    }
}
