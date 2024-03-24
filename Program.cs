using  apiMorseEncoder.MorseEncoder;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/Encoder/{text}", (string text) =>{
    var morse = new  MorseEncoder();
    var t=morse.Encode(text);
    return t;

});

app.Run();

/* private static void Main()
{
    var text = "welcome to the new age";
    var morse = new MorseEncoder();

    string morseCode = morse.Encode(text);

    Console.WriteLine(morseCode);
    Console.Read();
}
 */
