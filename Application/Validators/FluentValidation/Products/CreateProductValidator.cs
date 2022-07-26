using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ViewModels.Products;
using FluentValidation;

namespace Application.Validators.FluentValidation.Products
{
    public class CreateProductValidator : AbstractValidator<VM_CreateProduct>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product Name should not be empty")
                .MaximumLength(50)
                .MinimumLength(3)
                    .WithMessage("Please enter Product Name character between 3 - 50");
            
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product Stock should not be empty")
                .Must(s => s >= 0)
                    .WithMessage("Stock value can not be negative");
            
            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product Price should not be empty")
                .Must(pr => pr >= 0)
                    .WithMessage("Price value can not be negative");
        }
    }
}