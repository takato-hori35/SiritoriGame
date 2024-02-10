using System;

class Shiritori
{
  static void Main(string[] args) {
    Console.WriteLine("しりとりスタート！");
    Console.WriteLine("最初の単語を入力してください");
    string lastWord = Console.ReadLine();
    string nextWord; // while条件で使うため先に定義
    char lastChar = lastWord[lastWord.Length - 1];

    do {
      Console.WriteLine($"{lastChar}で始まる単語:");
      nextWord = Console.ReadLine();

      if(nextWord.EndsWith("ん")) {
        Console.WriteLine("ゲームオーバー: 単語が「ん」で終わっています。");
        break;
      }

      if(lastChar != nextWord[0]) {
        Console.WriteLine($"ゲームオーバー: '単語が{lastChar}'で始まっていません。");
        continue;
      }

      lastChar = nextWord[nextWord.Length - 1]; // 次の単語の最後の文字を更新
    } while(nextWord != "終了");

    Console.WriteLine("しりとりを終了します。");
  }
}

