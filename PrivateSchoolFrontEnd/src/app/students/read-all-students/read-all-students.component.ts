import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PrivateSchoolApiService } from 'src/app/private-school-api.service';

@Component({
  selector: 'app-read-all-students',
  templateUrl: './read-all-students.component.html',
  styleUrls: ['./read-all-students.component.css']
})
export class ReadAllStudentsComponent implements OnInit {

  StudentsList$!: Observable<any[]>;

  constructor(private service: PrivateSchoolApiService) { }

  ngOnInit(): void {
    this.StudentsList$ = this.service.getStudentList();
  }

}
