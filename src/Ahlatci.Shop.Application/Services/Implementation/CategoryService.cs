﻿using AhlatciKuyumculuk.Shop.Application.Behaviors;
using AhlatciKuyumculuk.Shop.Application.Exceptions;
using AhlatciKuyumculuk.Shop.Application.Models.Dtos;
using AhlatciKuyumculuk.Shop.Application.Models.RequestModels;
using AhlatciKuyumculuk.Shop.Application.Services.Abstraction;
using AhlatciKuyumculuk.Shop.Application.Validators.Categories;
using AhlatciKuyumculuk.Shop.Application.Wrapper;
using AhlatciKuyumculuk.Shop.Domain.Entities;
using AhlatciKuyumculuk.Shop.Domain.UWork;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AhlatciKuyumculuk.Shop.Application.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitWork _db;

        public CategoryService(IMapper mapper, IUnitWork db)
        {
            _mapper = mapper;
            _db = db;
        }

        [PerformanceBehavior]
        public async Task<Result<List<CategoryDto>>> GetAllCategories()
        {
            var result = new Result<List<CategoryDto>>();

            var categoryEntites = await _db.GetRepository<Category>().GetAllAsync();
            //categoryEntites = categoryEntites.Where(x => x.Id > 4);
            var categoryDtos = await categoryEntites.ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();           
            //var categoryDtos = _mapper.Map<List<Category>, List<CategoryDto>>(categoryEntites);
            result.Data = categoryDtos;
            _db.Dispose();
            return result;
        }


        [ValidationBehavior(typeof(GetCategoryByIdValidator))]
        public async Task<Result<CategoryDto>> GetCategoryById(GetCategoryByIdVM getCategoryByIdVM)
        {
            var result = new Result<CategoryDto>();

            //var categoryExists = await _context.Categories.AnyAsync(x=>x.Id == getCategoryByIdVM.Id);
            var categoryExists = await _db.GetRepository<Category>().AnyAsync(x => x.Id == getCategoryByIdVM.Id);
            if (!categoryExists)
            {
                throw new NotFoundException($"{getCategoryByIdVM.Id} numaralı kategori bulunamadı.");
            }

            var categoryEntity = await _db.GetRepository<Category>().GetById(getCategoryByIdVM.Id);

            var categoryDto = _mapper.Map<Category, CategoryDto>(categoryEntity);

            result.Data = categoryDto;
            _db.Dispose();
            return result;
        }


        [ValidationBehavior(typeof(CreateCategoryValidator))]
        public async Task<Result<int>> CreateCategory(CreateCategoryVM createCategoryVM)
        {
            var result = new Result<int>();

            var categoryEntity = _mapper.Map<CreateCategoryVM, Category>(createCategoryVM);

            _db.GetRepository<Category>().Add(categoryEntity);
            await _db.CommitAsync();

            result.Data = categoryEntity.Id;
            _db.Dispose();
            return result;
        }


        [ValidationBehavior(typeof(DeleteCategoryValidator))]
        public async Task<Result<int>> DeleteCategory(DeleteCategoryVM deleteCategoryVM)
        {
            var result = new Result<int>();

            var categoryExists = await _db.GetRepository<Category>().AnyAsync(x => x.Id == deleteCategoryVM.Id);
            if (!categoryExists)
            {
                throw new NotFoundException($"{deleteCategoryVM.Id} numaralı kategori bulunamadı.");
            }

            _db.GetRepository<Category>().Delete(deleteCategoryVM.Id);
            await _db.CommitAsync();

            result.Data = deleteCategoryVM.Id;
            _db.Dispose();
            return result;
        }


        [ValidationBehavior(typeof(UpdateCategoryValidator))]
        public async Task<Result<int>> UpdateCategory(UpdateCategoryVM updateCategoryVM)
        {
            var result = new Result<int>();

            var existsCategory = await _db.GetRepository<Category>().GetById(updateCategoryVM.Id);
            if (existsCategory is null)
            {
                throw new Exception($"{updateCategoryVM} numaralı kategori bulunamadı.");
            }

            //var updateCategory = _mapper.Map<UpdateCategoryVM,Category>(updateCategoryVM);

            var updatedCategory = _mapper.Map(updateCategoryVM,existsCategory);

            _db.GetRepository<Category>().Update(updatedCategory);
            await _db.CommitAsync();

            result.Data = updatedCategory.Id;
            _db.Dispose();
            return result;
        }

    }
}
