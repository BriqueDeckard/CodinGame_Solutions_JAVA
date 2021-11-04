import json
import time
import urllib.request

from kafka import KafkaProducer
print("Import succeeded")
# The api key
API_KEY = "95b387e8a3077aa4b962638a5ff6c3e30d428986"
# The url
url = "https://api.jcdecaux.com/vls/v1/stations?apiKey={}".format(API_KEY)

# Get a kafka producer
producer = KafkaProducer(bootstrap_servers="localhost:9092")
print(str(producer))

while True:
    # Answer the url
    response = urllib.request.urlopen(url)
    print(str(response))
    # decode the response
    stations = json.loads(response.read().decode())
    count = 0
    # publish the message on the topic "velib-stations"
    for station in stations:
        
        producer.send("velib-stations", json.dumps(station).encode())
    count = count+1
    print("{}- {} Produce {} station records".format(count, time.time(), len(stations)))
    time.sleep(1)