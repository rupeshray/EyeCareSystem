$(function () {
    $.ajaxSetup({ cache: false });
    $(document).delegate("a[data-ajax-model]", "click", function (e) {
        document.getElementById('mask').className = 'loading'
        $('#myModalContent').load(this.href, function (responseTxt) {
            document.getElementById('mask').className = ''
            if (responseTxt.length === 0) {
                toastr.error('Please Check Application Error')
            } else {
                $('#myModal').modal({
                    keyboard: true
                }, 'show');
                bindAjaxForm(this);
            }
        });
        return false;
    });
});

function bindAjaxForm(dialog) {
    $('#ajaxForm').ajaxForm({
        success: function (data, textStatus, xhr) {
            if (data === '"_Login_"') {
                window.location = "/Authentication/LogOff";
                return;
            }
            $('#myModal').modal('hide');
            $('#container').html(data);
        },
        error: function (xhr, status) {
            $('#myModalContent').html(xhr.responseText, xhr.status);
            // enable reserve button again
            $('#btnSubmit').val($('#btnSubmit').val());
            $('#btnSubmit').prop('disabled', false);
            bindAjaxForm(dialog);
        }
    }).submit(function () {
        $('#btnSubmit').val("Processing.....");
        $('#btnSubmit').prop('disabled', true);
    });
    return false;
}


//Confirmation
$(function () {
    $.ajaxSetup({ cache: false });
    $(document).delegate("a[data-ajax-confirmation]", "click", function (e) {
        document.getElementById('mask').classList.add('loading')
        $('#confirmModalContent').load(this.href, function (responseTxt) {
            document.getElementById('mask').classList.remove('loading')
            if (responseTxt.length === 0) {
                toastr.error('Please Check Application Error')
            }
            else {
                $('#confirmationModal').modal({
                    keyboard: true
                }, 'show');
            }
        });
        return false;
    });
});
