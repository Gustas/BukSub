import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BuksubService } from '../buksub.service';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  book;

  constructor(
    private route: ActivatedRoute,
    private buksubService: BuksubService
  ) { }

  ngOnInit() {
    this.route.paramMap.subscribe(async params => {
      this.book = await this.buksubService.getBook(params.get('bookId')).toPromise();
    });
  }
}
