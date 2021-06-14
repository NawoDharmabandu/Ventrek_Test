import { LocalizedString } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { TaskDetail } from 'src/app/shared/taskdetail.model';
import { TaskDetailService } from 'src/app/shared/taskdetail.service';

@Component({
  selector: 'app-create-task',
  templateUrl: './create-task.component.html',
  styleUrls: ['./create-task.component.css']
})
export class CreateTaskComponent implements OnInit {
  dataSaved = false;
  taskForm : any;
  message : string;


  constructor(public formBuilder:FormBuilder,public taskService:TaskDetailService) { }
  userID: any;

  ngOnInit(): void {
    this.userID = this.taskService.getCurrentUser() !== null ? this.taskService.getCurrentUser() : '';
  }

  createTask(task:TaskDetail)
  {
    this.taskService.createTask(task).subscribe(
      ()=>{
        this.dataSaved = true;
        this.message = 'Task Saved Successfully';
        this.taskForm.reset();
      },
      //err => {console.log(err)}
    )
  }

  onSubmit(form:NgForm)
  {
    this.dataSaved = false;
    const task = this.taskForm;
    this.createTask(task);
    this.taskForm.resetForm();
  }

  resetForm()
  {
    this.taskForm.reset();
    this.message = '';
    this.dataSaved = false;

  }

  // deleteTask(taskID : string){
  //   if(confirm("Are you sure want to delete this task?")){
  //     this.taskService.deleteTaskByID(taskID).subscribe(() => {
  //       this.dataSaved = true;  
  //       this.message = 'Task Deleted Successfully';
  //       this.taskForm.reset();
  //     }

  //     )
  //   }
  // }

}
