using  apiMorseEncoder.MorseEncoder;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "MORSE CODE!");

app.MapGet("/Encoder/{text}", (string text) =>{
    var morse = new  MorseEncoder();
    var t=morse.Encode(text);
    return t;

});

app.MapGet("/Decoder/{text}", (string text) =>{
    var morse = new  MorseEncoder();
    var t=morse.Decode(text);
    return t;

});

app.Run();
