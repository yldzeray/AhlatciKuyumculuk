﻿using AhlatciKuyumculuk.Shop.Application.Models.RequestModels.OrderDetails;
using FluentValidation;

namespace AhlatciKuyumculuk.Shop.Application.Validators.OrderDetails
{
    public class GetOrderDetailsByOrderIdValidator : AbstractValidator<GetOrderDetailsByOrderIdVM>
    {
        public GetOrderDetailsByOrderIdValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty().WithMessage("Sipariş numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Sipariş numarası sıfırdan büyük olmalıdır.");
        }
    }
}
