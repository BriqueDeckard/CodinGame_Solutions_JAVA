from kafka import KafkaProducer
import uuid
import json

producer = KafkaProducer(
    bootstrap_servers=['localhost:9092'])
print('Created producer')

for i in range(10):
    print("i: ", i)
    producer.send('testPierre', b'hey')