'use strict'

const onlineServer = $.connection.RemoteIPHUB;
$.connection.hub.qs = { loginID: loginName }
$.connection.hub.start().done(function () {
}).fail(function (error) {
    toastr.error('signal connection failed: ' + error);
});

onlineServer.client.updateUsersOnlineCount = function (count) {
    document.getElementById('onlineClient').innerHTML = count
}

onlineServer.client.logOut = function () {
    window.location.href = '/Authentication/LogOff'
}