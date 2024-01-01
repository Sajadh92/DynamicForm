namespace DynamicForm;

public class HttpResponse
{
    public required string KeyProperty { get; set; }
    public required List<string> LabelProperties { get; set; }
    public required string LabelFormat { get; set; }
}
