using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using final;

namespace puebasFinal;

[TestClass]
public class FinalTest
{
    [TestMethod]
    public void totalpedidosbarriostest()


    {

        //Totalizapedidosbarrios va contar a manrique cada vez que lo encuentre como un pedido,
        //en este caso esta tres veces y asi se inicializan las variables de tipo Pedido()

        Pedido[] PedidoBarrio = new Pedido[4];
        PedidoBarrio[0] = new Pedido();
        PedidoBarrio[0].Barrio = "Manrique";
        PedidoBarrio[0].CantidadGalletas = 10;

        PedidoBarrio[1] = new Pedido();
        PedidoBarrio[1].Barrio = "Manrique";
        PedidoBarrio[1].CantidadGalletas = 15;

        PedidoBarrio[2] = new Pedido();
        PedidoBarrio[2].Barrio = "Manrique";
        PedidoBarrio[2].CantidadGalletas = 10;

        PedidoBarrio[3] = new Pedido();
        PedidoBarrio[3].Barrio = "Manrifle";
        PedidoBarrio[3].CantidadGalletas = 16;

        //arrange
        //segun veo esta variable no nos sirve para esta prueba, no la toma en cuenta
        string[] barrios = new string[] { "Manrique", "Manrique", "Manrique", "Manrifle" };
        int[] pedidosresult;

        //act
        pedidosresult = Program.TotalizaPedidosBarrio(PedidoBarrio, barrios);

        int pedidosEsperados = 3;

        //
        Console.WriteLine("la cantidad de pedidos por barrios fue:");

        Console.WriteLine(PedidoBarrio[1].Barrio);


        if (PedidoBarrio[0].Barrio == "Manrique" & PedidoBarrio[1].Barrio == "Manrique" & PedidoBarrio[2].Barrio == "Manrique")
        {
            Console.WriteLine("con un total de:");
            Console.WriteLine(PedidoBarrio[0].CantidadGalletas + PedidoBarrio[1].CantidadGalletas + PedidoBarrio[2].CantidadGalletas);
        }
        if (PedidoBarrio[3].Barrio == "Manrifle")
        {
            Console.WriteLine("y manrifle con :");
            Console.WriteLine(PedidoBarrio[3].CantidadGalletas);

        }

        // Console.WriteLine(pedidosEsperados);
        //  Console.WriteLine("holabebe");
        Assert.AreEqual(pedidosEsperados, pedidosresult[2]);


    }

    [TestMethod]
    public void totalgalletasbarriostest()


    {

        //Totalizapedidosbarrios va contar a manrique cada vez que lo encuentre como un pedido,
        //en este caso esta tres veces y asi se inicializan las variables de tipo Pedido()

        Pedido[] PedidoGalletas = new Pedido[4];
        PedidoGalletas[0] = new Pedido();
        PedidoGalletas[0].Barrio = "Jardin";
        PedidoGalletas[0].CantidadGalletas = 890;

        PedidoGalletas[1] = new Pedido();
        PedidoGalletas[1].Barrio = "Manrique";
        PedidoGalletas[1].CantidadGalletas = 420;

        PedidoGalletas[2] = new Pedido();
        PedidoGalletas[2].Barrio = "Manrique";
        PedidoGalletas[2].CantidadGalletas = 420;

        PedidoGalletas[3] = new Pedido();
        PedidoGalletas[3].Barrio = "manrifle";
        PedidoGalletas[3].CantidadGalletas = 650;

        //arrange
        //segun veo esta variable no nos sirve para esta prueba, no la toma en cuenta
        string[] barrios = new string[] { "Jardin", "Manrique", "Manrique", "manrifle" };
        int[] galletasresult;

        //act


        galletasresult = Program.TotalizaPedidosBarrio(PedidoGalletas, barrios);

        int pedidosEsperados = 2;

        Console.WriteLine("la cantidad de galletas pedidas por barrio fueron:");

        Console.WriteLine(PedidoGalletas[1].Barrio);

        
        if (PedidoGalletas[1].Barrio == "Manrique" & PedidoGalletas[2].Barrio == "Manrique")
        {
            Console.WriteLine("con un total de:");
            Console.WriteLine(PedidoGalletas[1].CantidadGalletas + PedidoGalletas[2].CantidadGalletas );
        }
        Console.WriteLine(PedidoGalletas[3].Barrio);

        if (PedidoGalletas[3].Barrio == "manrifle")
        {
            Console.WriteLine("y manrifle con :");
            Console.WriteLine(PedidoGalletas[3].CantidadGalletas);

        }
        Console.WriteLine(PedidoGalletas[0].Barrio);

        if (PedidoGalletas[0].Barrio == "Jsssardin")
        {
            Console.WriteLine("y jardin con :");
            Console.WriteLine(PedidoGalletas[0].CantidadGalletas);

        }
        //

        //Console.WriteLine(pedidosresult[2]);
        // Console.WriteLine(pedidosEsperados);
        //  Console.WriteLine("holabebe");
        Assert.AreEqual(pedidosEsperados, galletasresult[2]);


    }

}
