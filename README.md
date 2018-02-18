# OneSignal.PushNotification.API
Sends push notifications to specific mobile devices/device via OneSignal web API. 

You can use it like this:



            Notification myNotification = new Notification();
            myNotification.contents = "HEELO FROM PUSH NOTIFICATION!";
            myNotification.small_icon = "icon.png";
            myNotification.include_player_ids = new List<string> { "OneSignal player id for specific device","Second onesignal playerid","thirdid etc." };
            myNotification.Send();
  
  
  It's Easy
