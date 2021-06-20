using FluentValidation;

namespace HealthLoggerAPI.Models.Request
{
    public class TestMasterViewModelRequest
    {
        public string TestName { get; set; }
    }

    public class TestMasterViewModelValidator : AbstractValidator<TestMasterViewModelRequest>
    {
        public TestMasterViewModelValidator()
        {
            RuleFor(x => x.TestName).NotEmpty().WithMessage("Test Name is mandatory.");
            RuleFor(x => x.TestName).Length(5, 15).WithMessage("Test Name should be between 5 and 15 chracters.");
        }
    }
}
