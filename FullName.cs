namespace Domain.ValueObject;

public class FullName : BaseValueObject {
    public FullName(string firstName, string lastName, string middleName) {
        var validator
    }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string MiddleName { get; set; }
}