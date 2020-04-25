using ExemploEnum.Entities; 
using ExemploEnum.Entities.Enums; //chamada do namespace enum
using System;

namespace ExemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                //com o enum criado, podemos ver as propridades do OrderStatus já sendo puxadas automaticamente
                Status = OrderStatus.PendingPayment 
            };
            Console.WriteLine(order);

            //conversões

            //conversão do tipo enum (neste caso é int) para texto
            string txt = OrderStatus.PendingPayment.ToString(); 
            Console.WriteLine(txt);

            //converter um string para o tipo enumerado(enum)
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //parse possui parâmetro<tipo> e dentro ("") possui o valor string
            Console.WriteLine(os);
        
        }
    }
}
