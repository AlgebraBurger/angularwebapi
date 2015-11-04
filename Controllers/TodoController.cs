using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularJs.Controllers
{
    public class Todo
    {
        public string action { get; set; }
        public bool done { get; set; }
    }

    [EnableCors(origins: "http://angularjs.localhost:8088", headers: "*", methods: "*")]
    public class TodoController : ApiController
    {
        public IEnumerable<Todo> Get()
        {
            var todoList = new List<Todo>
            {
                new Todo { action="Go Biking" , done= true },
                new Todo { action="Go Swimming" , done= true },
                new Todo { action="Go Eating" , done= true },
                new Todo { action="Go Cooking" , done= true },

            };
            return todoList.ToList();
        }
    }
}
