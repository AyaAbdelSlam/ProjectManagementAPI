Project Management Application
This is a full-stack project management application that allows users to create, manage, and update projects and tasks. The backend is built using .NET Core with Entity Framework and JWT authentication, while the frontend is built using React.

Table of Contents
Features
Prerequisites
Installation
Backend Setup
Frontend Setup
Running the Application
Additional Notes
Features
Backend (ASP.NET Core)
CRUD operations for Projects and Tasks.
Role-Based Access Control (RBAC):
Managers can create projects and tasks.
Employees can only update tasks assigned to them.
JWT-based Authentication and Authorization.
REST API endpoints for managing projects and tasks.
Endpoint for overdue tasks (tasks not marked as completed after their end date).
Frontend (ReactJS)
CRUD functionality for projects and tasks.
Overdue task highlighting with visual indicators.
JWT-based login system with role-specific access.
User-friendly and minimalistic interface.
Prerequisites
Make sure you have the following installed:

Backend
.NET Core 6 SDK or later Download.
SQL Server for database.
Entity Framework Core for ORM.
Frontend
Node.js (v14.17.6 or later) Download.
npm or yarn (comes with Node.js).
Installation
Step 1: Clone the repository
bash
Copy code
git clone https://github.com/your-username/project-management-app.git
cd project-management-app
Backend Setup
Step 2: Configure the Backend
Navigate to the Backend directory:

bash
Copy code
cd Backend
Database Setup:

Open the appsettings.json file and configure the connection string to your SQL Server instance:
json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server_name;Database=ProjectManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Run Migrations:




Navigate to http://localhost:3000 to access the frontend.
Additional Notes
1. API Endpoints
The following are some of the key API endpoints:

Projects:
GET /api/project: Fetch all projects.
POST /api/project: Create a new project.
PUT /api/project/{id}: Update a project.
DELETE /api/project/{id}: Delete a project.
Tasks:
GET /api/task/project/{projectId}: Fetch tasks by project.
POST /api/task: Create a new task.
PUT /api/task/{id}: Update a task.
DELETE /api/task/{id}: Delete a task.
Authentication:
POST /api/auth/login: Login and receive JWT.