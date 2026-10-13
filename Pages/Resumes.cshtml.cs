using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetWebApp.Models;

namespace aspnetWebApp.Pages;

public class ResumesModel : PageModel
{
    public List<Student> Students { get; set; } = new();
    public void OnGet()
    {
        Students = CreateResumeModel.Students;
    }
}