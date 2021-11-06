// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
//numero randomicos, pra simular o rolar de dados

int roll1 = 1;
int roll2 = 1;
int roll3 = 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//quando dois dados forem rolados com o mesmo valor irá executar a segunda instrução, caso três dados sejam iguais, irá executar a primeira instrução
if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    if((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("You rolled doubles! +4 bonus to total!");
        total +=6;
    }
    else{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total +=2;
    }
}

if(total >= 15){
    Console.WriteLine("You Win!");
}
else{
    Console.WriteLine("Sorry, you lose!");
}

//Quando precisamos que apendar uma das funções seja executada, usamos o else if e no final o else caso nenhuma das condições anteriores tenha sido atingida.
if (total >= 16){
   Console.WriteLine("You win a new car!");
}
else if(total >= 10){
    Console.WriteLine("You win a new laptop!");
    }

else if (total == 7) {
    Console.WriteLine("You win a trip for two!");
}
else {
    Console.WriteLine("You win a kitten!");
}