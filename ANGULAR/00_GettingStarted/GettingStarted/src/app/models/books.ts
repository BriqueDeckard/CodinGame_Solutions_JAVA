import { Category } from "./category";

export class Book {
    id: number | undefined;
    title: string | undefined;
    isbn: string | undefined;
    releaseDate: Date | undefined;
    registerDate: Date | undefined;
    totalExamplaries: number | undefined;
    author: string | undefined;
    category: Category | undefined;
    cols:number| undefined;
    rows:number| undefined;
    color:string|undefined;
}