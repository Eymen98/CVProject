import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-experience',
  templateUrl: './experience.component.html',
  styleUrl: './experience.component.css'
})
export class ExperienceComponent implements OnInit {
  experinceData:any;

  constructor(private apiService:ApiService){};

  ngOnInit() {
    this.GetExperince();
  }

  GetExperince(){
    this.apiService.Getexperince().subscribe({
      next:(data) => this.experinceData=data,
      error:(err) => console.error('Error fetching about data', err)
      
    })
  }

}
