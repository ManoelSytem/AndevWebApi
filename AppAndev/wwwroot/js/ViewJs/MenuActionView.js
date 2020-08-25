function  obterViewController() {
    $.ajax({
        type: "get",
        url: "/Projeto/Index",
        success: function (data) {
            $("#Views").html(data);
        }
    })

}