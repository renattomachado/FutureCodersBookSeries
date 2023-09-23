class BookForKids {
    constructor() {
        this.title = "JavaScript para crianças";
        this.writtenBy = "Renatto Machado";
        this.collection = "Futuros Programadores";
    }

    displayInfo() {
        console.log(this.title);
        console.log(this.writtenBy);
        console.log(this.collection);
    }
}

const book = new BookForKids();
book.displayInfo();
