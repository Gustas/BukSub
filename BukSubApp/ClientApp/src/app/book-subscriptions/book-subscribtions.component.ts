import { Component, Inject } from '@angular/core';
import { BuksubService } from '../buksub.service';

@Component({
  selector: 'app-book-subscriptions-component',
  templateUrl: './book-subscriptions.component.html'
})
export class BookSubscriptionsComponent {
  bookSubscriptionItems;

  constructor(
    private buksubService: BuksubService
  ) { }

  ngOnInit() {
    this.bookSubscriptionItems = this.buksubService.getBooks();
  }

  public subscribeToBook(bookId: string) {
    this.buksubService.subscribeToBook(bookId);
  }

  public unsubscribeFromBook(bookId: string) {
    this.buksubService.unsubscribeFromBook(bookId);
  }
}

