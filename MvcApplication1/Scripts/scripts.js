function Count() {
    $.ajax({
        url: "Counter/Increment",
        data: {
            val: $('#txtNum').val()
        },      
        async: false,
        success: function (data) {
            $('#txtNum').val(data);
        },
        error: function (e, t, m) {
            alert(e);
        }
    });
}