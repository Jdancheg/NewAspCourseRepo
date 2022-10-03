namespace MetricsManager.Models
{
    public class AgentPool
    {
        // Это все, чтобы был только 1 объект типа AgentPool

        private static AgentPool _instance;

        public static AgentPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AgentPool();
                }
                return _instance;
            }
        }

        // 0. ----- Конструкторы ----- 
        public AgentPool()
        {
            Values = new Dictionary<int, AgentInfo>();
        }

        // 2. ------- Свойства -------
        public Dictionary<int, AgentInfo> Values { get; set; }


        // 3. -------- Методы --------

        public void Add(AgentInfo value)
        {
            if(!Values.ContainsKey(value.AgentId))
            {
                Values.Add(value.AgentId, value);
            }
        }
        public AgentInfo[] Get()
        {
            return Values.Values.ToArray();
        }
        
    }
}
