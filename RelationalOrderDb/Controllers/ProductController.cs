using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Models;
using RelationalOrderDb.DTO;
using System.Net;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Repositroy;
using RelationalOrderDb.Services;
using System.Diagnostics.Metrics;
using System.Numerics;
using Azure;
using Microsoft.AspNetCore.JsonPatch;
namespace RelationalOrderDb.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class ProductController : Controller
    {
        #region Private Attribute
        //public readonly OrderSimpleContext _dbContext;
        private IProductServices _iproductServices;

        #endregion

        #region  Constructor
        public ProductController(OrderSimpleContext _dbcontext, IProductServices iproductServices)
        {
           // this._dbContext = _dbcontext;
            _iproductServices = iproductServices;
        }
        #endregion

        #region Get Product Records


        [HttpGet("GetAllProducts")]
        public IEnumerable<Product> GEtAllProducts()
        {
            return _iproductServices.GetAllProductServices();
            // try
            // {
            //     return Ok(await _dbContext.Products.ToListAsync());
            // }
            // catch (Exception e)
            // {
            //     return Problem(e.Message);
            // }

        }


        // [HttpGet("SingleProduct/{id}")]
        // public async Task<IActionResult> GEtSingleProducts([FromRoute] int id)
        // {
        //     try
        //     {
        //         var varProduct = await _dbContext.Products.FindAsync(id);
        //         if (varProduct != null)
        //         {
        //             return Ok(varProduct);
        //         }
        //         return NotFound();
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }
        // #endregion

        // #region  Add New Product
        // [HttpPost]
        // [Route("AddProduct")]
        // public async Task<IActionResult> AddProduct(ProductDTO productdto)
        // {
        //     try
        //     {
                
        //         var addproduct = new Product()
        //         {
        //             ProductName = productdto.ProductName,
        //             SupplierId = productdto.SupplierId,
        //             UnitPrice = productdto.UnitPrice,
        //             Package = productdto.Package,
        //             IsDiscontinued = productdto.IsDiscontinued
                   
                    
        //           };
        //        await _dbContext.Products.AddAsync(addproduct);
        //        await _dbContext.SaveChangesAsync();
        //         return Ok(addproduct);
        //     }
        //     catch(Exception e) 
        //     {
        //         return Problem(e.Message);
        //     }
            

        // }
        // #endregion

        // #region Update Product Record

        // [HttpPut]
        // [Route("UpdateProduct/{id}")]
        // public async Task<IActionResult> UpdateProduct([FromRoute] int id, ProductDTO productdto)
        // {
        //     try
        //     {
        //         var updateProduct = await _dbContext.Products.FindAsync(id);
        //         if (updateProduct != null)
        //         {
        //             updateProduct.ProductName = productdto.ProductName;
        //             updateProduct.SupplierId = productdto.SupplierId;
        //             updateProduct.UnitPrice = productdto.UnitPrice;
        //             updateProduct.Package = productdto.Package;
        //             updateProduct.IsDiscontinued =  productdto.IsDiscontinued;

        //            await _dbContext.SaveChangesAsync();
        //             return Ok(updateProduct);
        //         }
        //         return NotFound();
        //     }
        //     catch(Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
           
        // }
        #endregion

        #region Delete Product 
        // [HttpDelete("DeleteProduct/{id}")]
        // public async Task<IActionResult> DelteProdcut([FromRoute] int id)
        // {
            
        //     try
        //     {
        //         var deleteProduct = await _dbContext.Products.FindAsync(id);
        //         if(deleteProduct != null)
        //         {
        //             _dbContext.Products.Remove(deleteProduct);
        //             await _dbContext.SaveChangesAsync();
                    
        //             return Ok("Delete Product Successfully"); 
                    
        //         }
        //         return NotFound();
        //     }
        //     catch(Exception e)
        //     {
        //         return Problem(e.InnerException.ToString());
        //     }
        // }
        #endregion



    }
}