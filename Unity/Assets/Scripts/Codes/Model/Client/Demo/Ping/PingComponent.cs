namespace ET.Client
{
    [ComponentOf(typeof(Session))]
    public class PingComponent: Entity, IAwake, IDestroy
    {
        public C2G_Ping C2G_Ping = new C2G_Ping();

        public long Ping; //延迟值
    }
}