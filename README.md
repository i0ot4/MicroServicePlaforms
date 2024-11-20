
• Building two .NET Microservices using the REST API pattern
• Working with dedicated persistence layers for both services
• Deploying our services to Kubernetes cluster
• Employing the API Gateway pattern to route to our services
• Building Synchronous messaging between services (HTTP & gRPC)
• Building Asynchronous messaging between services using an Event Bus (RabbitMQ)


⏲️ Time Codes ⏲️

    0:00 PART 1 - INTRODUCTION & Theory
    2:39 Course Approach
    6:11 Course Overview
    11:31 Ingredients & Tooling
    16:14 What are microservices?
    33:40 Overview of our microservices
    37:37 Solution Architecture
    43:54 Application Architecture 


    46:47 PART 2 - BUILDING THE FIRST SERVICE
    47:33 Scaffolding the service
    52:37 Data Layer - Model
    57:35 Data Layer - DB Context
    1:02:38 Data Layer - Repository
    1:16:00 Data Layer - DB Preparation
    1:27:31 Data Layer - Data Transfer Objects
    1:41:19 Controller and Actions


2:16:21 PART 3 - DOCKER & KUBERNETES

    2:16:21 Review of Docker
    2:20:55 Containerizing the Platform Service
    2:37:29 Pushing to Docker Hub
    2:42:43 Introduction to Kubernetes
    2:46:54 Kubernetes Architecture Overview
    2:58:40 Deploy the Platform service


3:25:01 PART 4 - STARTING OUR 2ND SERVICE

    3:25:01 Scaffolding the service
    3:30:41 Add a Controller and Action
    3:41:50 Overview of Synchronous and Asynchronous Messaging
    3:55:21 Adding a HTTP Client
    4:19:34 Deploying service to Kubernetes
    4:44:55 Adding an API Gateway



5:07:12 PART 5 - STARTING WITH SQL SERVER

    5:07:12 Adding a Persistent Volume Claim
    5:12:34 Adding a Kubernetes Secret
    5:15:12 Deploying SQL Server to Kubernetes
    5:30:31 Accessing SQL Server via Management Studio
    5:33:06 Updating our Platform Service to use SQL Server


6:06:02 PART 6 - MULTI-RESOURCE API

    6:06:02 End Point Review for Commands Service
    6:09:31 Data Layer - Models
    6:16:38 Data Layer - DB Context
    6:21:37 Data Layer - Repository
    6:34:53 Data Layer - Dtos
    6:40:49 Data Layer - AutoMapper Profiles
    6:45:26 Controller & Actions


7:20:49 PART 7 - MESSAGE BUS & RABBITMQ

    7:20:49 Solution Architecture Overview
    7:24:06 RabbitMQ Overview
    7:28:55 Deploy RabbitMQ to Kubernetes


7:43:27 PART 8 - ASYNCHRONOUS MESSAGING

    7:44:01 Add a Message Bus Publisher to Platform Service
    8:18:07 Testing our Publisher
    8:25:19 Command Service ground work
    8:36:46 Event Processing
    8:59:14 Adding an Event Listener
    9:19:29 Testing Locally
    9:26:28 Deploying to Kubernetes


9:39:12 PART 9 - GRPC

    9:39:12 Overview of gRPC
    9:44:06 Final Kubernetes networking configuration
    9:54:32 Adding gRPC Package references
    9:56:44 Working with Protocol Buffers
    10:03:55 Adding a gRPC Server to Platforms Service
    10:20:53 Adding a gRPC Client to Commands Service
    10:39:41 Adding a Database prep class to Commands Service
    10:48:05 Test Locally
    10:51:01 Deploy to Kubernetes
    10:58:43 Final thoughts & thanks
    11:00:55 Supporter Credits
