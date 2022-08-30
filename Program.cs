string[] questions = {"Vad heter du?", "Hur gammal är du?", "Hur lång är du?", "Vad heter din hamster?", "Har du en hamster?"};
// string[] answers = new string[4]; //"", "", "", "", ""};

List<string> answers = new List<string>();

int index = 0;
foreach (string ask in questions) {
    Console.WriteLine(ask);
    // answers[index] = ;
    // if (ask == questions[2] && )
    answers.Append(Console.ReadLine());
    index = index++;
}

Console.WriteLine("Uploading personal data to tracker.facebook.com");

for (string i = "."; i != "....";  i = i+".") {
    System.Threading.Thread.Sleep(400);
    // Console.WriteLine(string.Join(i, "."));
    Console.WriteLine(i);
    System.Threading.Thread.Sleep(250);
}
Console.WriteLine(answers[4].Contains("ej"));
if (answers[4].Contains("ej")) {
    Console.WriteLine($"Hej {answers[0]}, har du verkligen ingen hamster som heter {answers[3]}? Känns olikt dig, fast i och för sig... du är ju faktiskt lite som en hamster själv, med ditt {answers[1]} års gamla skinn. Du skulle säkert ändå trampa ihjäl den eftersom du är så mycket längre än den. du är ju {answers[2]} medan den bara är ca 15 cm...");
} else {
    Console.WriteLine($"Hej {answers[0]}, har du verkligen en hamster som heter {answers[3]}? Känns inte så rimligt... det är liksom ett otroligt konstigt namn på en hamster... inte sant? Men jag antar att det är sån du är, hade inte förväntat mig så mycket mer om jag ska vara ärlig... du är ju faktiskt lite som en hamster själv. Visste du att {answers[1]} åringar som är {answers[2]} långa tenderar att vara mycket sämra på att döpa just hamstrar? Eller nej förstås... sånt vet ju inte du...");
}


Console.ReadLine();

// for (int i = 0; i < 3; i++) {
//     Console.ReadLine;
// }

// Console.WriteLine("Vad heter du?");
// string name = Console.ReadLine();

// Console.WriteLine($"Hej {name}");

// int count = 0;

// Console.ReadLine();
// // while (true) {
// //     Console.WriteLine(name);
// // }