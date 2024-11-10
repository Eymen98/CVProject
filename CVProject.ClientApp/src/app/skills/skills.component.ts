import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrl: './skills.component.css'
})
export class SkillsComponent implements OnInit {
  
  skillData:any
  languageData:any
  
  constructor (private apiService:ApiService){}

  ngOnInit() {
    this.GetSkill();
    this.GetLanguage();
  }

  GetSkill(){
    return this.apiService.Getskill().subscribe({
      next:(data) => this.skillData=data,
      error:(err) => console.error('Error fetching about data', err)
    })
  }

  GetLanguage(){
    return this.apiService.Getlanguage().subscribe({
      next:(data) => this.languageData=data,
      error:(err) => console.error('Error fetching about data', err)
    })
  }

}
