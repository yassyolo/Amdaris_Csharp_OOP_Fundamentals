using Assessment12;
using Assessment12.NotificationManager;
using Assessment12.NotificationService;
using Assessment12.NotificationSubscriber;

var notificationManager = new NotificationManager();

var user1 = new User("Yoana");
var user2 = new User("Mariela");
notificationManager.Subscribe(user1);
notificationManager.Subscribe(user2);

var emailService = new EmailNotificationService();
var smsService = new SMSNotificationService();
var pushService = new PushNotificationService();

var notificationServiceManager = new NotificationServiceManager(notificationManager);
notificationServiceManager.RegisterService(emailService);
notificationServiceManager.RegisterService(smsService);
notificationServiceManager.RegisterService(pushService);

notificationServiceManager.SendNotification((user1.Name), "Welcome to the messaging app!");
notificationServiceManager.SendNotification((user2.Name), "Welcome to the messaging app!");