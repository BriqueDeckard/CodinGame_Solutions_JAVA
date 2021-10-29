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

## What is ZooKeeper?
ZooKeeper is a centralized service for maintaining configuration information, naming, providing distributed synchronization, and providing group services. All of these kinds of services are used in some form or another by distributed applications. Each time they are implemented there is a lot of work that goes into fixing the bugs and race conditions that are inevitable. Because of the difficulty of implementing these kinds of services, applications initially usually skimp on them, which make them brittle in the presence of change and difficult to manage. Even when done correctly, different implementations of these services lead to management complexity when the applications are deployed.
** Start Zookeeper: **
```
bin/zookeeper-server-start.sh config/zookeeper.properties

```

## What is kafka ?

Apache Kafka is a distributed publish-subscribe messaging system, and a robust queue that can handle a high volume of data and enables you to pass messages from one end-point to another.
Kafka is suitable for both offline and online message consumption. Kafka messages are persisted on the disk and replicated within the cluster to prevent data loss. Kafka is built on top of the ZooKeeper synchornization service. It integrates very well with Apache Storm and Spark for real-time streaming data analysis.





## Components: 
### Topics: 

A stream of messages belonging to a particular category is called a topic. Data is stored in topics.

Topics are split into partitions. For each topic, Kafka keeps a mini-mum of one partition. Each such partition contains messages in an immutable ordered sequence. A partition is implemented as a set of segment files of equal sizes.

#### Create a topic : 
```
./bin/kafka-topics.sh  --create --zookeeper localhost:2181 --replication-factor 1 --partitions 1 --topic blabla 
```

#### Alter a topic to ad partitions : 
```
./bin/kafka-topics.sh --alter --zookeeper localhost:2181 --topic blabla --partitions 2
```

#### Describe a topic:
```
./bin/kafka-topics.sh --describe --zookeeper localhost:2181 --topic blabla
```

### Partition and partition offset: 

Topics may have many partitions, so it can handle an arbitrary amount of data. 
```
--partitions ##
```
	
Each partitioned message has a unique sequence id called as offset.

### Replicas of partition:

Replicas are nothing but backups of a partition. Replicas are never read or write data. They are used to prevent data loss.

### Brokers:
- Brokers are the components that are responsible for maintaining the pub-lished data. Each broker hae zero or more partitions per topic. Assume, if there are N partitions in a topic and N number of brokers, each broker will have one partition.
- If there are N partitions put more than N brokers (n + m), the first N brokers will have one partition and the next M brokers will not have any partition for that topic.
- If there are N partitions in a topic and less than N brokers (n-m), each broker will have one or more partition sharing among them. But this scenario is not recommended due to inequal load distribution among the broker.

### Kafka cluster: 
Kafka's having more than one broker are called "kafka cluster". A kafka cluster can be expanded without downtime. These clusters are used to manage the persistence and replication of message data.

### Producers: 
Producers = publishers of messages. Producers send data to kafka brokers. Everytime a porducer publishes a message to a broker, the broker simply appends the message to the last segment file. Actually, the message will be appended to a partition. Producer can also send messages to a partition of their choice.
#### Create a producer:
```
./bin/kafka-console-producer.sh --broker-list localhost:9092 --topic blabla
```

### Consumers:
Consumers read data from brokers. Consumers subscribe to one or more topics and consume published messages py pulling data from the brokers.
#### Create a consumer: 
```
./bin/kafka-console-consumer.sh --bootstrap-server localhost:9092 --topic blabla
```
#### With a group id:
```
$ ./bin/kafka-console-consumer.sh --bootstrap-server localhost:9092 --topic blabla --consumer-property group.id=mygroup
```

### Leader:
The Leader is the node responsible for all reads and writes for the given partition. Every partition has one server acting as a leader.

### Follower:
Node which follows leader instructions are called as follower. If the leader fails, one of the follower will automatically become the new leader. As follower act as normal consumer, pulls messages and updates its own data store.



