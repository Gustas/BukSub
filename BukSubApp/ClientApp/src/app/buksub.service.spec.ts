import { TestBed } from '@angular/core/testing';

import { BuksubService } from './buksub.service';

describe('BuksubService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BuksubService = TestBed.get(BuksubService);
    expect(service).toBeTruthy();
  });
});
