// JavaScript source code
class inputs
{
    constructor()
    {
        this.sayi;
    }
    SayiGoster(giris)
    {
        var txt = "";
        for (var i = 0; i <= giris; i++) {
            if (i % 3 == 0) {
                txt = txt + " " + i;
            }
        }
        document.getElementById("sayi").innerHTML = txt;
        return txt;
    }
}
function SayiDeger()
{
    var giris = Number(document.getElementById("input").value);
    var s1 = new inputs();
    alert(s1.SayiGoster(giris));

}
function colors()
{
    document.getElementById("color").style.backgroundColor = document.getElementById("color").value;
}