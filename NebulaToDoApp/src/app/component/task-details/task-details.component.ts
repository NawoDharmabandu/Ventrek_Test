import { LocalizedString } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { AuthGuard } from 'src/app/shared/auth.guard';
import { LoginService } from 'src/app/shared/login.service';
import { TaskDetail } from 'src/app/shared/taskdetail.model';
import { TaskDetailService } from 'src/app/shared/taskdetail.service';


@Component({
  selector: 'app-task-details',
  templateUrl: './task-details.component.html',
  styleUrls: ['./task-details.component.css']
})
export class TaskDetailsComponent implements OnInit {

  userID: any;

  constructor(public taskService:TaskDetailService,public loginAuth:LoginService) { }

  ngOnInit(): void {  
    this.userID = this.taskService.getCurrentUser() !== null ? this.taskService.getCurrentUser() : '';

  }

  

  onDeleteClick()
  {

  }

  

}
