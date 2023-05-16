using BridgeSample;

ICommunication email = new EmailSender();
ICommunication sms = new SMSSender();

var systemSubject = "System Message";
var systemBody = "Hi, This is a Test Message from System";
Message systemMsgByEmail = new SystemMessage(email, systemSubject, systemBody);
systemMsgByEmail.Send();

Message systemMsgBySMS = new SystemMessage(sms, systemSubject, systemBody);
systemMsgBySMS.Send();

var userSubject = "User Message";
var userContentody = "Hi, This is a friendly message for user";
var userComment = "Have a nice day!";
Message userMsgByEmail = new UserMessage(email, userSubject, userContentody, userComment);
userMsgByEmail.Send();

Message userMsgBySMS = new UserMessage(sms, userSubject, userContentody, userComment);
userMsgBySMS.Send();


Console.ReadKey();

