Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);

//quantidade de dias igual a 0
if(daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
}

//quantidade de dias igual a 1
else if(daysUntilExpiration == 1){
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}

//quantidade de dias menor/igual a 5
else if(daysUntilExpiration <=5){
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}

//quantidade de dias menor/igual a 10
else if(daysUntilExpiration <=10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}