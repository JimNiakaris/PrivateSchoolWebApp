import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { StudentsComponent } from './students/students.component';
import { PrivateSchoolApiService } from './private-school-api.service';
import { ReadAllStudentsComponent } from './students/read-all-students/read-all-students.component';
import { AddEditStudentComponent } from './students/add-edit-student/add-edit-student.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentsComponent,
    ReadAllStudentsComponent,
    AddEditStudentComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule, ReactiveFormsModule
  ],
  providers: [PrivateSchoolApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
