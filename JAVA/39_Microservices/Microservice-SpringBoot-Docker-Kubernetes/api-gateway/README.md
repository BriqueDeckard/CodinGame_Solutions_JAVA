# API Gateway

API Gateway provides a single point-of-entry to the application. It redirects the request received to the appropriate microservices. This redirection is transparent to the user. Thus, allowing the user to use the application via the same host / url.

API Gateway has two main dependencies, namely Eureka Discovery Client and Gateway.
As mentioned above, API Gateway redirects requests it receives from the user. Thus, it must be able to discover other microservices as well, as such API Gateway is an Eureka client. We will be using Eureka as our Service Discovery Server. Thus, importing the Eureka Discovery Client dependecy.
Moreover, for API Gateway to acts as the Gateway, it has to import the Gateway dependency.

The key feature of API Gateway is that it is able to redirect, with built-in Load Balancing functionality, to the respective microservice based on the request it receives. You can specify such behaviours at application.yml file.
The configurations below tell Spring Boot the routes to the specify microservices based on the predicate of the path. Notice that in the uri section, the service name is prepended with lb:// . This enabled the load balancing feature to the respective service. If you have multiple instances of the microservice, it will automatically load balance the traffic.