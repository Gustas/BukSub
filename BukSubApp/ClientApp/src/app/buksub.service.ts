import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BuksubService {
  
  constructor(
    private http: HttpClient
  ) { }

  getBooks() {
    return this.http.get<BookSubscriptionItem[]>('/api/Books');
  }

  subscribeToBook(bookId: string) {
    
  }

  subscribeFromBook(bookId: string) {

  }

  getBook(bookId: string) {
    return this.http.get<BookItem>('/api/Books/' + bookId);    
  }
}

interface BookSubscriptionItem {
  bookId: string;
  name: string;
  price: number;
  subscribedToBook: boolean;
}

interface BookItem {
  bookId: string;
  name: string;
  text: string;
}

