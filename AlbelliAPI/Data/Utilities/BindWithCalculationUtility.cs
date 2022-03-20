namespace AlbelliAPI.Utilities
{
    public class BindWithCalculationUtility
    {
        public BindWithCalculationUtility()
        {

        }
        public double CalculateBindWidth(List<Order_Product> order_Products)
        {
            try
            {
                double finalWidth = 0;

                foreach (var item in order_Products)
                {
                    if (item.ProductId != 5) {
                        finalWidth += item.Quantity * GetPackageWidth(item.ProductId);
                    }
                    else
                    {
                        //finalWidth += Math.Ceiling(((Double)item.Quantity / 4)) * GetPackageWidth(item.ProductId);
                        double quotient = Math.Ceiling(((Double)item.Quantity / 4));
                        finalWidth += quotient * GetPackageWidth(item.ProductId);
                    }
                }

                return finalWidth;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //I hardcoded the prodcuts and length for the assignment. in real world scenario porbably these details would be saved in a different settings table. this could have also sved in a Dictionary
         private double GetPackageWidth(int ProdcutId)
        {
            switch (ProdcutId)
            {
                case 1://photoBook
                    return 19; 
                case 2: // calendar 
                    return 10; 
                case 3: // canvas 
                    return 16; 
                case 4:// cards 
                    return 4.7; 
                case 5: // mug
                    return 94; 
                default:
                    return 0;
            }
        }

    }
}
