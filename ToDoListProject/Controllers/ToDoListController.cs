using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ToDoListProject.Models;

public class ToDoListController : Controller
{
    public IActionResult Index()
    {

        string readModels = System.IO.File.ReadAllText("ToDoList.json");
        List<ToDoListModel> receivedModels = JsonConvert.DeserializeObject<List<ToDoListModel>>(readModels);
        if (receivedModels == null)
        {
            receivedModels = new();
        }

        return View(receivedModels);
    }
    //GET
    public IActionResult Create()
    {
        return View();
    }

    //POST
    [HttpPost]
    public IActionResult Create(ToDoListModel model)
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

        //return View("Index", receivedModels);
        return RedirectToAction("Index");
    }
}