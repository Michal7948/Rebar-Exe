import { Component } from '@angular/core';
import { dailyReport } from '../model/dailyReport';
import { DailyReportService } from '../services/daily-report.service';

@Component({
  selector: 'app-daily-report',
  templateUrl: './daily-report.component.html',
  styleUrls: ['./daily-report.component.css']
})
export class DailyReportComponent {
  dailyReportsList:dailyReport[]=[];
  
  constructor(private dailyReport:DailyReportService){
    this.dailyReport.getAllDailyReport().subscribe((daily:dailyReport[])=>{
    this.dailyReportsList=daily;})
  }


}
