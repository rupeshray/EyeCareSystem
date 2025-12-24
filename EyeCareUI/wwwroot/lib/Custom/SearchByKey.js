'use strict'
function AjaxRequest(pagination) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: paramModel.ListURL,
            method: 'GET',
            dataType: 'HTML',
            cache: false,
            async: true,
            data: pagination,
            success: resolve,
            error: (jqXHR, textStatus, errorThrown) => reject(new Error(textStatus + ': ' + errorThrown))
        });
    });
}
async function SearchData(param) {
    try {
        document.getElementById('mask').classList.add('loading')
        const data = await AjaxRequest(param);
        if (data == '"_Login_"') {
            window.location = "/Authentication/LoginAsync";
            return;
        }
        document.getElementById('mask').classList.remove('loading')
        document.getElementById('container').innerHTML = data;
    }
    catch (error) {
        toastr.error(error);
    }
}

//const submitForm = async () => {
//    return new Promise((resolve, reject) => {
//        document.getElementById('ajaxForm').ajaxForm({
//            success: function (response) {
//                resolve(response);
//            },
//            error: function (xhr, status, error) {
//                reject(error);
//            }
//        });
//    });
//}

//const CreateForm = async (param) => {
//    return new Promise((resolve, reject) => {
//        $.ajax({
//            url: paramModel.CreateURL,
//            method: 'GET',
//            dataType: 'HTML',
//            cache: false,
//            async: true,
//            data: param,
//            success: resolve,
//            error: (jqXHR, textStatus, errorThrown) => reject(new Error(textStatus + ': ' + errorThrown))
//        });
//    });

//}

//document.getElementById('Create').addEventListener('click', async function (event) {
//    event.preventDefault();
//    $('table,#mask').addClass('loading');
//    document.getElementById('myModalContent').innerHTML = await CreateForm();
//    $('#myModal').modal({ keyboard: true }, 'show');
//    $('table,#mask').removeClass('loading');
//})

document.getElementById('SearchByPageSize')?.addEventListener('change', async function (event) {
    event.preventDefault();
    paramModel.PageSize = this.value;
    await SearchData(paramModel);
})
document.getElementById('Pagination_SearchKey')?.addEventListener('keyup', function () {
    setTimeout(async () => {
        paramModel.SearchKey = this.value; await SearchData(paramModel);
    }, 1500)
})