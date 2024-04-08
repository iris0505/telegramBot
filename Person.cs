using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Domain.Primitives;
using Domain.ValueObject;

namespace Domain.Entities;

public class Person : BaseEntity {
    public FullName FullName { get; private set; }
    public DateTime Birthday { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Telegram { get; private set; }
    public List<CustomField<string>> CustomFields { get; set; }
    //TODO: Перенести на FluentValidator
    public Gender Gender { get; private set; }

    public int Age {
        get => DateTime.Now.Year - Birthday.Year;
    }

    public Person(FullName fullName, DateTime birthday, Gender gender, string phoneNumber, string telegram) {
        PhoneNumber = phoneNumber;
        Telegram = telegram;
        this.FullName = ValidateFullName(fullName);
    }

    //TODO: Валидация остальных полей
    private FullName ValidateFullName(FullName fullName) {
        return fullName;
        // Не больше 20 символов
        // Не может иметь цифры
        // ОТчества может не быть, НО если есть, валидируем и его
    }
    private DateTime ValidateBirthDay(DateTime birthday)
    {
        if (birthday > DateTime.Now || birthday < DateTime.Now.AddYears(-150)) ;
        {
            throw new ValidationException(message: ValidationMessages.InvalidProperty(birthday));
        }
    }
}