export class Product {
    public id: string;
    public name: string; 
    public created: Date;
    public modified: string;
    public active: boolean;
    public quantity: number;
    public cost: number;
    public productCodeId: string;
    public productCodeName: string;
    public description : string;
    public image : string;
    constructor(id: string, name: string, created: Date, modified: string, active: boolean, quantity: number, cost: number, productCodeId: string, productCodeName: string,description:string,image : string) {
        this.id = id;
        this.name = name;
        this.created = created;
        this.modified = modified;
        this.active = active;
        this.quantity = quantity;
        this.cost = cost;
        this.productCodeId = productCodeId;
        this.productCodeName = productCodeName;
        this.description = description;
        this.image = image;
    }
}
