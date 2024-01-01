namespace DynamicForm;

public class Form : Base
{
    public FormConfig? Config { get; set; }
    public List<Field>? Fields { get; set; }
    public List<Group>? Groups { get; set; }
    public List<Form>? SubForms { get; set; }
}
