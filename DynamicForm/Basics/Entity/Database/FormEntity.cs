namespace DynamicForm;

internal class FormEntity<UserIdType>
{
    public required Form From { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required UserIdType CreatedBy { get; set; }
    public DateTime? LastUpdatedAt { get; set; }
    public UserIdType? LastUpdatedBy { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? LastDeletedAt { get; set; }
    public UserIdType? LastDeletedBy { get; set; }
    public DateTime? LastRestoredAt { get; set; }
    public UserIdType? LastRestoredBy { get; set; }
}
