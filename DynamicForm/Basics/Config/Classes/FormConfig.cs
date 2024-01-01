namespace DynamicForm;

public class FormConfig
{
    public bool IsRepeatable { get; set; }
    public int? DefaultRepeatCount { get; set; }
    public int? MinimumRepeatCount { get; set; }
    public int? MaximumRepeatCount { get; set; }
}
