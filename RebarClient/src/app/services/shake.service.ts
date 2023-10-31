import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Shakes } from '../model/shake';

@Injectable({
  providedIn: 'root',
})
export class ShakeService {
  private baseUrl = 'http://localhost:5179/api/Shake';
  shakesList: Shakes[] = [];
  Url:string="http://localhost:5179/api/Shake";
  constructor(private http: HttpClient) {}

  getAllShakes(): Observable<Shakes[]> {
    return this.http.get<Shakes[]>(this.baseUrl);
  }

  getShakeById(id: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }


  createShake(shake: any): Observable<any> {
    console.log(shake);
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' })};
    return this.http.post(this.baseUrl,shake,httpOptions);
    //return this.http.post(`${this.baseUrl}`, shake, httpOptions);
  }
}
