• Building two .NET Microservices using the REST API pattern.

• Working with dedicated persistence layers for both services.

• Deploying our services to Kubernetes cluster.

• Employing the API Gateway pattern to route to our services.

• Building Synchronous messaging between services (HTTP & gRPC).

• Building Asynchronous messaging between services using an Event Bus (RabbitMQ).


How to Build Microservice Project Step by Step: 

PART 1 - INTRODUCTION & Theory 

- Solution Architecture:

  ![image](https://github.com/user-attachments/assets/f7167e0c-4f7c-4bbb-b11f-0c3afde60c29)

      kubectl rollout restart deployment ingress-nginx-controller -n ingress-nginx
  
- Application Architecture:
  
  - Platform service Architecture

    ![image](https://github.com/user-attachments/assets/6a03b3b8-0baa-4ed6-a440-7ea59946d633)

  - Command service Architecture

    ![image](https://github.com/user-attachments/assets/bbc3997a-fae6-4ce1-a49d-77466d754c72)


PART 2 - BUILDING THE FIRST SERVICE

`First we must create a WebApi project by Visual Code using dotnet vresion 8.0 or 6.0.`
- Scaffolding the service
  
  - Uplaod this packages:
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.Tools
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.InMemory
    - AutoMapper
    - RabbitMQ.Client
    - Grpc.AspNetCore
  
- Data Layer - Model

  On this layer you Will create a new folder with name `Models` and create your model Class.
- Data Layer - DB Context

  On this layer you Will create a new folder with name `Data` and create your DB Context Class and Set your Model on it, After that you must add service (Db Context) on your `Program.cs or Startup.cs` to create the Data Base.
- Data Layer - Repository
  - On this layer you`ll Create the Repositories:
    - Interfaces Repository

      That to defined the functions you need.
    - Class Repository

      That Inherts the Interface Repository to implement it`s functions and Using the Db Context.
      
  After that you Will AddScoped Service on your `Program.cs or Startup.cs`.
- Data Layer - DB Preparation
  
  Here you will create yor Seed Data and Apply it on your `Program.cs or Startup.cs` to implement it.
- Data Layer - Data Transfer Objects

  Here we will create a new folder in name `Dtos` containing a set of classes that are similar to those found in Models and used to read and create items.
- Controller and Actions
  
  Here We Will create a Controller Api that using the Repositories layer to build the Actions.
  These procedures adds, delete and modify data on the database and more actions like you need.

PART 3 - DOCKER & KUBERNETES

 - Download Docker Desktop
 - To Build Image
   
       - docker build -t userName/imangeName .
 - To push image to the Docker hub:
   
       - docker push userName/imangeName
 - To Pull image from the Docker hub:

       - docker push userName/imangeName
 - 
    - Containerizing the Platform Service
    - Pushing to Docker Hub
    - Introduction to Kubernetes
    - Kubernetes Architecture Overview
    - Deploy the Platform service
    
PART 4 - STARTING OUR 2ND SERVICE

    - Scaffolding the service
    - Add a Controller and Action
    - Overview of Synchronous and Asynchronous Messaging
    - Adding a HTTP Client
    - Deploying service to Kubernetes
    - Adding an API Gateway

PART 5 - STARTING WITH SQL SERVER

    - Adding a Persistent Volume Claim
    - Adding a Kubernetes Secret
    - Deploying SQL Server to Kubernetes
    - Accessing SQL Server via Management Studio
    - Updating our Platform Service to use SQL Server


PART 6 - MULTI-RESOURCE API

    - End Point Review for Commands Service
    - Data Layer - Models
    - Data Layer - DB Context
    - Data Layer - Repository
    - Data Layer - Dtos
    - Data Layer - AutoMapper Profiles
    - Controller & Actions


PART 7 - MESSAGE BUS & RABBITMQ

    - Solution Architecture Overview
    - RabbitMQ Overview
    - Deploy RabbitMQ to Kubernetes


PART 8 - ASYNCHRONOUS MESSAGING

    - Add a Message Bus Publisher to Platform Service
    - Testing our Publisher
    - Command Service ground work
    - Event Processing
    - Adding an Event Listener
    - Testing Locally
    - Deploying to Kubernetes


PART 9 - GRPC

    - Overview of gRPC
    - Final Kubernetes networking configuration
    - Adding gRPC Package references
    - Working with Protocol Buffers
    - Adding a gRPC Server to Platforms Service
    - Adding a gRPC Client to Commands Service
    - Adding a Database prep class to Commands Service
    - Test Locally
    - Deploy to Kubernetes
    - Final thoughts & thanks
    - Supporter Credits
