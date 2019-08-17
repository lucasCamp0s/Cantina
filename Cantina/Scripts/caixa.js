function pedidos() {
    var div = document.getElementById('IncluindoPedidos');
    
    let quantidade = document.getElementsByName('quantidade')[0].value;
    let produto = document.getElementsByName('produto')[0].value;
    let valorUnitario = document.getElementsByName('valorUnitario')[0].value;
    let valorTotal = document.getElementsByName('valorTotal')[0].value;
    

    div.innerHTML += " <div class='col-xs-2'><input type='text'value='"+ quantidade +"'placeholder='' size='20px' /></div>" + 
    "  <div class='col-xs-2'><input type='text' value= '"+produto+"' placeholder='' /></div>" + 
    "<div class='col-xs-2'><input type='text' value='"+ valorUnitario + "'placeholder='' /></div>" +
    " <div class='col-xs-2'><input type='text' value='"+ valorTotal + "' placeholder=''/></div>"+
    " <div class='col-xs-2'></div></br></br>";
}

function miniCalculadora(quantidade,valor) {
    alert(quantidade, valor);
}

function salvarBanco() {
    var div = document.getElementById('IncluindoPedidos').innerHTML = "";
    alert('incluir');
}

function cadastrarUser() {
    var url = "http://localhost:12024/clientes/Create";
    var Cpg = "6666666";
    var Nome = "lucifer";
    var Email = "luci@gmail.com";
    var Telefone = "606060606";
    $.post(url, { cpg: Cpg, nome: Nome, email: Email, telefone: Telefone },alert("success"));
}
function RecuperarUsuario() {
    $.ajax(
    {
        type: "POST",
        url: "/clientes/Create",
        contentType: "application/json",
        success:
        function (resultado) {
            alert(resultado.cpg);
            alert(resultado.email);
        },
    });
    }


// With the element initially shown, we can hide it slowly:
// With the element initially shown, we can hide it slowly:
// With the element initially shown, we can hide it slowly:
