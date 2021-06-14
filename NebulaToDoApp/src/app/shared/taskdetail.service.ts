import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TaskDetail } from './taskdetail.model';
import { LoginService } from './login.service';

@Injectable({
  providedIn: 'root'
})
export class TaskDetailService {

  url="http://localhost:46653/api/Task"
  constructor(private http:HttpClient,private taskServices:LoginService) { }

  formData:TaskDetail = new TaskDetail();
  taskList :TaskDetail[];
  
  getCurrentUser()
  {
    console.log(typeof localStorage.getItem("userID"));

    if(this.taskServices.isLoggedIn() == true && localStorage.getItem("userID"))
      {
        return localStorage.getItem("userID");
        // console.log(userID);
        
      }

    return null;
  }

  getCompletedTask(userID : string) : Observable<TaskDetail[]>
  {
    return this.http.get<TaskDetail[]>(this.url+'/CompletedTasks/');
  }

  getUnfinishedTask(userID : string) : Observable<TaskDetail[]>
  {
    return this.http.get<TaskDetail[]>(this.url+'/UnfinishedTasks/');
  }

  createTask(taskdetail:TaskDetail):Observable<TaskDetail>
  {
    const httpOptions = {headers:new HttpHeaders({'Content-Type':'application/json'})}
    return this.http.post<TaskDetail>(this.url+'/CreateTasks/',taskdetail,httpOptions);
  }

  updateCompletedTask(taskdetail:TaskDetail):Observable<TaskDetail>
  {
    const httpOptions = {headers:new HttpHeaders({'Content-Type':'application/json'})}
    return this.http.post<TaskDetail>(this.url+'/UpdateCompleted/',TaskDetail,httpOptions);
  }

  deleteTaskByID(taskdetail:TaskDetail):Observable<TaskDetail>
  {
    const httpOptions = {headers:new HttpHeaders({'Content-Type':'application/json'})}
    return this.http.post<TaskDetail>(this.url+'/UpdateCompleted/',TaskDetail,httpOptions);
  }

}
