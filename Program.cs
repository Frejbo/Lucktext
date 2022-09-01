string[] questions = {"Vad heter du?", "Hur gammal är du?", "Hur lång är du?", "Vad heter din hamster?", "Har du en hamster?"};

List<string> answers = new List<string>();

foreach (string ask in questions) {
    Console.WriteLine(ask);
    answers.Add(Console.ReadLine());
}


Console.WriteLine("Uploading personal data to tracker.facebook.com");

for (string i = "."; i != "....";  i = i+".") {
    System.Threading.Thread.Sleep(400);
    Console.WriteLine(i);
    System.Threading.Thread.Sleep(250);
}

if (answers[4].ToLower().Contains("ej")) {
    Console.WriteLine($"Hej {answers[0]}, har du verkligen ingen hamster som heter {answers[3]}? Känns olikt dig, fast i och för sig... du är ju faktiskt lite som en hamster själv, med ditt {answers[1]} års gamla skinn. Du skulle säkert ändå trampa ihjäl den eftersom du är så mycket längre än den. du är ju {answers[2]} medan den bara är ca 15 cm...");
} else {
    Console.WriteLine($"Hej {answers[0]}, har du verkligen en hamster som heter {answers[3]}? Känns inte så rimligt... det är liksom ett otroligt konstigt namn på en hamster... inte sant? Men jag antar att det är sån du är, hade inte förväntat mig så mycket mer om jag ska vara ärlig... du är ju faktiskt lite som en hamster själv. Visste du att {answers[1]} åringar som är {answers[2]} långa tenderar att vara mycket sämre på att döpa just hamstrar? Eller nej förstås... sånt vet ju inte du...");
}

Console.ReadLine(); //Behåller terminalen öppen tills något trycks.