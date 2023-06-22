
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Models;
using RelationalOrderDb.DTO;
using System.Diagnostics.Metrics;
using System.Numerics;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Repositroy;
using Azure;
using Microsoft.AspNetCore.JsonPatch;

namespace RelationalOrderDb.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class SupplierController:Controller
    {
        #region Private Attribute
        //public readonly OrderSimpleContext _dbContext;
        private readonly ISupplierServices _iSupplierServices;
        #endregion

        #region Constructor
        public SupplierController(OrderSimpleContext dbcontext, ISupplierServices iSupplierServices)
        {
            _iSupplierServices = iSupplierServices;
            // this._dbContext = dbcontext;
        }
        #endregion

        #region Get Records
        [HttpGet("Supllier")]
        public  IEnumerable<Supplier> GEtAllSuppliers()
        {
           return _iSupplierServices.GetSuppliers();

        }


        // [HttpGet("SingleSupllier/{id}")]
        // public async Task<IActionResult> GEtSingleSuppliers([FromRoute] int id)
        // {
        //     try
        //     {
        //         var varSupplier = await _dbContext.Suppliers.FindAsync(id);
        //         if (varSupplier != null)
        //         {
        //             return Ok(varSupplier);
        //         }
        //         return NotFound();

        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        // #endregion

        // #region Update Records

        // [HttpPut]
        // [Route("UpdateSupllier/{id}")]
        // public async Task<IActionResult> UpdateProduct([FromRoute] int id, SupplierDTO supplierdto)
        // {
        //     try
        //     {
        //         var updateSupplier = await _dbContext.Suppliers.FindAsync(id);
        //         if (updateSupplier != null)
        //         {

        //             updateSupplier.CompanyName = supplierdto.CompanyName;
        //             updateSupplier.ContactName = supplierdto.ContactName;
        //             updateSupplier.ContactTitle = supplierdto.ContactTitle;
        //             updateSupplier.City = supplierdto.City;
        //             updateSupplier.Country = supplierdto.Country;
        //             updateSupplier.Phone = supplierdto.Phone;
        //             updateSupplier.Fax = supplierdto.Fax;

        //             await _dbContext.SaveChangesAsync();
        //             return Ok("UpdateSuccesfully");
        //         }
        //         return NotFound();
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }


        // [HttpPatch]
        // [Route("PatchSupllier/{id}")]
        // public async Task<IActionResult> PatchSupllier([FromRoute] int id, [FromBody] JsonPatchDocument<Supplier> supplier)
        // {
        //     var supp = await _dbContext.Suppliers.FindAsync(id);
        //     if (supp != null)
        //     {
        //         supplier.ApplyTo(supp, ModelState);
        //         if (!ModelState.IsValid)
        //         {
        //             return BadRequest(ModelState);
        //         }

        //         return Ok(supp);


        //     }
        //     return NotFound();
        // }
        // #endregion

        // #region  Add New Supplier

        // [HttpPost("AddSupplier")]
        // public async Task<IActionResult> AddSupllier(SupplierDTO _supplierdto)
        // {
        //     try
        //     {

        //     var addsupplier = new Supplier()
        //     {
        //        CompanyName = _supplierdto.CompanyName,
        //        ContactName = _supplierdto.ContactName,
        //        ContactTitle = _supplierdto.ContactTitle,
        //        City = _supplierdto.City,
        //        Country = _supplierdto.Country,
        //        Phone = _supplierdto.Phone,
        //        Fax = _supplierdto.Fax
                
        //     };
        //     await _dbContext.Suppliers.AddAsync(addsupplier);
        //     await  _dbContext.SaveChangesAsync();
        //     return Ok( "Add Supplier Successfully.");
        //     }
        //     catch(Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }
        // #endregion

        // #region Delete Supplier Record
        // [HttpDelete("DeleteSupllier/{id}")]
        // public async Task<IActionResult> DelteProdcut([FromRoute] int id)
        // {
        //     try
        //     {
        //         var deleteSupllier = await _dbContext.Suppliers.FindAsync(id);
        //         if (deleteSupllier != null)
        //         {
        //             _dbContext.Suppliers.Remove(deleteSupllier);
        //             await _dbContext.SaveChangesAsync();
        //             return Ok(deleteSupllier);
        //         }
        //         return NotFound();
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        #endregion

    }
}   