using AdvertisementApp.UI.Models;
using FluentValidation;

namespace AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        //[System.Obsolete]
        public UserCreateModelValidator()
        {
            //CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x=>x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Username).MinimumLength(3);
            RuleFor(x=>x.Username).NotEmpty();
            RuleFor(x=>x.FirstName).NotEmpty();
            RuleFor(x => x.Username).MinimumLength(3);
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Password should match");
            RuleFor(x => new
            { 
                x.Username,x.FirstName
            }).Must(x=>CanNotFirstName(x.Username,x.FirstName)).WithMessage("username contains firstname!")
            .When(x=> x.Username!=null && x.FirstName!= null);
            RuleFor(x => x.GenderId).NotEmpty();
            RuleFor(x=>x.LastName).NotEmpty();
        }

        private bool CanNotFirstName(string username,string firstname) 
        {
            return !username.Contains(firstname);
        }
    }
}
