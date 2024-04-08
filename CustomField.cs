namespace Domain.Entities
{
    public class CustomField<TValue> : BaseEntity
    {
        public CustomField()
        {
            //TODO: Провалидировать
        }
        public string Name { get; set; }
        public TValue Value { get; set; }

    }
}
