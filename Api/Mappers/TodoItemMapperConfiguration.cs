using Bit.TodoTemplatePlayground.Api.Models.TodoItem;
using Bit.TodoTemplatePlayground.Shared.Dtos.TodoItem;

namespace Bit.TodoTemplatePlayground.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
