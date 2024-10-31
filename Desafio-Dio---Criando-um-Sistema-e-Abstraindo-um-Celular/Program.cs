using DesafioPOO.Models;

Nokia nokia = new Nokia("11982642931","Nokia Z2", "111119999", 100);

Iphone iphone = new Iphone("11982642931", "Iphone 8", "55558888", 95, "12345678");

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

// TODO: Realizar os testes com as classes Nokia e Iphone