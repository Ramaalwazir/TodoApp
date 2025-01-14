using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    /// <summary>
    /// Hantera logiken för att lägga till, ta bort och visa todo-items.
    /// </summary>
    public class todolist
    {
private List <string> tasks = new List <string> ();

    public void AddTask(string task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(int index) 
        {
            if (index >= 0 && index < tasks.Count)
            

            tasks.RemoveAt(index);
        }
        
       public List <string> GetAllTask ()
        {
         return tasks;
        }
    }
}


