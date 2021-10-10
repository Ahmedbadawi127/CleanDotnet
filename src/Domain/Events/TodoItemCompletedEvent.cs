using CleanDotnet.Domain.Common;
using CleanDotnet.Domain.Entities;

namespace CleanDotnet.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
