# Property & Tenant Manager - Assignment 7

### Author: Angel Lopez
### Course: CS 458 - Spring 2026

## Project Overview
This is an ASP.NET Core MVC application designed to manage residential properties and their assigned tenants. The project utilizes a **One-to-Many relationship** where each Property can host multiple Tenants.

## Tech Stack
* **Framework:** ASP.NET Core 10.0 (MVC)
* **Database:** SQL Server (Running via Docker)
* **ORM:** Entity Framework Core
* **Frontend:** Razor Views + Bootstrap 5

## Setup and Installation

### 1. Start the Database
This project uses Docker to manage the SQL Server instance. Ensure Docker Desktop is running, then execute the following in the project root:
```bash
docker-compose up -d