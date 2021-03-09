using XRM.Application.Common.Mappings;
using XRM.Domain.Entities;

namespace XRM.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
