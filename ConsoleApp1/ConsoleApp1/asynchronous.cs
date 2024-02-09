using System;

namespace AsynchronousProgram {
    class Program
    {
        
        class Asynchronous
        {
            public async void runTAsk()
            {
                Console.WriteLine("Asyunchronous programmming");
                await Task.Delay(1000);
                Console.WriteLine("Delayed task");
            }
        }
    }

}