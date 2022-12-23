using DelegateCsharp;
//Cách 1
Mathems ma = new();
ma.Add(10, 5);
//Cách 2
new Mathems().Multi(10, 5);
//Cách 3
Mathems.Sub(10, 5);
//Deletegate
Abc dele = new Mathems().Div;
dele(10, 5);// safe thread