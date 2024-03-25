using  apiMorseEncoder.MorseEncoder;



var builder = WebApplication.CreateBuilder(args);

 
//Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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
