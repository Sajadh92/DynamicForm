namespace DynamicForm;

public class Base
{
    public required Guid Id { get; set; }
    public required int Sort { get; set; }
    public required string Name { get; set; }
    public Style? Style { get; set; }
}