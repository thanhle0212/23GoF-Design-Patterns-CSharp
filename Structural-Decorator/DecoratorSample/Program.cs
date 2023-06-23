// See https://aka.ms/new-console-template for more information
using DecoratorSample;

// Create an instance of Concrete Component Notifier
INotifier notifier = new Notifier("The system is currently down!");

notifier = new SlackDecorator(notifier);

notifier = new FacebookDecorator(notifier);

notifier.SendMessage();