namespace _08.Events
{
    class TestMain
    {
        static void Main()
        {
            Publisher p = new Publisher(1);     
            Listener l = new Listener(60);      
            l.Subscribe(p);                     
            p.Start();                          

            l.Unsubscribe(p);
        }
    }
}

