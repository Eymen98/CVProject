import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})

export class FooterComponent implements OnInit{
  footerData:any;

  constructor(private apiService:ApiService) {}

  ngOnInit() {
    this.scorllTotop();
    this.getFooter();
  }

  scorllTotop(){
    window.scrollTo({
      top:0,behavior:'smooth'
    });
  }

  getFooter(){
    this.apiService.Getabout().subscribe({
      next:(data) => this.footerData=data,
      error:(err) =>  console.error('Error fetching about data', err)
    })
  }
    
}
