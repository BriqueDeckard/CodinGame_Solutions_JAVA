# Application Layer

Defines the jobs the software is supposed to do and directs the domain objects to 
work out problems. 
This layer is kept thin.

It does not contains business rules, but coordinates tasks and delegate work to 
domain objects in the next layer down.

It does not contains state reflecting the business situation, but it can have 
state that reflects the progress of a task.