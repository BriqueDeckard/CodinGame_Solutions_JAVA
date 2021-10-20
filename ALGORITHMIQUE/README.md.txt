# COUPLING : 

## MEMO

Coupling is a metric that indicates the level of interaction between software components.

as pressman said, there are seven coupling levels : 
1. Without coupling : components do not exchange information.
2. By data : component exchange information by methods using simple type arguments.
3. By package : component exchange information by methods using composed arguments.
4. By control: the components pass or modify their control by changing a flag (lock).
5. External: the components exchange information by an external means of communication (file, pipeline, communication link).
6. Common (global): components exchange information via a common set of data (variables).
7. By content (internal): components exchange information by reading and writing directly in their respective data spaces (variables)


## Disadvantages of a strong coupling

Strong coupling should be avoided for several reasons:

A strong coupling generates the dish antipattern of spaghetti:
You cannot determine the who, what and how of a data change.
A strong coupling necessarily implies a weak functional independence:
The software component is difficult to re-use,
The software component is difficult to test.
If two tasks access, by strong coupling, a common resource (critical resource) and they execute in mutual exclusion, then if one of the tasks remains blocked in critical section, it automatically blocks the other:
Risk of deadlock.
The components lose their autonomy. It is difficult to replace one component with another. The structures operating with strong coupling are therefore not very flexible and not very open.
