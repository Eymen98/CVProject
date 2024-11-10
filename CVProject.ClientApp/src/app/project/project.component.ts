import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrl: './project.component.css'
})
export class ProjectComponent implements OnInit {
  projectData:any;
  
  constructor(private apiService:ApiService){}
  
  ngOnInit() {
    this.GetProjcet();
  }

  GetProjcet(){
    return this.apiService.Getproject().subscribe({
      next:(data) => this.projectData=data,
      error:(err) => console.error('Error fetching about data', err)
    })
  }

}
