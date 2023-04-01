decimal valorpago, valorproduto, troco;

Console.WriteLine("Qual o valor do produto? ");
valorproduto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual o valor pago? (em R$) ");
valorpago = Convert.ToDecimal(Console.ReadLine()); 

troco = (valorpago - valorproduto);

Console.WriteLine($"O valor do troco é R${troco}");