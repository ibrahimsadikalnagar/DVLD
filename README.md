Driving License Management Department (DVLD)
Project Overview

Driving License Management Department (DVLD) is a comprehensive Windows forms application designed to streamline and automate the processes related to driver's license services. The system manages license issuance, renewal, testing, and administrative tasks for various vehicle license categories, ensuring efficient and transparent license management.
Key Features

    License Management:
        Support for multiple license classes (motorcycles, cars, commercial vehicles, etc.).
        Complete license application workflow.
    Testing and Exams:
        Medical and theoretical exam management.
        Practical driving test scheduling.
    License Services:
        License renewal and replacement services.
    User Management:
        Detailed user and person management.
    Administrative Controls:
        System management tools for administrators.

Technical Specifications

    Programming Language: C#
    Database: SQL Server
    Frontend: Windows Forms
    Data Access: ADO.NET
    Architecture: 3-Tier Architecture

Recent Improvements

This section showcases my growth as a developer and documents key improvements made to the project, along with the dates they were implemented.

    Migration to .NET Core: Successfully migrated The Data Access Layer (DAL) from .NET Framework to .NET Core [2025-02-11].
        Data Access Layer:
            Repository Pattern & Interfaces: Implemented the repository pattern and interface contracts for the data access layer
            Entity Framework Core (EF Core): Configured database entities using EF Core Fluent API and defined relationships, constraints, and optimized performance with raw SQL queries for complex joins.
            Unit Testing: Added xUnit tests to validate repository methods and business logic and used Moq to mock dependencies for isolated and reliable testing.

    Single Responsibility Principle (SRP): Each class was split into smaller, single-responsibility classes.
        business layer:
            Entities, Services, RepoServices, Validators, Mappers, and other specific classes [2025-02-01].
        data access layer:
            SqlStatements, ParameterBuilder, and DataMapper [2025-01-25].
        Improved maintainability and adherence to SOLID principles.

    Data Transfer: Introduced Data Transfer Objects (DTOs) for cleaner data handling [2025-01-18].

    Resource Management: Implemented proper resource disposal patterns to reduce memory leaks [2025-01-15].

For a detailed history of improvements, see the CHANGELOG.md file.
Recent Changes

    Refactor: Removed the Windows Forms UI (presentation layer) to focus on backend development.
        The Windows Forms project has been moved outside of Git.
        Retained the Business Logic Layer (BAL), Data Access Layer (DAL), and Data Transfer Objects (DTOs) for backend development.
    Current Focus: Refactoring the backend to prepare for a modern web-based frontend.
    Future Goal: Transition to a web application using ASP.NET Core.

Project Structure

The project is now organized into a single solution file (DVLD_Backend.sln) that includes the following projects:

    BAL: Business Logic Layer (core application logic).
    DAL: Data Access Layer (database interactions).
    DTOs: Data Transfer Objects (used for communication between layers).

License Classes Supported

    Small Motorcycle License
    Heavy Motorcycle License
    Standard Car License
    Commercial License (Taxi/Limousine)
    Agricultural Vehicle License
    Small and Medium Bus License
    Heavy Vehicle and Truck License

Installation Requirements

    Development Environment: Visual Studio
    Framework: .NET Framework
    Database: SQL Server
    Operating System: Windows
