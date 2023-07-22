namespace sampleTwo{
     public class Engine{
        public enum Status {Started, Stopped};
        /*declare my first Delegate*/
        public delegate void StatusChange(Status status);/*Takes the status*/
        private StatusChange statusChangeHandler;
        public void RegisterStatusChangeHandler(StatusChange handler)
        {
            statusChangeHandler = handler;
        }
        public void Start()
        {
        // start the engine
            if (statusChangeHandler != null)
            statusChangeHandler(Status.Started);
        }
        public void Stop()
        {
        // stop the engine
            if (statusChangeHandler != null)
            statusChangeHandler(Status.Stopped);
        }

        // static void Main(string[] args)
        //     {
        //         Engine engine = new Engine();
        //         engine.RegisterStatusChangeHandler
        //         (OnEngineStatusChanged);
        //         engine.Start();
        //         engine.Stop();
        //     }
        //     private static void OnEngineStatusChanged(Status status)
        //     {
        //     Console.WriteLine($"Engine is now {status}");
        //     }
    }
}