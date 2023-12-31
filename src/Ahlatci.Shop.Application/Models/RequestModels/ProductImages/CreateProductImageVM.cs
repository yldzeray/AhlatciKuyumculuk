﻿using Microsoft.AspNetCore.Http;

namespace AhlatciKuyumculuk.Shop.Application.Models.RequestModels.ProductImages
{
    public class CreateProductImageVM
    {
        public int? ProductId { get; set; }
        public int? Order { get; set; } = 0;
        public bool? IsThumbnail { get; set; }
        public IFormFile UploadedImage { get; set; }
    }
}


