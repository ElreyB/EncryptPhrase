using System;

class EncryptPhrase
{
  static void Main()
  {
    Console.WriteLine("What phrase would you like in encrpted: ");
    string inputPhrase = Console.ReadLine();
    string inputPhraseEncrypted = inputPhrase.Replace( "a", "**");

    Console.WriteLine(inputPhraseEncrypted);
  }
}
