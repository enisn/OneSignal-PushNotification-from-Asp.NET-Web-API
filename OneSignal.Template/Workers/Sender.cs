using OneSignal.Template.Provider;
using OneSignal.Template.Templates;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.Template.Workers
{
    public class Sender
    {  
        public static async void SendNotification(string playerId, LocalizatedContent content)
        {
            var response = await ClientManager.Post<Object, Notification>(new Notification
            {
                android_group = "test",
                contents = content,
                priority = 10,
                include_player_ids = new List<string> { playerId },
                small_icon = "icon",


            }, Configuration.URL_Notification_POST);

            var test = response;
        }
        /// <summary>
        /// Returns successful statement
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> SendNotification(Notification notification)
        {
            try
            {
                var response = await ClientManager.Post<object, Notification>(notification, Configuration.URL_Notification_POST);
                return response != null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
