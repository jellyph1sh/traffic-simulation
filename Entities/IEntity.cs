namespace TrafficSimulation.Entities
{
    interface IEntity
    {
        int Direction { get; set; }
        int Way { get; set; }
        string ToStringInfos();
    }    
}