# Task Manager Application

Task Manager is a web application that enables users to manage tasks efficiently. The application is divided into a backend API built with .NET and a frontend client built with Angular.

## Backend (.NET) Requirements:

1. Create a .NET Web API project with the following endpoints:
   - `GET /api/tasks`: Retrieves a list of all tasks.
   - `POST /api/tasks`: Creates a new task.
   - `PUT /api/tasks/{id}`: Updates an existing task.
   - `DELETE /api/tasks/{id}`: Deletes a task.

2. Define a Task model with the following properties:
   - `Id (int)`: Unique identifier for the task.
   - `Title (string)`: Title of the task.
   - `Description (string)`: Description of the task.
   - `DueDate (DateTime)`: Due date of the task.

3. Create a dummy database to run sample data.

## Frontend (Angular) Requirements:

1. Create an Angular project using the Angular CLI.

2. Create the following components:
   - `TaskListComponent`: Displays a list of tasks.
   - `TaskFormComponent`: Provides a form for creating and updating tasks.

3. Implement the following features in the components:
   - **TaskListComponent:**
     - Fetches the list of tasks from the backend API and displays them in a table.
     - Provides buttons or links to delete tasks.
     - Allows users to click on a task to navigate to the task details page.
   - **TaskFormComponent:**
     - Provides a form with input fields for the task title, description, and due date.
     - Validates the form inputs and displays error messages if necessary.
     - Handles form submission to create or update tasks.

4. Use Angular routing to navigate between different pages or components (e.g., task list, task details, task form).

5. Apply basic styling to make the application visually appealing.

## Additional Requirements:

1. Ensure proper error handling and display meaningful error messages to users when API requests fail or encounter validation errors.

2. Implement appropriate input validation on the backend API to validate task properties.

3. Use appropriate HTTP methods (GET, POST, PUT, DELETE) for the corresponding API endpoints.

4. Use reactive forms in Angular for handling form inputs and validation.

5. Follow best practices for code organization, readability, and maintainability.

Feel free to enhance this document with additional information specific to your implementation or deployment instructions.
