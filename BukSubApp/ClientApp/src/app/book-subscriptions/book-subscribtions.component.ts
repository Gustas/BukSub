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

  public async subscribeToBook(bookId: string) {
    await this.buksubService.subscribeToBook(bookId);
    this.bookSubscriptionItems = this.buksubService.getBooks();
  }

  public async unsubscribeFromBook(bookId: string) {
    await this.buksubService.unsubscribeFromBook(bookId);
    this.bookSubscriptionItems = this.buksubService.getBooks();
  }
}

