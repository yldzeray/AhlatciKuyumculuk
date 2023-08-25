using AhlatciKuyumculuk.Shop.Application.Models.Dtos;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.ProductImages;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Products;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.ProductImages;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Products;
using AhlatciKuyumculuk.Shop.Application.Services.Abstraction;
using AhlatciKuyumculuk.Shop.Application.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AhlatciKuyumculuk.Shop.Api.Controllers
{

    [ApiController]
    [Route("productImage")]    
    //[Authorize("Admin")]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet("getAllByProduct/{id:int?}")]
        public async Task<ActionResult<Result<List<ProductImageDto>>>>GetAllImagesByProduct(int? id)
        {
            var result = await _productImageService.GetAllImagesByProduct(new GetAllProductImageByProductVM { ProductId=id});
            return Ok(result);
        }

        [HttpGet("getAllDetailByProduct/{id:int?}")]
        public async Task<ActionResult<Result<List<ProductImageWithProductDto>>>> GetAllImagesWithProductByProduct(int? id)
        {
            var result = await _productImageService.GetAllProductImagesWithProduct(new GetAllProductImageByProductVM { ProductId = id });
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Result<int>>> CreateProduct([FromForm]CreateProductImageVM createProductImageVM)
        {
            var result = await _productImageService.CreateProductImage(createProductImageVM);
            return Ok(result);
        }

        [HttpDelete("delete/{id:int?}")]
        public async Task<ActionResult<Result<int>>> DeleteProduct(int? id)
        {
            var result = await _productImageService.DeleteProductImage(new DeleteProductImageVM { Id = id});
            return Ok(result);
        }


    }
}

