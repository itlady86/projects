$(function() {

    let interval = 500;
   // vrací posledních 20 zpráv
    update();
    zadejJmeno();

   function update() {
        $('.msgBox').empty();
        $.ajax({
            url: "http://vos.maple-webdesign.cz/wtk2/chat-seznam-zprav.php",
            method: 'GET',
        }).done(function getMessages(json) {
            let messages = JSON.parse(json);
            for (let i = 0; i < messages.length; i++) {
                let newMeta = document.createElement('p');
                let newMsg = document.createElement('p');
                let datum = messages[i].datum;
                newMeta.className = 'meta col-5';
                newMsg.className = 'content col-7';
                newMeta.textContent = formatujDatum(datum) + ' ' +  messages[i].jmeno;
                newMeta.style.color = messages[i].barva;
                newMsg.textContent = messages[i].zprava;
                $('.msgBox').append(newMeta);
                $('.msgBox').append(newMsg);
            }    
        })
        
    }

    // prompt čeká daný interval
    //zadání jména uživatele
    function zadejJmeno() {
        setTimeout(function() {
            let insertName = prompt("Zadej své jméno", "")
            if($("#name").text() !== ""){
                $("#name").text("");
            }
            $("#name").append(insertName).css("color", "black").css("font-size", "200%")}, interval);
    }

    
    function formatujDatum(datum) {
        let date = new Date(datum);
        day = date.getDate() < 10 ? '0' + date.getDate() : date.getDate() ;
        month = date.getMonth() + 1;
        year = date.getFullYear();
        hour = date.getHours() ;
        minutes = date.getMinutes() < 10 ? '0' + date.getMinutes() : date.getMinutes() ;
        seconds = date.getSeconds();
        // console.log(date.getDate)
        if(day.length < 2) 
            day = '0' + day;
        if(month.length < 2)                
            month = '0' + month;
        return day + ". " + month + ". " + year + " " + hour + ":" + minutes + ":" + seconds + "\n";
    }

    // zobrazení barev na paletě
    let hexadecimal = {
        color1: "rgb(255, 165, 0)",
        color2: "rgb(0, 255, 0)",
        color3: "rgb(0, 204, 255)",
        color4: "rgb(238, 130, 238)",
        color5: "rgb(212, 64, 64)"
    }
   
    
    $(".buttons button").on("click",function() {
        let rgb = $(this).css("background-color");
        if(rgb == hexadecimal.color1)
            $(".input").text("#FFA500");
            $("#name").css("color", rgb); 
        if(rgb == hexadecimal.color2)
            $(".input").text("#00FF00");
            $("#name").css("color", rgb); 
        if(rgb == hexadecimal.color3)
            $(".input").text("#00CCFF");
            $("#name").css("color", rgb); 
        if(rgb == hexadecimal.color4)
            $(" .input").text("#EE82EE");
            $("#name").css("color", rgb); 
        if(rgb == hexadecimal.color5)
            $(".input").text("#D43F3F");
            $("#name").css("color", rgb); 
    })
      

    //kliknutí na tlačítko Aktualizovat
    $('#update').on('click', function () {
        update();
    })

    // kliknutí na tlačítko Odeslat
    $("#send").on("click", function() {
        let todos = [$('#name').text(), $('textarea').val(), $('.input').text()];
        if (todos[0] == "") {
            alert ("Zadej jméno !");
            ZadejJmeno();
        }
        if (todos[1] == "")    
            alert("Zadej text zprávy !");
             
        if (todos[2] == "")
            alert ("Vyber si barvu !");
       
        $.ajax({
            url: 'http://vos.maple-webdesign.cz/wtk2/chat-nova-zprava.php',
            method: 'GET',
            data: {
                jmeno: $('#name').text(),
                zprava: $('textarea').val(),
                barva: $('.input').text()
            },   
            datatype: 'text'
            }).done(function(){
                $('textarea').val("");
                update();
            }).fail(function(){
                alert("Chyba: " + text);
            });
            
        
    })
             
});


