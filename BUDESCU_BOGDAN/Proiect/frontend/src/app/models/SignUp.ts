export class SignUp {
    public UserName: string;
    public Password: string;
    public ConfirmPassword: string;
    public AcceptTermsAndPrivacy: boolean = false;
    public Role: string = "CUSTOMER";
    constructor(UserName: string, Password: string, ConfirmPassword: string) {
        this.UserName = UserName;
        this.Password = Password;
        this.ConfirmPassword = ConfirmPassword;
    }
}