using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public class HomeController : Controller
    {
        private TodoContext context;

        public HomeController(TodoContext context) => this.context = context;

        public IActionResult Index()
        {
            var todoList = context.Todos.ToList();

            return View(todoList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var todo = new TodoItem { Completed = false };
            return View(todo);
        }

        [HttpPost]
        public IActionResult Add(TodoItem todo)
        {
            if (ModelState.IsValid)
            {
                context.Todos.Add(todo);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(todo);
            }
        }

        [HttpPost]
        public IActionResult Complete(TodoItem todo) 
        {
            todo = context.Todos.Find(todo.Id)!;

            if (todo != null)
            {
                todo.Completed = true;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(TodoItem todo)
        {
            todo = context.Todos.Find(todo.Id)!;

            if (todo != null)
            {
                context.Todos.Remove(todo);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
