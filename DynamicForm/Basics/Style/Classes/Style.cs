namespace DynamicForm;

public class Style
{
    public List<string>? Classes { get; set; }
    public List<FlagType>? Flags { get; set; }
    public List<BootstrapColumn>? BootstrapColumns { get; set; }
    public List<TextInformation>? TextInformations { get; set; }
    public List<KeyValuePair<string, string>>? Styles { get; set; }
    public List<KeyValuePair<string, string>>? Attributes { get; set; }
    public List<KeyValuePair<string, string>>? DataAttributes { get; set; }
    public List<KeyValuePair<string, string>>? AriaAttributes { get; set; }
}
