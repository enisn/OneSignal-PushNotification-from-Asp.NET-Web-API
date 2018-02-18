using OneSignal.Template.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.Template.Templates
{
    public class Notification
    {
        public string app_id { get => Configuration.App_ID; }
        public List<string> included_segments { get; set; }
        public List<string> include_player_ids { get; set; }
        public LocalizatedContent contents { get; set; }
        public LocalizatedContent headings { get; set; }
        public List<Button> buttons { get; set; }
        /// <summary>
        /// Any data to send
        /// </summary>
        public Object data { get; set; }
        /// <summary>
        /// URL to open directly in mobile
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 10 is max priority
        /// </summary>
        public int priority { get; set; }
        /// <summary>
        /// Android property
        /// </summary>
        public string android_group { get; set; }
        /// <summary>
        /// Android property
        /// use $[notif_count] for using total notification count
        /// </summary>
        public LocalizatedContent android_group_message { get; set; }
        /// <summary>
        /// Android property
        /// </summary>
        public string small_icon { get; set; }
        /// <summary>
        /// Android property
        /// </summary>
        public string large_icon { get; set; }
        /// <summary>
        /// Sets the background color of the notification circle to the left of the notification text. Only applies to apps targeting Android API level 21+ on Android 5.0+ devices.
        /// Example(Red) : "FFFF0000"
        /// </summary>
        public string android_accent_color { get; set; }

        public Notification()
        {
            include_player_ids = new List<string>();
        }
        public Notification(string playerId, LocalizatedContent _content)
        {
            this.included_segments = new List<string> { playerId };
            this.contents = _content;
        }
        /// <summary>
        /// returns proccess successful statement
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Send()
        {
            return await Sender.SendNotification(this);
        }
    }
}
