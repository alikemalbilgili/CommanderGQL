# GraphQL Sample Project with .NET 7, Docker, PostgreSQL, and Hot Chocolate

This repository contains a sample project to help you learn GraphQL using .NET 7, Docker, PostgreSQL, and Hot Chocolate. The project provides a basic setup for building a GraphQL API and includes a Docker configuration for containerization.

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 7](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Docker](https://www.docker.com/get-started)

## Getting Started

###  1. Clone this repository to your local machine:

```
git clone https://github.com/alikemalbilgili/CommanderGQL
```

###  Navigate to the project directory:

```
cd your-repo
```

### Build and run the Docker containers using Docker Compose:

```
docker-compose up -d
```

### Open a web browser and access the GraphQL playground:
```
http://localhost:5000/graphql
```

## Project Structure
The project follows a typical .NET project structure, with the following main components:

GraphQL folder: Contains the GraphQL schema and resolvers.
Data folder: Includes the data access layer and database context.
Models folder: Contains the models used in the application.
Controllers folder: Includes the API controllers.
Program.cs : Entry points for the application.

## Development Workflow
To start developing your GraphQL API, you can make changes to the existing schema, resolvers, and models to suit your needs. The project is set up with Hot Chocolate, a popular GraphQL server library for .NET, which provides a simple and flexible way to define and implement GraphQL schemas.

You can find the GraphQL schema in the GraphQL folder and define your types, queries, mutations, and subscriptions as needed.

The Data folder includes the data access layer, where you can define your repositories and interact with the PostgreSQL database. The database context is also located here.

Feel free to explore and modify the project according to your requirements.
