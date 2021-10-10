using CleanDotnet.Application.Common.Mappings;
using CleanDotnet.Domain.Entities;

namespace CleanDotnet.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
