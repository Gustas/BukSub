import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BuksubService {
  
  constructor(
    private http: HttpClient
  ) { }

  getBooks(): Observable<BookSubscriptionItem[]> {
    return this.http.get<BookSubscriptionItem[]>('/api/Books');
  }

  async subscribeToBook(bookId: string) {
    return await this.http.post('/api/Subscriptions/' + bookId, null).toPromise();
  }

  async unsubscribeFromBook(bookId: string) {
    console.log("unsubscribing");
    return await this.http.delete('/api/Subscriptions/' + bookId).toPromise();
  }

  getBook(bookId: string): Observable<BookItem> {
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

