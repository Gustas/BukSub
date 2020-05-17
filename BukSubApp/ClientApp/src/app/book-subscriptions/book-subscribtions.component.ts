import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-book-subscriptions-component',
  templateUrl: './book-subscriptions.component.html'
})
export class BookSubscriptionsComponent {
  public bookSubscriptionItems: BookSubscriptionItem[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<BookSubscriptionItem[]>(baseUrl + 'api/Books').subscribe(result => {
      this.bookSubscriptionItems = result;
    }, error => console.error(error));
  }

  public subscribeToBook(bookId: string) {
    console.log("subscribe to book: " + bookId);
  }
}

interface BookSubscriptionItem {
  bookId: string;
  name: string;
  subscribedToBook: boolean;
}
