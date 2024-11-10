import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent implements OnInit {
  headerData:any;

  constructor (private apiService:ApiService){}
  
  ngOnInit() {
    this.getHeader();
  }

  getHeader(){
    this.apiService.Getabout().subscribe({
      next:(data) => this.headerData=data,
      error:(err) =>  console.error('Error fetching about data', err)
    })
  }

}
