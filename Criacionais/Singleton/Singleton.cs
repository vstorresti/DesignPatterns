namespace Singleton
{
    public class Singleton
    {
        public void Executar()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if ( b1 == b2 && b2 == b3 && b3 == b4 )
                System.Console.WriteLine("Mesma instância");

            var balancer = LoadBalancer.GetLoadBalancer();

            for(var i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                System.Console.WriteLine("Disparando request para: " + serverName);
            }
        }
    }
}