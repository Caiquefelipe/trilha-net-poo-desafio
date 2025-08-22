using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(123456789, "Nokia 3310", "123456789012345", "32MB");

Iphone iphone = new Iphone(987654321, "iPhone 13", "987654321098765", "128GB");


//nokia
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

//iphone
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
