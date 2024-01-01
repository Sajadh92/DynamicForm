namespace DynamicForm;

public class Field : Base
{
    public required DataType DataType { get; set; }
    public required DisplayType DisplayType { get; set; }
    public DynamicOption? DynamicOptions { get; set; }
    public List<StaticOption>? StaticOptions { get; set; }
    public List<Validation>? Validations { get; set; }
}
