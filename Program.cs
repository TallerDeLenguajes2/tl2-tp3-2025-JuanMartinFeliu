using System;
using Clientes;

//Defino un cliente
string nombreCliente1 = "Juan";
string direccionCliente1 = "🤐🤐";
string telefonoCliente1 = "3814586779";
string referenciaCliente1 = "Porton negro";

Cliente cliente1 = new Cliente(nombreCliente1,direccionCliente1,telefonoCliente1,referenciaCliente1);

//Defino un cadete
int idCadete = 1234;
string nombreCadete = "Alfonso";
string telefonoCadete = "3815697415";
string direccionCadete = "Santo Domingo 542";

Cadete cadete1 = new Cadete(idCadete, nombreCadete, direccionCadete, telefonoCadete);

//Creo un pedido
int numeroPedido1 = 64;
string obsPeiddo1 = "Que este caliente";
Cliente clientePedido1 = cliente1;
string estadoPedido1;
Cadete cadetePedido1 = cadete1;

Pedidos pedido1 = new Pedidos(numeroPedido1, obsPeiddo1, cliente1);

string pruebaDireccion = pedido1.VerDireccionClientes(cliente1);
Console.WriteLine($"Direccion del cliente 1: {pruebaDireccion}");

Console.WriteLine("\n-------------------------------------------------------------------------------------\n");

string datosCliente1 = pedido1.VerDatosCliente(cliente1);
Console.WriteLine($"Datos del Cliente 1: {datosCliente1}");