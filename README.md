# EmployeeManagementAPI

## Web API for managing employee records.

Project for Phase 2: ASP.NET Core Web API

Designed 4 endpoints for CRUD operations on employee records.

## MSSQL Database Setup

```
docker compose up -d
```
All of the information is in the docker-compose.yml file.

> For educational purposes only. Not for production use.
 
> Use at your own risk. - Nguyen Quang Trung

## Endpoints
- GET /employees/get - Retrieve all employees
- POST /employees/insert - Create a new employee
- PUT /employees/update - Update an existing employee
- DELETE /employees/delete/{id} - Delete an employee by ID