$(document).on("click", "#Pagination_List a", function () {
    if ($(this).attr("href") === null) return false;
    document.getElementById('mask').classList.add('loading')
    $.ajax({
        url: $(this).attr("href"),
        type: 'GET',
        cache: false,
        dataType: 'HTML',
        contentType: false,
        processData: false,
        success: function (result) {
            $('#container').html(result);
            document.getElementById('mask').classList.remove('loading')
        },
        error: function (error) {
            alert(error);
        }
    });
    return false;
});

//Search By PageSize

