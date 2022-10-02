namespace MetricsManager.Models
{
    public class AgentPool
    {
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
