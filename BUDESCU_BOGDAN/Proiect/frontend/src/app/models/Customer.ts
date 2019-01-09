export class Customer {
    public id: string;
    public firstName: string;
    public lastName: string;
    public email: string;
    public countryId: string;
    public userName: string;
    public password: string;
    public street: string;
    public zipCode: string;
    public city: string;
    public image: string;
    public user : {
        username: string,
        password:string,
    }
    constructor(id: string, firstName: string, lastName: string, email: string, countryId: string, userName: string, password: string, street: string, zipCode: string, city: string, image: string) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.countryId = countryId;
        this.userName = userName;
        this.password = password;
        this.street = street;
        this.zipCode = zipCode;
        this.city = city;
        this.image = image;
    }
}
