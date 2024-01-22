import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TaskListComponent } from './features/TaskM/task-list/task-list.component';
import { AddTaskComponent } from './features/TaskM/add-task/add-task.component';
import { EditTaskComponent } from './features/TaskM/edit-task/edit-task.component';
import { HomeComponent } from './features/public/home/home.component';

const routes: Routes = [
  {
    path:'admin/tasks',
    component:TaskListComponent
  },
  {
    path:'admin/tasks/add',
    component:AddTaskComponent
  },
  {
    path:'admin/tasks/:id',
    component:EditTaskComponent
  },
  {
    path:'',
    component:HomeComponent
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
