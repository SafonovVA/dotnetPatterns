namespace Singleton.Classes
{
    public static class Singleton
    {
        private static Test _instance;

        public static Test GetInstance()
        {
            if (_instance != null) return _instance;
            _instance = new Test();
            return _instance;

        }
    }
}