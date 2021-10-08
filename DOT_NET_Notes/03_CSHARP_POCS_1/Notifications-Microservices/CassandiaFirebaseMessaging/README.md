#Introduction
Firebase Cloud Messaging Android client.
Used to receive Firebase notifications on a Android Device
Developed by following this tutorial :
https://firebase.google.com/docs/android/setup

#1. Getting started

#1.A - You can use CassandiaFirebaseMessaging Firebase project :

	/!\ The default topic is "cassandia". /!\

	The informations you need are :
	- Sender ID : 
	1044097580698
	- Server key :	AAAA8xkQvpo:APA91bGWHnC84fYIFyUi803WdLeB6AsSKnL2P1R9hSDD_qtqM23h2G2ZonobxKJgKGbNT30rIthBb5BjKVmedGq2vpcgri6HyHHh-C5emFNalZB6QwybqztiI8HJV-BsGx93-g6kV6B4
	
#1.B - Or you can create a Firebase project : 

https://firebase.google.com/docs/android/setup#create-firebase-project

#2. Specify the informations corresponding to the FirebaseProject into the appsettings.json file :

- FirebaseCloudMessagingUri is the uri of the Firebase cloud messaging endpoint. 
	"https://fcm.googleapis.com/fcm/send" ;
- Put the sender ID into the SenderId field ;
- Put the the Firebase Cloud Messaging server key into the AuthorizationHeaderName.

Your AppSettings.json must looks like : 

  "Notification": {
    "FirebaseCloudMessagingUri": "https://fcm.googleapis.com/fcm/send",
    "RequestContentType": "application/json",
    "SenderHeader": "Sender: id={0}",
    "SenderId": "1044097580698",
    "AuthorizationHeaderName": "Authorization: key=AAAA8xkQvpo:APA91bGWHnC84fYIFyUi803WdLeB6AsSKnL2P1R9hSDD_qtqM23h2G2ZonobxKJgKGbNT30rIthBb5BjKVmedGq2vpcgri6HyHHh-C5emFNalZB6QwybqztiI8HJV-BsGx93-g6kV6B4"
  }


#3. Send a notification 
  
#3.1. DTO :

	The Dto is composed as follows : 
	  
		- (CassandiaNotification) Dto 
				|- (string) Id 
				|- (string) Topic  	// Set the topic here
				|
				|--<> (FirebaseMessageDTO) Message 
							|- (string)	Priority	// normal or high
							|- (bool)	ContentAvailable 
							|- (object) Data 
							|
							|--<> (NotificationDto) Notification 
									|- (string)	Body
									|- (string)	Title 
#3.1.1 Topic :

	"Topic" is the targeted topic. 
	Just add the topic name into the dto, the factory adds the "/topics/" prefix if the field is not empty.
	
	-> More informations here : https://firebase.google.com/docs/cloud-messaging/android/topic-messaging

#3.1.2 Firebase Message : 

	It's the message to send.

#3.1.2.1. Priority :

	Sets the priority of the message. Valid values are "normal" and "high." On iOS, these correspond to APNs priorities 5 and 10.
	
	By default, notification messages are sent with high priority, and data messages are sent with normal priority. 
	Normal priority optimizes the client app's battery consumption and should be used unless immediate delivery is required. 
	For messages with normal priority, the app may receive the message with unspecified delay.
	
	When a message is sent with high priority, it is sent immediately, and the app can display a notification.

#3.1.2.2. ContentAvailable :

	On iOS, use this field to represent content-available in the APNs payload. 
	When a notification or message is sent and this is set to true, an inactive client app is awoken, 
	and the message is sent through APNs as a silent notification and not through the FCM connection server. 
	
#3.1.2.3. Data : 
	
	This parameter specifies the custom key-value pairs of the message's payload.
	Ex : 
		{"score":"3x1"}:
	
		- On iOS, if the message is sent via APNs, it represents the custom data fields. If it is sent via FCM connection server, it would be represented as key value dictionary in AppDelegate application:didReceiveRemoteNotification:.
	
		- On Android, this would result in an intent extra named score with the string value 3x1.
	
	The key should not be a reserved word ("from" or any word starting with "google" or "gcm"). 
	Do not use any of the words defined in this table : 
	
	https://firebase.google.com/docs/cloud-messaging/http-server-ref

	Values in string types are recommended. You have to convert values in objects or other non-string data types (e.g., integers or booleans) to string.

#3.1.2.4. Notification : 

	This parameter specifies the user-visible key-value pairs of the notification payload. 
	If a notification payload is provided, or the content_available option is set to true for a message to an iOS device, the message is sent through APNs, otherwise it is sent through the FCM connection server.

#3.2. Operations :
	
	- The factory's DtoToEntity converts the FirebaseNotificationDto into a FirebaseNotification ;
	- Encapsulates the FBNotification into a FBMessage ;
	- Encapsulate the FBMessage into a CassandiaNotification and send it to the repository
	- The repository inserts the CassandiaNotification into the DB and if it succeeds, and pushs the message using a web request ;
	