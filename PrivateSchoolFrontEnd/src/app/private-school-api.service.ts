import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PrivateSchoolApiService {

  private readonly privateSchoolAPIUrl = "https://localhost:7184/api";

  constructor(private http: HttpClient) { }

  getStudentList(): Observable<any[]> {
    return this.http.get<any>(this.privateSchoolAPIUrl + '/Students');
  }

  getStudent(id: number | string): Observable<any> {
    return this.http.get<any>(this.privateSchoolAPIUrl + `/Students${id}`);
  }

  addStudent(data: any) {
    return this.http.post(this.privateSchoolAPIUrl + '/Students', data);
  }

  updateStudent(id: number | string, data: any) {
    return this.http.put(this.privateSchoolAPIUrl + `/Students${id}`, data);
  }

  deleteStudent(id: number | string) {
    return this.http.delete(this.privateSchoolAPIUrl + `Students${id}`);
  }
}
