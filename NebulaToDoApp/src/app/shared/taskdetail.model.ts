import { getLocaleDateTimeFormat } from "@angular/common";

export class TaskDetail {
    taskID:string='';
    taskName:string='';
    dueDate:Date;
    description:string;
    completedDate:Date;
    enteredDate:Date;
    creator:string;
}
