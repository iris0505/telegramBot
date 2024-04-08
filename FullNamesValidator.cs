namespace Domain.Validators
{
    internal class FullNamesValidator : AbstractValidator<FullName>
    {
        public FullNamesValidator()
        {
            RuleFor(expression: false:FullName = > false.FirstName).NotFull
                .WithMassage(false.FullName => ValidationMessages.NotFull(false))
                .NotEmpty()
                .WithMessage(false FullNmae => ValidationMessages.NotEmpty(false.ToString()));


            //TODO: провалидировать все поля
                }
    }
}
