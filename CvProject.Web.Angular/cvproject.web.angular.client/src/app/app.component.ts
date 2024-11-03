import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
interface Person {
  Name: string;
  SurName: string;
  JobTitle: string;
  Email: string;
  PhoneNumber: string;
  Address: string;
  DrivingLicense: string;
  MaritalStatus: Int8Array;
  WebsiteUrl: string;
  LinkedInProfile: string;
  GithubProfile: string;
  Summary: string;
  ImageUrl: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  //public forecasts: WeatherForecast[] = [];
  public personInfo: Person[]=[];
  constructor(private http: HttpClient) {}

  ngOnInit() {
    //this.getForecasts();
    this.getPersonInfo();
  }

  getForecasts() {
    this.http.get<WeatherForecast[]>('/weatherforecast/GetWeatherForecast333').subscribe(
      (result) => {
        //this.forecasts = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  getPersonInfo() {
    this.http.get<Person[]>('/Person/GetPersonInformations').subscribe(
      (result) => {
        this.personInfo = result;
      },
      (error) => {
        console.error(error);
      })
  }

  title = 'cvproject.web.angular.client';
}
