/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string OriginalMessage = "The quick brown fox jumps over the lazy dog";

char[] message = OriginalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;
foreach(char letter in message){
    if(letter == 'o') {
        letterCount++;
    }
}

//está convertendo a mensagem de Char array para string.
string newMessage = new String(message);

Console.WriteLine(newMessage.ToString());
Console.WriteLine($"'o' appears {letterCount} times.");


//testando se funcionaria sem a função de converter para string
// string messageValue = "The quick brown fox jumps over the lazy dog";

// char[] message = messageValue.ToCharArray();
// Array.Reverse(message);
// Console.WriteLine(message);