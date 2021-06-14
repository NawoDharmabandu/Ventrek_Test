import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './component/login/login.component';
import { TaskDetailsComponent } from './component/task-details/task-details.component';
import { AuthGuard } from './shared/auth.guard';
import { CreateTaskComponent } from './component/create-task/create-task.component';

const routes: Routes = [
  {
    path:'',
    component:LoginComponent,
    pathMatch:'full'
  },
  { 
    path:'taskdetails',
    component:TaskDetailsComponent,
    pathMatch:'full',
    canActivate:[AuthGuard]

  },
  {
    path:'createtask',
    component:CreateTaskComponent,
    pathMatch:'full',
    canActivate:[AuthGuard]
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
