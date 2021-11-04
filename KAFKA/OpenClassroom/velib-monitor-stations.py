import json
import sys
from kafka import KafkaConsumer

stations = {}
bootstrap_servers = ['localhost:9092']
topicName = "velib-stations"

consumer = KafkaConsumer(topicName, bootstrap_servers=bootstrap_servers, group_id="velib-monitor-stations", auto_offset_reset = 'earliest')
print(str(consumer))
try:
    for message in consumer:
        print ("%s:%d:%d: key=%s value=%s" % (message.topic, message.partition,message.offset, message.key,message.value))
except KeyboardInterrupt:
    sys.exit()
