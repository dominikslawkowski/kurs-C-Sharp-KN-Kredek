    
    var numer = Math.floor(Math.random()*5)+1;
		
    var timer1 = 0;
    var timer2 = 0;
		
    function ustawSlajd(nr)
    {
        clearTimeout(timer1);
        clearTimeout(timer2);
        numer = nr -1;
		
        schowaj();
        setTimeout("zmienSlajd()", 500);
    }
		
    function schowaj()
    {
        $("#box").fadeOut(500);
    }

    function zmienSlajd()
    {
        numer++;
        if(numer>5) numer = 1;
			
        var plik = "<img src = \"slajdy/slajd" + numer + ".png\" width=\"800\" height=\"350\">";
			
        document.getElementById("box").innerHTML = plik;
        $("#box").fadeIn(500);
		
        timer1 = setTimeout("zmienSlajd()", 4000);
        timer2 = setTimeout("schowaj()", 3500);
    }

    function aboutJoel()
    {
        document.getElementById("cartBox").classList.remove('active');
        
        document.getElementById("box").innerHTML = "";
        clearTimeout(timer1);
        clearTimeout(timer2);
        
        var about = "<font size =\"3\"><font size=\"4\" color=\"deeppink\">Joel Thomas Zimmerman</font> <font color = \"#C7C7C7\">(born January 5, 1981), better known by his stage name deadmau5, is a Canadian" 
                    +" record producer and DJ from Toronto, Ontario. Zimmerman produces a variety of styles within the progressive"
                    +" house genre and sometimes other forms of electronic music. His tracks have been included in numerous"
                    +" compilation albums, such as the 2007 In Search of Sunrise 6: Ibiza CD. The February 2008 issue of Mixmag's"
                    +" music magazine included a free CD which was titled MixMag Presents: The Hottest New Name In Dance!"
                    +" DEADMAU5 Tech-Trance-Electro-Madness, mixed by Zimmerman. Tracks have also been included and presented"
                    +" on Armin van Buuren's A State of Trance radio show. His debut album, Get Scraped, was released in 2005,"
                    +" followed by others in the next few years.</br> <font size=\"6\">★★★★★★★★★★★★★★★★★★★★</font></font></font>";
        document.getElementById("box").innerHTML = about;
    }

    function photos()
    {
        document.getElementById("cartBox").classList.remove('active');

        document.getElementById("box").innerHTML = "";
        var plik = "<img src = \"slajdy/slajd" + numer + ".png\" width=\"800\" height=\"350\">";
        document.getElementById("box").innerHTML = plik;
     
        zmienSlajd();
    }
		

    

    var divTotal = document.createElement('div');
    divTotal.id = "total";
    divTotal.textContent = "Total Price: ";

    var divPrice = document.createElement('div');
    divPrice.id = "price";
    divPrice.textContent = "0.0";

    var divDelete = document.createElement('div');
    divDelete.className = "delete";
    divDelete.textContent = "Delete";

    var divBuy = document.createElement('div');
    divBuy.className = "delete";
    divBuy.style.marginLeft = '40px';
    divBuy.textContent = "Buy";


    function sklep()
    {
        document.getElementById("box").innerHTML = "";
        clearTimeout(timer1);
        clearTimeout(timer2);
    


       document.getElementById("box").innerHTML = 
       "<div class=\"segment\">\
        <div class=\"music\"> <img src=\"albumy/4x4=12.jpg\" width=\"120px\" height=\"80px\"></div>\
             <b2>Title:</b2>  <b3>4x4=12</b3></br> \
             <b2>Price:</b2>  <b3>14,99$</b3> \
             <div class=\"add\" onclick=\"addToCart(price[0])\">Add</div>\
        </div>\
        <div class=\"segment\">\
            <div class=\"music\"> <img src=\"albumy/ForLackofaBetterNameAlbum.jpg\" width=\"120px\" height=\"80px\"></div>\
                 <b2>Title:</b2>  <b3>For Lack of a Better Name</b3></br> \
                 <b2>Price:</b2>  <b3>10,99$</b3>\
                 <div class=\"add\" onclick=\"addToCart(price[1])\">Add</div>\
        </div>\
        <div class=\"segment\">\
            <div class=\"music\"> <img src=\"albumy/Album_Title_Goes_Here.jpg\" width=\"120px\" height=\"80px\"></div>\
                 <b2>Title:</b2>  <b3>Album Titles Goes Here</b3></br> \
                 <b2>Price:</b2>  <b3>21,99$</b3>\
                 <div class=\"add\" onclick=\"addToCart(price[2])\">Add</div>\
        </div>";

        document.getElementById("cartBox").appendChild(divTotal);
        document.getElementById("cartBox").appendChild(divPrice);
        document.getElementById("cartBox").appendChild(divDelete);
        document.getElementById("cartBox").appendChild(divBuy);

        document.getElementById("cartBox").classList.add('active');

       document.getElementsByClassName("delete")[0].onclick = function(){_delete()};
       document.getElementsByClassName("delete")[1].onclick = function(){_delete()};
    }
    
    var price = [14.99, 10.99, 21.99];
    var total = 0.00;


    function addToCart(price) {
        document.getElementById("price").innerHTML = total + price + " $";
        total += price;
    }
    
    function _delete()
    {
        document.getElementById("price").innerHTML = 0.0;
        total = 0.0; 
    }

   