import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TaskM } from '../models/taskM.model';
import { TaskService } from '../services/task.service';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrl: './task-list.component.css',
})
export class TaskListComponent implements OnInit {
  taskM$?: Observable<TaskM[]>;
  constructor(private taskService: TaskService) {}
  ngOnInit(): void {
    //get all blog posts from API

    this.taskM$ = this.taskService.getAllTask();
    console.log(this.taskM$);
  }
}
