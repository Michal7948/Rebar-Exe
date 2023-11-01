import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { dailyReport } from '../model/dailyReport';
import { Shakes } from '../model/shake';

@Injectable({
  providedIn: 'root'
})
export class DailyReportService {

  private baseUrl = 'http://localhost:5179/api/DailyReport';
  dailyReportList: dailyReport[] = [];
  
  constructor(private http: HttpClient) {}

  getAllDailyReport(): Observable<dailyReport[]> {
    return this.http.get<dailyReport[]>(this.baseUrl);
  }

  getDailyReportById(id: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/${id}`);
  }


  createDailyReport(dailyReport: any): Observable<any> {
    console.log(dailyReport);
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' })};
    return this.http.post(this.baseUrl,dailyReport,httpOptions);
  }
}
