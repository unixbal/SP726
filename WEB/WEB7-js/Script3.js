// JavaScript source code
function change()
{
    var artclass = document.getElementById("artcile").classList[0];
    if (artclass=="Acik")
    {
        document.getElementById("artcile").classList.remove("Acik");
        document.getElementById("artcile").classList.add("Koyu");

    }

    if (artclass=="Koyu")
    {
        document.getElementById("artcile").classList.replace("Koyu", "Acik");
        
    }
}