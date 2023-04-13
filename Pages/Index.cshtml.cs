using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebFormValidationTest.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebFormValidationTest.Pages;

public class IndexModel : PageModel
{
    // Modelを入力項目とマッチさせるにはBindPropertyが必要！
    [BindProperty]
    public InputValue FormValue { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger) {
        _logger = logger;
        FormValue = new();
    }

    public void OnGet() {
    }
    public IActionResult OnPost() {
        if (!TryValidateModel(FormValue)) {
            FormValue.Message = "不正な入力があります";
            return Page();
        }
        return Page();
    }
}
public class InputValue {
    public Person Person { get; set; } = null!;
    // 検証の対象としない!
    [ValidateNever]
    public string Message { get; set; } = null!;
    public InputValue() {
        Person = new();
    }
}
