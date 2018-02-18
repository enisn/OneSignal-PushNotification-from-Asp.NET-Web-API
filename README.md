# OneSignal.PushNotification.API
Sends push notifications to specific mobile devices/device via OneSignal web API. 

You can use it like this:


```csharp
            Notification myNotification = new Notification();
            myNotification.contents = "HEELO FROM PUSH NOTIFICATION!";
            myNotification.small_icon = "icon.png";
            myNotification.include_player_ids = new List<string> { "OneSignal_playerid_fordevice","Another_onesignal_playerid" };
            myNotification.Send();
  ```
  
  It's Easy
