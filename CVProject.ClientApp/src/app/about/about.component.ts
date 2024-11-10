import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export class AboutComponent implements OnInit {
  
  aboutData:any;

  constructor (private apiService:ApiService){};

  ngOnInit() {
    this.getAbout();
  }
  

  getAbout(){
    this.apiService.Getabout().subscribe({
      next:(data) => this.aboutData=data,
      error:(err) =>  console.error('Error fetching about data', err)
    })
  }

}
