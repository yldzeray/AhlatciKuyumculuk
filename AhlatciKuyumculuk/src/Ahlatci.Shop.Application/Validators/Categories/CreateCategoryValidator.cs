using AhlatciKuyumculuk.Shop.Application.Models.RequestModels;
using FluentValidation;

namespace AhlatciKuyumculuk.Shop.Application.Validators.Categories
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryVM>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .WithMessage("Kategori adı boş olamaz.")
                .MaximumLength(100)
                .WithMessage("Kategori adı 100 karakterden fazla olamaz.");
        }
    }
}
