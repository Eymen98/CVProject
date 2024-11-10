import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ApiService {
  
  
  
  private baseUrl= 'http://localhost:4201/api';

  private username = 'eymen';
  private password = 'Cv0Project@!';

  constructor(private http:HttpClient) { }

  private createAuthHeader(): HttpHeaders {
    const credentials = btoa(`${this.username}:${this.password}`);
    return new HttpHeaders({
      'Authorization': `Basic ${credentials}`
    });
  }


  Getabout():Observable<any>{
    const headers = this.createAuthHeader();
    return this.http.get<any>(`${this.baseUrl}/Person/getpersoninformations?userId=1`,{headers});
  }

  Getexperince():Observable<any>{
    const headers = this.createAuthHeader();
    return this.http.get<any>(`${this.baseUrl}/PersonDetails/getpersonexperience?userId=1`,{headers});
  }

  Geteducation():Observable<any>{
    const headers = this.createAuthHeader();
    return this.http.get<any>(`${this.baseUrl}/PersonDetails/getpersoneducation?userId=1`,{headers});
  }

  Getproject():Observable<any>{
    const headers = this.createAuthHeader();
    return this.http.get<any>(`${this.baseUrl}/PersonDetails/getpersonproject?userId=1`,{headers})
  }

  Getskill():Observable<any>{
    const headers = this.createAuthHeader();
    return this.http.get<any>(`${this.baseUrl}/PersonDetails/getpersonskill?userId=1`,{headers});
  }

  Getlanguage():Observable<any>{
    const headers = this.createAuthHeader();
    return this.http.get<any>(`${this.baseUrl}/PersonDetails/getpersonlanguages?userId=1`,{headers})
  }

}
