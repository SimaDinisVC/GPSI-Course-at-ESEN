const frmauthors = document.querySelector("#frmauthors");


// lista cada registo com botões para editar e remover
function getDataTable() {
    const response = document.querySelector("#response");
    $.ajax({
        url: 'getData_item.php',
        type: 'get',
        success: function(responsedata) {
            response.innerHTML = responsedata;
        },
        error: function() {
            console.log("erro")
        }
    });
}

// Manda guardar um registo na tabela
function insertDataTable(e) {
    // prevent form loading
    e.preventDefault();

    const inputAuthor = document.querySelector("#inputAuthor");
    const inputMessage = document.querySelector("#inputMessage");
    const warning = document.querySelector("#warning");

    // verifica se os campos não foram preenchidos
    if (inputAuthor.value == "" && inputMessage.value == "") {
        warning.style.display = "block";
        warning.innerHTML = "Preencha os campos...";
    } else {
        $.ajax({
            url: "insertData.php",
            type: "post",
            //data: $("#frmauthors input").serialize(),
            data: "inputAuthor=" + inputAuthor.value + "&inputMessage=" + inputMessage.value,
            //data: {inputAuthor:inputAuthor.value,inputMessage:inputMessage.value},
            success: function(data) {
                // data guarda o valor 1 ou 0
                inputAuthor.value = "";
                inputMessage.value = "";

                warning.style.display = "none";	// hide
                
                getDataTable()
            }
        });
    }
}


// grava os dados do modal na tabela comments
function saveEdit(){
      
    // https://gomakethings.com/how-to-serialize-form-data-with-vanilla-js/
    // Recupera os dados do formulário
    var frmedit = document.getElementById("frmedit");

    var formData = new FormData(frmedit);
    
    $.ajax({
        url: "saveedit.php",
        type: "post",
        data: formData,
        success: function(data) {
            // atualiza os valores da tabela
            getDataTable();
        }
    });
}


// display values on modal form
// id - representa o identificado do elemento na tabela
function editData(id) {
    let edit_item_model = document.querySelector("#edit-item-model");

    $.ajax({
        url: "editData.php",
        type: "post",
        data:"id=" + id,	// passa o id do elemento no ficheiro editData.php
        success: function(data) {
            edit_item_model.innerHTML = data;
        }
    });
}

// remove o registo na tabela comments
function removeData(id) {
    $.ajax({
        url: "removeData.php",
        type: "post",
        data: "id="+id,
        success: function(data) {
            getDataTable();
        }
    });
}

// Ao carregar a página espera pelo eventos
document.addEventListener("DOMContentLoaded", function(event) {

    const btsaveEdit = document.querySelector("#saveEdit");
    
    frmauthors.addEventListener("submit", function(event) {
        insertDataTable(event);
    });

    btsaveEdit.addEventListener("click", function() {
        saveEdit()
    });

    getDataTable();
});