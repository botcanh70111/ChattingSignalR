var hub = $.connection.myChatHub;
hub.client.Message = function(mess) {
    $("#messages").append("<p>" + mess + "</p>");
}
hub.client.User = function(mess) {
    $("#user").append("<p>" + mess + "</p>");
}

$.connection.hub.start(function() {
    $("#send").click(function () {
        hub.server.send($("#text").val());
        $("#text").val(" ");
    });
})