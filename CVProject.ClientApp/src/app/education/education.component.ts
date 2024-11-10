import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrl: './education.component.css'
})
export class EducationComponent implements OnInit {
  educationData:any;

  constructor(private apiService:ApiService) {}
  
  ngOnInit() {
    this.GetEducation();
  }

  GetEducation(){
    this.apiService.Geteducation().subscribe({
      next:(data) => this.educationData=data,
      error:(err) => console.error('Error fetching about data', err)
    })
  }

}
