namespace DynamicForm;

public class Validation
{
    public required ValidationType Type { get; set; }
    public required object Value { get; set; }
    public required string Message { get; set; }
}
