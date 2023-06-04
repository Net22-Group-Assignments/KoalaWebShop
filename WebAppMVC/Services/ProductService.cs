using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Services;

public class ProductService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public ProductService(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<ModifyProductViewModel> CreateModifyProductViewModel(int? id = null)
    {
        ModifyProductViewModel model;

        if (id is not null)
        {
            var entity = await _db.Products.FindAsync(id);
            await _db.Products.Entry(entity).Navigation(nameof(Category)).LoadAsync();
            model = _mapper.Map<ModifyProductViewModel>(entity);
        }
        else
        {
            model = new ModifyProductViewModel();
        }

        model.Categories = new SelectList(
            items: await _db.Categories.ToArrayAsync(),
            dataValueField: nameof(Category.Id),
            dataTextField: nameof(Category.Title)
        );

        return model;
    }
}
