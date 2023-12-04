<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <link rel="" href="url"/>        
        <style>
            .container{
                background-color: red; 
            }
            .forma{
                display: inline;
            }
        </style>
    </head>
    <body>
        <?php
            echo '<div class="btn btn-primary ms-5 mt-5">Laconia falling</div>';            
        ?>
        
        <a class="btn btn-success ms-1 mt-5" href="https://parahumans.wordpress.com">Worm</a>
        <div class="forma" id="forma">
            <div></div> 
        </div>
        <div class="container">
            Twig
        </div>
        <script>
            function tovabb(){
                event.preventDefault();
                if (document.getElementById("password").value !== document.getElementById("password2").value){
                    document.getElementById("password").value = "";
                    document.getElementById("password2").value = "";
                }
            }
            function regisztracio(){
                document.getElementById("forma").innerHTML = `
                <div class="mb-3">
                    <label class="form-label" for="nev">Név:</label>
                    <input id="nev" class="form-control" type="text" placeholder="Név" name="nev">
                </div>
                <div>
                    <label class="form-label" for="email">Email:</label>
                    <input class="form-control" id="email" type="email" placeholder="Email" name="email">
                </div>
                <div>    
                    <label class="form-label" for="password">Jelszó először:</label>
                    <input class="form-control" id="password" type="password" placeholder="Jelszó" name="password">
                </div>
                <div>
                    <label class="form-label" for="password2">Jelszó másodszor:</label>                    
                    <input class="form-control" id="password2" type="password" placeholder="Jelszó" name="password2">
                </div>
                <button class="btn btn-warning">Vége</button>`;
            }
            regisztracio();
        </script>
    </body>
</html>
