#Introduction
Notification micro-service, used to push Firebase notifications
Developed by following this tutorial :
https://amaelberteau.com/tuto/firebase-cloud-messaging-net-application-integration

#Getting started
Create a Firebase project --> https://firebase.google.com/docs/android/setup#create-firebase-project
Register your app with Firebase --> https://firebase.google.com/docs/android/setup#register-app

#AppSettings.json

--> Specify the informations into the appsettings.json file :
- FirebaseCloudMessagingUri is the uri of the Firebase cloud messaging endpoint.
- The token in the AuthorizationHeaderName is the Firebase Cloud Messaging server key.

Add this to the file :

  "Notification": {
    "FirebaseCloudMessagingUri": "https://fcm.googleapis.com/fcm/send",
    "RequestContentType": "application/json",
    "SenderHeader": "Sender: id={0}",
    "SenderId": "193383106700",
    "AuthorizationHeaderName": "Authorization: key=AAAAzsP0D2Y:APA91bGS7j8tkUFJ4S2zcHLuduoqgQTELhf49y7Mm5lBkm1hPSzbFbmM4ImfXDYawDptyHXqxDq0AyHjgwzQsr8PV6zZrSvxpPtMZ--HGkZuM2UTATRu54sWxAYqE7DDGTEU_Hzizx6g"
  }


  #Send a notification 
  
  -> The Dto is composed as follows : 
  Dto (CassandiaNotificationDto)
  - Topic (string) // /!\ Set the topic here
  - Id (string)
  --<> Message (FirebaseMessageDTO)
      - Priority
      - ContentAvailable (bool)
      - Data (object)
      --<> Notification (NotificationDto)
          - Body (string)
          - Title (string)
