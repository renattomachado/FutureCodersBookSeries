class BookForKids {
    constructor(title = "JavaScript para crianças",
        writtenBy = "Renatto Machado",
        collection = "Futuros Programadores") {
        this.title = title;
        this.writtenBy = writtenBy;
        this.collection = collection;
    }

    displayInfo() {
        console.log(`Título: ${this.title}`);
        console.log(`Escrito por: ${this.writtenBy}`);
        console.log(`Coleção: ${this.collection}`);
    }
}

const book = new BookForKids();
book.displayInfo();
