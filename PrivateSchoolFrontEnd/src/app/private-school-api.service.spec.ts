import { TestBed } from '@angular/core/testing';

import { PrivateSchoolApiService } from './private-school-api.service';

describe('PrivateSchoolApiService', () => {
  let service: PrivateSchoolApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PrivateSchoolApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
