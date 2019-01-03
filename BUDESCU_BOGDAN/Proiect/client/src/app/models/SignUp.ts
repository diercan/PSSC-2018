export class SignUp {
    public FirstName: string;
    public LastName: string;
    public Email: string;
    public Password: string;
    public ConfirmPassword: string;
    public AcceptTermsAndPrivacy: boolean = false;
    public Role: string = "FURNIZOR";
    constructor(FirstName: string, LastName: string, Email: string, Password: string, ConfirmPassword: string) {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.Password = Password;
        this.ConfirmPassword = ConfirmPassword;
    }
}