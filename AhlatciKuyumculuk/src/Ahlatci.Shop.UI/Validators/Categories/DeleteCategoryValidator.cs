﻿using AhlatciKuyumculuk.Shop.UI.Models.RequestModels;
using FluentValidation;

namespace AhlatciKuyumculuk.Shop.UI.Validators.Categories
{
    public class DeleteCategoryValidator : AbstractValidator<DeleteCategoryVM>
    {
        public DeleteCategoryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Kategori kimlik numarası boş bırakılamaz.")
                .GreaterThan(0)
                .WithMessage("Kategori kimlik bilgisi sıfırdan büyük olmalıdır.");
        }
    }
}
