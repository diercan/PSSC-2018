export class SignIn {
    public UserName: string;
    public Password: string;
    constructor(UserName: string, password: string) {
        this.UserName = UserName;
        this.Password = password;
    }
}