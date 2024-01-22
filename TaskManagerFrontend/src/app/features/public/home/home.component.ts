import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TaskM } from '../../TaskM/models/taskM.model';
import { TaskService } from '../../TaskM/services/task.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  task$?: Observable<TaskM[]>;
  constructor(private taskService : TaskService){}
  ngOnInit(): void {
    this.task$ = this.taskService.getAllTask();
  }

}
