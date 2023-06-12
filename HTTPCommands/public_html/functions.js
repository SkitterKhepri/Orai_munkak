/* 
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/ClientSide/javascript.js to edit this template
 */

var xhr=new XMLHttpRequest();
console.log(xhr);

function kuldes(){
    event.preventDefault(); //erre azért van szükség, hogy a submit automatizmusát megelőzzük    
    console.log("elindult...");
    xhr.open("PUT","http://localhost/valami.html",true);
    /*amint látható az open első paramétere lényegében a HTTP Command,
     * második paraméter egy URL
     * a harmadik pedig egy igaz/hamis logikai érték formájában a kommunikáció
     * aszinkron=true és szinkron=false voltát jelzi
     * A szinkron megoldás megvárja az ügyemenet befejeződését és csak azt követően 
     * lép tovább.  Az aszinkron egy esemény révén lesz képes az ügyemenet eredményéről
     * referálni
     */
    //A tényleges működés:
    //xhr.send(); //GET esetén nincs paraméter
    var parameter={};
    parameter.adat="adatom";
    xhr.setRequestHeader("Content-type","application/json; charset=utf-8");
    var db=0;
    xhr.onreadystatechange=function(){
        console.log(db+". "+xhr.readyState+": "+xhr.status);
        db++;
    }
    xhr.send(parameter); //szükséges minden más http command esetén
    /*pl. POST-nál: parameter="adat=adatom"; */
    console.log("elkészült...");
    console.log(xhr.response);
    console.log(xhr.responseText);
    console.log(xhr.responseXML);
}

function letoltes(){
    event.preventDefault();
        
    console.log("Elkezdődött...");
    var xhr=new XMLHttpRequest();
    //var url="https://rapidapi.com/guides/api/rest";
    var id=document.getElementsByName("id")[0].value;
    var url="";
    if(id!=""){
        url="https://jsonplaceholder.typicode.com/posts/"+id;
    }else{
        url="https://jsonplaceholder.typicode.com/posts";
    }
    xhr.open("GET",url,true);
    xhr.onreadystatechange=function(){
/*      console.log("Ready state: "+xhr.readyState);
        console.log("Tartalom TEXT: "+xhr.responseText);
        console.log("Tartalom OBJECT: "+xhr.response);
        console.log("Tartalom XML: "+xhr.responseXML);
        console.log("HTTP code: "+xhr.status+" "+xhr.statusText);
        console.log("======================================================");*/
        if(xhr.readyState==4 && xhr.status==200){
            tablazatkitoltes(xhr.responseText);
        }else if(xhr.status!=200){
            //window.alert(xhr.status);
            var hiba=document.querySelector(".hiba");
            hiba.innerHTML=id+" azonosító nem létezik";
        }
        
    }
    xhr.onprogress=function(esemeny){
        console.log(esemeny);
        if(esemeny.lengthComputable){
            console.log(esemeny.loaded/esemeny.total*100);
        }else{
            console.log(esemeny.total);
        }
    }    
    xhr.send();
}

function tablazatkitoltes(szoveg){
    var tomb=new Array();
    if(szoveg[0]=="["){
        tomb=eval(szoveg);
    }
    //mert [...] szerkezet a string-ünk
    /*for(var i=0;i<tomb.length;i++){
        //document.writeln(tomb[i]+"<br />");
        var objektum=tomb[i];
        for(elem in objektum){
            //document.writeln(objektum[elem]);
            document.writeln(eval("objektum."+elem));
        }
        document.writeln("<br />");
    }*/
    var tablazatoktombje=document.getElementsByTagName("table");
    //window.alert(tablazatoktombje);
    var tablatorzs=tablazatoktombje[0].tBodies[0];
    //window.alert(tablatorzs);
    //for(var elem in tablazatoktombje[0]) window.alert(elem);
    if(tomb.length!=0){
        var objektum=null;
        for(var i=0;i<tomb.length;i++){
            objektum=tomb[i];
            var sor=document.createElement("tr");
            for(var elem in objektum){
                var cella=document.createElement("td");
                cella.innerHTML=objektum[elem];
                sor.appendChild(cella);
            }
            var cella=document.createElement("td");
            cella.innerHTML=`
                <a onclick="torles(${objektum["id"]});">[Törlés]</a> 
                <a onclick="modositas(1);">[Módosítás]</a>
            `;
            sor.appendChild(cella);
            tablatorzs.appendChild(sor);
        }
    }else{
        var objektum=JSON.parse(szoveg);
        var sor=document.createElement("tr");
        for(var elem in objektum){
            var cella=document.createElement("td");
            cella.innerHTML=objektum[elem];
            sor.appendChild(cella);
        }
        tablatorzs.appendChild(sor);
    }
}

function torles(id){
    window.alert(id);
    var url="https://jsonplaceholder.typicode.com/posts/"+id;
    var xhr=new XMLHttpRequest();
    xhr.open("DELETE",url,true);
    xhr.onreadystatechange=function(){
        console.log(id+" azonosítójú tétel törölve");
    }
    xhr.send();
}

function modositas(id){
    var adatok={}
    adatok.UserId="nincs";
    adatok.id=id;
    adatok.title="ez is üres";
    adatok.body="itt sincs semmi";
    var json=JSON.stringify(adatok);
    var xhr=new XMLHttpRequest();
    var url="https://jsonplaceholder.typicode.com/posts/"+id;
    
    xhr.open("PUT",url,true);
    xhr.setRequestHeader("Content-type","application/json; charset=utf-8");
    xhr.onload=function(){
        var modositott=JSON.parse(xhr.responseText);
        if(xhr.readyState==4 && xhr.status==200){
            console.table(modositott);
        }else{
            console.error(modositott);
        }
    }

    xhr.send(json);
}