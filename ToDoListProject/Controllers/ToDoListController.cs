using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ToDoListProject.Models;

public class ToDoListController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SubmitName(ToDoListModel model)
    {
        //Reading
        string readModels = System.IO.File.ReadAllText("ToDoList.json");
        List<ToDoListModel> receivedModels = JsonConvert.DeserializeObject<List<ToDoListModel>>(readModels);
        if (receivedModels == null)
        {
            receivedModels = new();
        }

        //Updating File
        receivedModels.Add(model);
        //Saving updates
        string jsonModels = JsonConvert.SerializeObject(receivedModels);

        System.IO.File.WriteAllText("ToDoList.json", jsonModels);
        return View("ToDoListDisplay", receivedModels);
    }
}