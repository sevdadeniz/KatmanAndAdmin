using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _category = new CategoryManager();
        Category _singleCategory;
        public IActionResult Index()
        {
            var _categories = _category.List();
            return View(_categories);
        }
        [HttpGet]
        public IActionResult Add()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                _category.Add(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            _singleCategory = _category.GetById(id);
            return View(_singleCategory);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {

            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {

                _category.Update(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            _singleCategory = _category.GetById(id);
            _category.Delete(_singleCategory);
            return RedirectToAction("Index");
        }
    }
}
