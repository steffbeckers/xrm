using XRM.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace XRM.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
