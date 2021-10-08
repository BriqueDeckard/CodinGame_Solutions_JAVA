# The Domain Layer

The Domain Layer is responsible for representing concepts of the business, information about the business situation, and business rules.
The state of the business is contolled and used here. It is the heart of the software.

Following the Persistence Ignorance and the Infrastructure Ignorance principles, this layer must completely ignore data persistence details 
(--> Infrastructure layer)
This layer should also not take direct dependencies on the infrastructure : the domain model entity classes should be POCO.

Domain entities should not have direct dependency on ay data access infrastructure framework (Entity Framework ?).

