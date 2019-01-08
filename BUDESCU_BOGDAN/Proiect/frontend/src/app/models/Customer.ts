export class Customer {
    public id: string;
    public firstName: string;
    public lastName: string;
    public email: string;
    public countryId: string;
    constructor(id: string, firstName: string, lastName: string, email: string, countryId: string) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.countryId = countryId;
    }
}
