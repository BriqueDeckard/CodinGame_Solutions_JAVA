from kafka import KafkaConsumer
import json

from kafka.consumer import group
consumer = KafkaConsumer('testPierre', auto_offset_reset='smallest')

print("Consumer created")

for message in consumer:
    print(message.value)