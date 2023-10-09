
Console.WriteLine("Du tar en promenad i ditt lugna kvarter på kvällen. Helt plötsligt kommer en maskerad man upp till dig och skriker att du ska ge honom din mobil och alla dina pengar. Vad ska du göra nu? Svara 'spring' för att försöka fly från rånaren, eller svara 'slåss' för att ta dig an rånaren på egen hand.");
string robbery = Console.ReadLine().ToLower();

if (robbery == "spring")
{
    Console.WriteLine("Adrenalinet pumpar, du springer snabbare än aldrig förr. Du hade nog kunnat springa snabbare än Usain Bolt! Det du inte visste var att den maskerade rånaren faktiskt är Usain Bolt. Detta är hans debut som rånare, han är nervös och får också en adrenalinrush! Usain Bolt springer ifatt dig och hugger dig 12 gånger i ryggen. Du förblöder på trottoaren helt ensam, bara några minuter ifrån ditt hus...");
}

if (robbery == "slåss")
{
    Console.WriteLine("Som tur är har du erfarenhet av att slåss då du gick på boxning när du var 5 år gammal. Du låtsas ta upp pengar från din plånbok och överraskar rånaren med ett slag rätt på hakan! Han blir lite snurrig och börjar stappla. Adrenalinet har tagit över och du går på autopilot... Rånaren försöker sticka dig med sin fickkniv men du duckar lätt hugget och träffar honom med en klockren uppercut. Han är knocked out. Du tar av rånarluvan på mannen och inser vem det är. Usain Bolt..? Nu har du två val: 1. Göra det rätta och ringa polisen på Usain Bolt.      2. Ta Usain Bolts plånbok och fly från brottsplatsen. Han har säkert massa pengar på kontot. Svara '1' för att ringa polisen eller svara '2' för att råna honom och fly.");
    string RingEllerRåna = Console.ReadLine().ToLower();
    if (RingEllerRåna == "1")
    {
        Console.WriteLine("Du ringde polisen och de förde bort Usain Bolt. Straffet blev 100 000kr i skadestånd. Det var värt att ringa polisen trots allt.");
    }
    if (RingEllerRåna == "2")
    {
        Console.WriteLine("Du öppnade plånboken och allt som fanns var 50kr och en kupong för en macka på Subway TC. Det var inte värt att råna honom. 'Det kanske var därför han försökte råna mig' tänkte du.");
    }
}

else
{
   Console.WriteLine("Du skulle svara 'spring' eller 'slåss'. Nu svarade du inte någon av dem och då får du inte spela mer. Tänk på att följa instruktionerna nästa gång...");
   Thread.Sleep(4000);
   System.Environment.Exit(1);
}

Console.ReadLine();