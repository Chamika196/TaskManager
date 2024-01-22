import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AddTask } from '../models/add-task.model';
import { TaskService } from '../services/task.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {
  taskForm!: FormGroup; // Declare FormGroup for managing form controls

  constructor(
    private formBuilder: FormBuilder, // FormBuilder service for building forms
    private taskService: TaskService, // TaskService for handling task-related operations
    private router: Router // Router service for navigating between components
  ) {
    this.taskForm = this.formBuilder.group({}); // Initialize an empty form group
  }

  ngOnInit() {
    // Initialize the taskForm with form controls and validators
    this.taskForm = this.formBuilder.group({
      
      title: ['', Validators.required], // Title with required validator
      description: '', // Description without validators
      dueDate: [new Date()] // DueDate with default value set to current date
    });
  }

  onSubmit() {
    // Extract task data from the form
    const taskData: AddTask = this.taskForm.value;

    // Call the task service to add a new task
    this.taskService.addTask(taskData).subscribe({
      next: (response) => {
        // Navigate to the task list after successful submission
        this.router.navigateByUrl('/admin/tasks');
      }
    });
  }
}
