import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TaskM } from '../models/taskM.model';
import { ActivatedRoute, Router } from '@angular/router';
import { TaskService } from '../services/task.service';
import { UpdateTask } from '../models/update-task.model';

@Component({
  selector: 'app-edit-task',
  templateUrl: './edit-task.component.html',
  styleUrls: ['./edit-task.component.css'],
})
export class EditTaskComponent implements OnInit, OnDestroy {
  id: string | null = null;
  paramsSubscription?: Subscription;
  editTaskSubscription?: Subscription;
  getTaskSubscription?: Subscription;
  deleteTaskSubscription?: Subscription;
  routeSubscription?: Subscription;
  taskForm!: FormGroup;
  model?: TaskM;

  constructor(
    private route: ActivatedRoute,
    private taskService: TaskService,
    private router: Router,
    private formBuilder: FormBuilder
  ) {}

  ngOnInit(): void {
    // Initialize the form and subscribe to route parameter changes
    this.initForm();

    this.paramsSubscription = this.route.paramMap.subscribe({
      next: (params) => {
        this.id = params.get('id');

        // Get Task From API and update form values
        if (this.id) {
          this.getTaskSubscription = this.taskService.getTaskById(this.id).subscribe({
            next: (response) => {
              this.model = response;
              this.taskForm.patchValue(response);
            },
          });
        }
      },
    });
  }

  // Initialize the form with default values and validators
  initForm(): void {
    this.taskForm = this.formBuilder.group({
      title: ['', Validators.required],
      description: '',
      dueDate: new Date(),
    });
  }

  // Handle form submission
  onFormSubmit(): void {
    // Check if the form is valid and an ID is present
    if (this.taskForm.valid && this.id) {
      // Extract form values and create an UpdateTask object
      const updateTask: UpdateTask = this.taskForm.value;

      // Call the service to update the task
      this.editTaskSubscription = this.taskService.updateTask(this.id, updateTask).subscribe({
        next: (response) => {
          // Navigate to the task list after successful submission
          this.router.navigateByUrl('/admin/tasks');
        },
      });
    }
  }

  // Handle task deletion
  onDelete(): void {
    // Check if an ID is present
    if (this.id) {
      // Call the service to delete the task
      this.deleteTaskSubscription = this.taskService.deleteTask(this.id).subscribe({
        next: (response) => {
          // Navigate to the task list after successful deletion
          this.router.navigateByUrl('/admin/tasks');
        },
      });
    }
  }

  // Unsubscribe from subscriptions to prevent memory leaks
  ngOnDestroy(): void {
    this.paramsSubscription?.unsubscribe();
    this.editTaskSubscription?.unsubscribe();
    this.getTaskSubscription?.unsubscribe();
    this.deleteTaskSubscription?.unsubscribe();
    this.routeSubscription?.unsubscribe();
  }
}
