using CleanDotnet.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CleanDotnet.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
