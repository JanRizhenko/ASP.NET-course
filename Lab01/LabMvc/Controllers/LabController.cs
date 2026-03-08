using Microsoft.AspNetCore.Mvc;

namespace LabMvc.Controllers;

public class LabInfo
{
    public string LabNumber { get; set; } = string.Empty;
    public string Topic { get; set; } = string.Empty;
    public string Goal { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
}

public class LabController : Controller
{
    public IActionResult Info()
    {
        var model = new LabInfo
        {
            LabNumber = "Лабораторна робота 1",
                Topic = "Вступ до ASP.NET Core",
                Goal = "Ознайомитися з основними принципами роботи .NET, навчитися налаштовувати середовище розробки та встановлювати необхідні компоненти, набути навичок створення рішень та проектів різних типів, набути навичок обробки запитів з використанням middleware",
                AuthorName = "Риженко Ян"
        };

        return View(model);
    }
}