import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TaskM } from '../models/taskM.model';
import { AddTask } from '../models/add-task.model';
import { environment } from '../../../environments/environment';
import { UpdateTask } from '../models/update-task.model';

@Injectable({
  providedIn: 'root',
})
export class TaskService {
  constructor(private http: HttpClient) {}
  addTask(data: AddTask): Observable<TaskM> {
    return this.http.post<TaskM>(`${environment.apiBaseUrl}/api/TaskMs`, data);
  }

  getAllTask(): Observable<TaskM[]> {
    return this.http.get<TaskM[]>(`${environment.apiBaseUrl}/api/TaskMs`);
  }
  getTaskById(id: string): Observable<TaskM> {
    return this.http.get<TaskM>(`${environment.apiBaseUrl}/api/TaskMs/${id}`);
  }
  updateTask(id: string, updateTask: UpdateTask): Observable<TaskM> {
    return this.http.put<TaskM>(
      `${environment.apiBaseUrl}/api/TaskMs/${id}`,
      updateTask
    );
  }
  deleteTask(id: string): Observable<TaskM> {
    return this.http.delete<TaskM>(
      `${environment.apiBaseUrl}/api/TaskMs/${id}`
    );
  }
}
