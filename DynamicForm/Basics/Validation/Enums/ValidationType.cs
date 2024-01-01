namespace DynamicForm;

public enum ValidationType
{
    Regex,
    Required,

    MinimumDate,
    MaximumDate,

    MinimumTime,
    MaximumTime,

    MinimumDateTime,
    MaximumDateTime,

    MinimumNumber,
    MaximumNumber,

    MinimumTextLength,
    MaximumTextLength,

    MinimumSelectCount,
    MaximumSelectCount,

    MinimumImageWidth,
    MaximumImageWidth,

    MinimumImageHeight,
    MaximumImageHeight,

    MinimumFileSizeByte,
    MaximumFileSizeByte,
}