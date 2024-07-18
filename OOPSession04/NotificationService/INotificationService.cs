using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession04.NotificationService
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);
    }
}
