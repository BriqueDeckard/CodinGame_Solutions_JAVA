# Apache KAFKA

[source](https://www.tutorialspoint.com/apache_kafka/index.htm)

## Introduction: 

Kafka is a messaging system. A messaging system is responsible for transferring data from one application to another. In this way, the applications can focus on data, and not worry about gow to share it.
Distributed messaging is based on the concept of queing. Messages are queued asynchrounously, between client ^pplications and messaging system.
There are two types of messaging patterns: 
- point to point
- publish sbscribe (--> most of the messaging patterns)

### Point to Point messaging system:

In a point to point system, messages are persisted in a queue. One, or more consumers can consume the messages in the queue, but a particular message can be consumed by a maximum of ONE consumer only.
One a consumer reads a message in the queue, it disappears from that queue.

### Publish Subscribe messaging system: 

In the Pub-Sub messaging system, messages are persisted in a topic. Unlike point-to-point system, consumers can subscribe to one or more topic and consume all the messages in that topic.
In the Pub-Sub system, messages producers are callde **publishers** and messages consumers are called **subscribers**.

## What is kafka ?

Apache Kafka is a distributed publish-subscribe messaging system, and a robust queue that can handle a high volume of data and enables you to pass messages from one end-point to another.
Kafka is suitable for both offline and online message consumption. Kafka messages are persisted on the disk and replicated within the cluster to prevent data loss. Kafka is built on top of the ZooKeeper synchornization service. It integrates very well with Apache Storm and Spark for real-time streaming data analysis.

**What is ZooKeeper?**
***ZooKeeper is a centralized service for maintaining configuration information, naming, providing distributed synchronization, and providing group services. All of these kinds of services are used in some form or another by distributed applications. Each time they are implemented there is a lot of work that goes into fixing the bugs and race conditions that are inevitable. Because of the difficulty of implementing these kinds of services, applications initially usually skimp on them, which make them brittle in the presence of change and difficult to manage. Even when done correctly, different implementations of these services lead to management complexity when the applications are deployed.***
