// See https://aka.ms/new-console-template for more information
using SingletonSample;

Thread process1 = new Thread(() => {
    Singleton singleton  = Singleton.GetInstance("Instance 1");
    singleton.Print(singleton.InitialValue);
});

Thread process2 = new Thread(() => {
    Singleton singleton  = Singleton.GetInstance("Instance 2");
    singleton.Print(singleton.InitialValue);
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();