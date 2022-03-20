
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using AlbelliAPI.Utilities;

namespace AlbelliAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public OrderController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpPost]
        public async Task<ActionResult<List<OrderInfoSaveDto>>> CreateOrder(OrderInfoSaveDto Request)
        {
            try
            {
                if (Request != null)
                {
                    var NewOreder = new OrderInfomation()
                    {
                        Id = Request.OrderId,
                    };

                    _dataContext.OrderInfomation.Add(NewOreder);

                    if (Request.ProdcutsDtos != null)
                    {
                        foreach (ProdcutsDto item in Request.ProdcutsDtos)
                        {
                            if (item != null)
                            {
                                var order_product = new Order_Product()
                                {
                                    OrderId = Request.OrderId,
                                    ProductId = item.ProductTypeId,
                                    Quantity = item.Quantity
                                };
                                _dataContext.Order_Products.Add(order_product);
                            }
                        }
                        await _dataContext.SaveChangesAsync();
                    }
                    return Ok("Order Added Successfully !!");
                }

                return BadRequest(" Unknown error occured ");

            }
            catch (Exception ex)
            {
                return BadRequest("Error occured : " + ex.Message + ",  Details  : " + ex.InnerException);
            }
        }

        [HttpGet("{OrderId}")]
        // public async Task<ActionResult<List<OrderRetrievalDto>>> Get(int OrderId
        public async Task<IActionResult> Get(int OrderId)
        {
            try
            {
                var CalculationUtilObj = new BindWithCalculationUtility();
                //var FilteredOrderList = await _dataContext.OrderInfomation.AsNoTracking()
                //             .Where(c => c.Id == OrderId)
                //             .Include(c => c.Order_Products)
                //             .ToListAsync();
                //var OrderInfo = FilteredOrderList.FirstOrDefault();

                var FilteredOrderList = await _dataContext.OrderInfomation.AsNoTracking()
                     .Where(c => c.Id == OrderId)
                     .Include(c => c.Order_Products)
                     .ToListAsync();
                var OrderInfo = FilteredOrderList.FirstOrDefault();

                if (OrderInfo != null)
                {
                    var returnOrderObject = new OrderRetrievalDto()
                    {
                        OrderId = OrderId,
                        ProdcutsDtos = new List<ProdcutsDto>()
                    };

                    if (OrderInfo.Order_Products != null)
                    {
                        foreach (var item in OrderInfo.Order_Products)
                        {
                            var retProduct = new ProdcutsDto()
                            {
                                ProductType = await _dataContext.ProdcutTypes.AsNoTracking()
                                        .Where(op => op.Id == item.ProductId)
                                        .Select(op => op.ProdcutName)
                                        .SingleOrDefaultAsync (),
                                ProductTypeId = item.ProductId,
                                Quantity = item.Quantity
                            };

                            returnOrderObject.ProdcutsDtos.Add(retProduct);
                        }

                        returnOrderObject.RequiredBinWidth = CalculationUtilObj.CalculateBindWidth(OrderInfo.Order_Products).ToString()+"mm";
                        return Ok(returnOrderObject);
                    }
                }
                return BadRequest(" Order Not found");
            }
            catch (Exception ex)
            {

                return BadRequest("Error occured : " + ex.Message + ",  Details  : " + ex.InnerException);
            }
        }


    }
}
