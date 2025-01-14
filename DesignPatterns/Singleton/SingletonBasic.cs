namespace DesignPatternsWebApi.DesignPatterns.Singleton
{
    public class SingletonBasic
    {
        private static SingletonBasic _instance;
        private static readonly object _lock = new object();

        private SingletonBasic() { }

        public static SingletonBasic Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonBasic();
                    }
                    return _instance;
                }
            }
        }

        public string GetMessage() => "Singleton Instance Created!";
    }
}