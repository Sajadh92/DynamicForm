namespace DynamicForm;

public class HttpRequest
{
    public required string Url { get; set; }
    public required string Method { get; set; }
    public List<KeyValuePair<string, object>>? Headers { get; set; }
    public List<KeyValuePair<string, object>>? QueryParameters { get; set; }
    public List<KeyValuePair<string, object>>? BodyParameters { get; set; }
}
