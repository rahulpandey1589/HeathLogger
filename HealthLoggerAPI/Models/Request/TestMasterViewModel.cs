using FluentValidation;

namespace HealthLoggerAPI.Models.Request
{
    public class TestMasterViewModel
    {
        public string TestName { get; set; }
    }

    public class TestMasterViewModelValidator : AbstractValidator<TestMasterViewModel>
    {
        public TestMasterViewModelValidator()
        {
            RuleFor(x => x.TestName).NotEmpty().WithMessage("Test Name is mandatory.");
        }
    }
}
