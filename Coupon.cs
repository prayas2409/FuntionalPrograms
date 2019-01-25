using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Coupon
    {
        public void CouponGame()
        {
            int numcoupon, rand, counter=0, count=0, rcoupon=0;
            Console.WriteLine("Enter the range of coupons");
            numcoupon = Utility.IsInteger(Console.ReadLine());
            int[] coupons = new int[numcoupon];
            int[] couponscounter=new int[numcoupon];
            for(counter=0; counter<numcoupon; counter++)
            {
                coupons[counter] = counter + 1;
                couponscounter[counter] = 0;
            }
            while(count==numcoupon)
            {
                count = 0;
                rcoupon++;
                rand = Utility.RandomIntGenerator(1, numcoupon + 1);
                Console.WriteLine("random {0} ", rand);
                for (counter = 0; counter < numcoupon; counter++)
                {
                    if (couponscounter[counter] == 1) count++;    
                }
                if (count==numcoupon) break;
                else
                {
                    for (counter = 0; counter < numcoupon; counter++)
                    {
                        if (coupons[counter] == rand && couponscounter[counter] == 0)
                        {
                            coupons[counter] = 1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Total random numbers needed: {0} ", rcoupon);
        }
    }
}
